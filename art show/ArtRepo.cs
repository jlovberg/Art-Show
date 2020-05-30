using System.Collections.Generic;
using System.Linq;

namespace art_show_app
{
    using art_show_app.models;
    using System;

    public class ArtRepo
        : IArtRepo
    {
        private Model1 artModel;
        public ArtRepo()
        {
            artModel = new Model1();
        }

        /// <summary>
        /// return a list of all artists
        /// </summary>
        /// <returns></returns>

        public List<artist> GetArtists()
        {
            var query =
                from a in artModel.artists
                select a;
            return query.ToList();
        }

        /// <summary>
        /// return an artist details given their name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>

        public artist GetArtist(string name)
        {
            var query =
                from a in artModel.artists
                where (a.name == name)
                select a;
            return query.SingleOrDefault();
        }

        /// <summary>
        /// return a list of all artworks
        /// </summary>
        /// <returns></returns>

        public List<artwork> GetArtWorks()
        {
            var query =
                from a in artModel.artworks
                select a;
            return query.ToList();
        }

        /// <summary>
        /// Return a piece of artwork given its name
        /// </summary>
        /// <param name="uniqueTitle"></param>
        /// <returns></returns>

        public artwork GetArtWork(string uniqueTitle)
        {
            var query =
                from a in artModel.artworks
                where (a.unique_title == uniqueTitle)
                select a;
            return query.SingleOrDefault();
        }

        /// <summary>
        /// return a list of all customers
        /// </summary>
        /// <returns></returns>

        public List<customer> GetCustomers()
        {
            var query =
                from a in artModel.customers
                select a;
            return query.ToList();
        }

        /// <summary>
        /// return a specific customer given their phone number
        /// </summary>
        /// <param name="uniqueTitle"></param>
        /// <returns></returns>
        public customer GetCustomer(string uniqueTitle)
        {
            var query =
             from a in artModel.customers
             where (a.phone == uniqueTitle)
             select a;
            return query.SingleOrDefault();
        }

        /// <summary>
        /// return a list of all art shows
        /// </summary>
        /// <returns></returns>

        public List<art_show> getArtShows()
        {
            var query =
             from a in artModel.art_show
             select a;
            return query.ToList();
        }

        /// <summary>
        /// Returns an art show at a given date and location
        /// </summary>
        /// <param name="showDate"></param>
        /// <param name="location"></param>
        /// <returns></returns>

        public art_show getArtShow(DateTime showDate, string location)
        {
            var query =
             from a in artModel.art_show
             where (a.date_and_time == showDate) && (a.location == location)
             select a;
            return query.SingleOrDefault();

        }

        /// <summary>
        /// Return all customers that prefer the same type of art as being displayed on show
        /// </summary>
        /// <param name="showDate"></param>
        /// <param name="location"></param>
        /// <returns></returns>

        public List<customer> GetPotentialCustomersByShow(DateTime showDate, string location)
        {
            var query =
                 from ass in artModel.art_show
                 join aw in artModel.artworks
                 on ass.artist equals aw.artist
                 join c in artModel.customers
                 on aw.type_of_art equals c.art_preferences
                 where(( ass.date_and_time == showDate) && (ass.location == location))
                select c;
            return query.Distinct().ToList();
        }
    }
}
