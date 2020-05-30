using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using art_show_app.models;

namespace art_show_app
{
    class Program
    {
        static void Main(string[] args)
        {
            IArtRepo repo = new ArtRepo();
            Console.WriteLine("Type database you wish to query");
            string input = Console.ReadLine();
            if (input == "artwork")
            {
                Console.WriteLine("Enter title of art or press a to see all the artwork");
                input = Console.ReadLine();
                if (input != "a")
                {
                    //search for artwork by title
                    artwork a = repo.GetArtWork(input);
                    Console.WriteLine($"Artwork name, artist, date of creation, date acquired, type, price, customer phone, location = {a.unique_title},  {a.artist}, {a.date_of_creation},{a.date_acquired},{a.type_of_art},{a.price},{a.customerphone},{a.location}");

                }
                else
                {
                    List<artwork> ab = repo.GetArtWorks();
                    //print a list of all the artworks
                    foreach (artwork a in ab)
                    {
                        Console.WriteLine($"Artwork name, artist, date of creation, date acquired, type, price, customer phone, location = {a.unique_title},  {a.artist}, {a.date_of_creation},{a.date_acquired},{a.type_of_art},{a.price},{a.customerphone},{a.location}");
                    }
                    Console.WriteLine("Would you like to sort by style?");
                    input = Console.ReadLine();
                    if (input == "yes")
                    {
                        //sort artwork by style
                        List<artwork> aws = repo.GetArtWorks();
                        var query =
                        from aw in aws
                        orderby aw.type_of_art ascending
                        select aw;
                        List<artwork> sorted = query.ToList();
                        foreach (artwork a in sorted)
                        {
                            Console.WriteLine($"Artwork name, artist, date of creation, date acquired, type, price, customer phone, location = {a.unique_title},  {a.artist}, {a.date_of_creation},{a.date_acquired},{a.type_of_art},{a.price},{a.customerphone},{a.location}");
                        }
                    }
                }
            }
            else if (input == "artist")
            {
                Console.WriteLine("Enter name of artist or press a to see all the artists");
                input = Console.ReadLine();
                if (input != "a")
                {
                    //search for artist based on name 
                    artist a = repo.GetArtist(input);
                    Console.WriteLine($"name, address, phone, birthplace, age, style = {a.name},  {a.address}, {a.phone},{a.birth_place},{a.age},{a.style_of_art}");
                }
                else
                {
                    //print list of all artists
                    List<artist> ab = repo.GetArtists();
                    foreach (artist a in ab)
                    {
                        Console.WriteLine($"name, address, phone, birthplace, age, style = {a.name},  {a.address}, {a.phone},{a.birth_place},{a.age},{a.style_of_art}");
                    }
                        Console.WriteLine("Would you like to sort by style?");
                    input = Console.ReadLine();
                    if (input == "yes")
                    {
                        //sort artists by style
                        List<artist> aws = repo.GetArtists();
                        var query =
                        from aw in aws
                        orderby aw.style_of_art ascending
                        select aw;
                        List<artist> sorted = query.ToList();
                        foreach (artist a in sorted)
                        {
                            Console.WriteLine($"name, address, phone, birthplace, age, style = {a.name},  {a.address}, {a.phone},{a.birth_place},{a.age},{a.style_of_art}");
                        }
                    }
                }
            }
            else if (input == "customer")
            {
                Console.WriteLine("Enter phone# of customer or press a to see all the customers");
                input = Console.ReadLine();
                //search for customer by phone number
                if (input != "a")
                {
                    customer a = repo.GetCustomer(input);
                    Console.WriteLine($"Customer name, phone, preference = {a.name}, {a.phone}, {a.art_preferences}");
                }
                else
                {
                    //print a list of all customers
                    List<customer> ab = repo.GetCustomers();
                    foreach (customer a in ab)
                    {
                        Console.WriteLine($"Customer name, phone, preference = {a.name}, {a.phone}, {a.art_preferences}");
                    }
                    Console.WriteLine("Would you like to sort by preference?");
                    input = Console.ReadLine();
                    if (input == "yes")
                    {
                        //sort customers by art preference
                        List<customer> aws = repo.GetCustomers();
                        var query =
                        from aw in aws
                        orderby aw.art_preferences ascending
                        select aw;
                        List<customer> sorted = query.ToList();
                        foreach (customer a in sorted)
                        {
                            Console.WriteLine($"Customer name, phone, preference = {a.name}, {a.phone}, {a.art_preferences}");
                        }
                    }
                }

            }
            else if (input == "artshow")
            {
                Console.WriteLine("Enter art show date and time or press a to see all shows");
                input = Console.ReadLine();
                if (input != "a")
                {
                    //find art show by date and time
                    DateTime inputtedDateArt = DateTime.Parse(input);
                    Console.WriteLine("Enter location of show");
                    input = Console.ReadLine();
                    art_show a = repo.getArtShow(inputtedDateArt, input);
                    Console.WriteLine($"location, date and time, artist, contact name, contact phone = {a.location},{a.date_and_time},{a.artist},{a.contact_name}, {a.contact_phone}");
                }
                else
                {
                    //list all art shows
                    List<art_show> ab = repo.getArtShows();
                    foreach (art_show a in ab)
                    {
                        Console.WriteLine($"location, date and time, artist, contact name, contact phone = {a.location},{a.date_and_time},{a.artist},{a.contact_name}, {a.contact_phone}");
                    }
                }

            }
            //See potential customers by show
            Console.WriteLine("Enter datetime of art show");
            DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter location of show");
            input = Console.ReadLine();
            List<customer> potentialCustomers = repo.GetPotentialCustomersByShow(inputtedDate, input);
            foreach (customer c in potentialCustomers)
            {
                Console.WriteLine($"Customer name, phone number = {c.name} , {c.phone}");
            }
            Console.ReadLine();


        }
       
    }
}
