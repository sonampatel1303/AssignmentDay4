using AssignmentTask.Classes;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using static AssignmentTask.Classes.Books;

namespace AssignmentTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) Create a Book and Author class with suitable properties and Hardcoded with Minimum 5 
            //data for both the classes and covert into Json and XML Format 
            //and store that data in Local Disk using File  concept.Read the Json and XML data and display the same in console App

            #region serialization
            //    List<Author> authors = new List<Author>
            //    {
            //        new Author { AuthorId = 1, Name = "George Orwell", Nationality = "British" },
            //        new Author { AuthorId = 2, Name = "J.K. Rowling", Nationality = "British" },
            //        new Author { AuthorId = 3, Name = "Ernest Hemingway", Nationality = "American" },
            //        new Author { AuthorId = 4, Name = "Jane Austen", Nationality = "British" },
            //        new Author { AuthorId = 5, Name = "Mark Twain", Nationality = "American" }
            //    };

            //    List<Book> books = new List<Book>
            //    {
            //        new Book { BookId = 1, Title = "1984", PublicationYear = 1949, AuthorId = 1 },
            //        new Book { BookId = 2, Title = "Harry Potter", PublicationYear = 1997, AuthorId = 2 },
            //        new Book { BookId = 3, Title = "The Old Man and the Sea", PublicationYear = 1952, AuthorId = 3 },
            //        new Book { BookId = 4, Title = "Pride and Prejudice", PublicationYear = 1813, AuthorId = 4 },
            //        new Book { BookId = 5, Title = "Adventures of Huckleberry Finn", PublicationYear = 1884, AuthorId = 5 }
            //    };
            //    string jsonAuthorsPath = @"C:\Users\Sonam Patel\OneDrive\Documents\.NetPractice\authors.json";
            //    string jsonBooksPath = @"C:\Users\Sonam Patel\OneDrive\Documents\.NetPractice\books.json";
            //    string xmlAuthorsPath = @"C:\Users\Sonam Patel\OneDrive\Documents\.NetPractice\authors.xml";
            //    string xmlBooksPath = @"C:\Users\Sonam Patel\OneDrive\Documents\.NetPractice\books.xml";

            //    // Serialize to JSON
            //    File.WriteAllText(jsonAuthorsPath, JsonSerializer.Serialize(authors));
            //    File.WriteAllText(jsonBooksPath, JsonSerializer.Serialize(books));

            //    // Serialize to XML
            //    SerializeToXml(authors, xmlAuthorsPath);
            //    SerializeToXml(books, xmlBooksPath);

            //    // Read JSON and display
            //    Console.WriteLine("Authors from JSON:");
            //    DisplayDataFromJson<Author>(jsonAuthorsPath);
            //    Console.WriteLine("\nBooks from JSON:");
            //    DisplayDataFromJson<Book>(jsonBooksPath);

            //    // Read XML and display
            //    Console.WriteLine("\nAuthors from XML:");
            //    DisplayDataFromXml<Author>(xmlAuthorsPath);
            //    Console.WriteLine("\nBooks from XML:");
            //    DisplayDataFromXml<Book>(xmlBooksPath);
            //}

            //// Method to Serialize to XML
            //static void SerializeToXml<T>(List<T> data, string filePath)
            //{
            //    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            //    using (FileStream fs = new FileStream(filePath, FileMode.Create))
            //    {
            //        serializer.Serialize(fs, data);
            //    }
            //}

            //// Method to Display Data from JSON
            //static void DisplayDataFromJson<T>(string filePath)
            //{
            //    string jsonData = File.ReadAllText(filePath);
            //    List<T> data = JsonSerializer.Deserialize<List<T>>(jsonData);
            //    foreach (var item in data)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //// Method to Display Data from XML
            //static void DisplayDataFromXml<T>(string filePath)
            //{
            //    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            //    using (FileStream fs = new FileStream(filePath, FileMode.Open))
            //    {
            //        List<T> data = (List<T>)serializer.Deserialize(fs);
            //        foreach (var item in data)
            //        {
            //            Console.WriteLine(item);
            //        }
            //    }
            #endregion

            //        12) create a Customer class with the below properties
            //public string Name { get; set; }
            //    public string Email { get; set; }
            //    public string PhoneNumber { get; set; }
            //    public DateTime DateOfBirth { get; set; }
            // create a separate class to validate PhoneNumber, Email, DOB using some
            // function which should return bool (true if valid ,False if invalid)
            #region Regular Expressions
            //    Customer customer = new Customer
            //    {
            //        Name = "Sunidhi",
            //        Email = "johndoe@example.com",
            //        PhoneNumber = "+12345678",
            //        DateOfBirth = new DateTime(2000, 5, 15)
            //    };

            //    // Validating Customer data
            //    bool isPhoneValid = Validators.ValidatePhoneNumber(customer.PhoneNumber);
            //    bool isEmailValid = Validators.ValidateEmail(customer.Email);
            //    bool isDOBValid = Validators.ValidateDateOfBirth(customer.DateOfBirth);

            //    // Display validation results
            //    Console.WriteLine($"Customer: {customer.Name}");
            //    Console.WriteLine($"Phone Valid: {isPhoneValid}");
            //    Console.WriteLine($"Email Valid: {isEmailValid}");
            //    Console.WriteLine($"Date of Birth Valid (Age >= 18): {isDOBValid}");
            //}

            #endregion


            // 13) Create a TransportManager class to manage a list of transport schedules

            //LINQ Operations:

            //Search.Find schedules by transport type, route, or time
            //Group By, Group schedules by transport type(bus or flight)

            //Order By.Order schedules by departure time, price, or seats available

            //Filter Filter schedules based on availability of seats or routes within a time range

            //Aggregate Calculate the total number of available seats and the average price of transport

            //Select Project a list of rouses and their departure times

            TransportManager manager = new TransportManager();

            // Adding sample data
            manager.AddSchedule(new TransportSchedule { TransportType = "bus", Route = "Route A", DepartureTime = DateTime.Now.AddHours(1), ArrivalTime = DateTime.Now.AddHours(3), Price = 25.50m, SeatsAvailable = 30 });
            manager.AddSchedule(new TransportSchedule { TransportType = "flight", Route = "Route B", DepartureTime = DateTime.Now.AddHours(2), ArrivalTime = DateTime.Now.AddHours(5), Price = 150.00m, SeatsAvailable = 20 });
            manager.AddSchedule(new TransportSchedule { TransportType = "bus", Route = "Route C", DepartureTime = DateTime.Now.AddHours(4), ArrivalTime = DateTime.Now.AddHours(6), Price = 15.00m, SeatsAvailable = 50 });
            manager.AddSchedule(new TransportSchedule { TransportType = "flight", Route = "Route A", DepartureTime = DateTime.Now.AddHours(6), ArrivalTime = DateTime.Now.AddHours(8), Price = 200.00m, SeatsAvailable = 10 });
            manager.AddSchedule(new TransportSchedule { TransportType = "bus", Route = "Route B", DepartureTime = DateTime.Now.AddHours(1.5), ArrivalTime = DateTime.Now.AddHours(2.5), Price = 20.00m, SeatsAvailable = 5 });

            // Example usage of LINQ operations
            Console.WriteLine("Search Results:");
            foreach (var schedule in manager.Search(transportType: "bus"))
                Console.WriteLine(schedule);

            Console.WriteLine("\nGrouped By Transport Type:");
            foreach (var group in manager.GroupByTransportType())
            {
                Console.WriteLine($"\nTransport Type: {group.Key}");
                foreach (var schedule in group)
                    Console.WriteLine(schedule);
            }

            Console.WriteLine("\nOrdered by Price:");
            foreach (var schedule in manager.OrderBy("price"))
                Console.WriteLine(schedule);

            Console.WriteLine("\nFilter by Seats Available >= 20:");
            foreach (var schedule in manager.Filter(minSeats: 20))
                Console.WriteLine(schedule);

            var (totalSeats, avgPrice) = manager.AggregateSeatsAndPrice();
            Console.WriteLine($"\nTotal Seats Available: {totalSeats}, Average Price: {avgPrice}");

            Console.WriteLine("\nRoutes and Departure Times:");
            foreach (var routeInfo in manager.SelectRoutesAndDepartureTimes())
                Console.WriteLine($"Route: {routeInfo.Route}, Departure Time: {routeInfo.DepartureTime}");
        }

    }
}
