namespace art_show_app
{
    using System.Collections.Generic;
    using art_show_app.models;
    using System;

    public interface IArtRepo
    {
        List<artist> GetArtists();

        artist GetArtist(string uniqueTitle);

        List<artwork> GetArtWorks();

        artwork GetArtWork(string uniqueTitle);

        List<customer> GetCustomers();

        customer GetCustomer(string uniqueTitle);

        art_show getArtShow(DateTime showDate, string location);

        List<art_show> getArtShows();

        List<customer> GetPotentialCustomersByShow(DateTime showDate, string location);


    }
}