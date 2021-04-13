using System;
using System.Data.SqlClient;


namespace AdoNetDemo
{
    class MainClass
    { 

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //"Data Source=192.168.0.3\\SQLEXPRESS;Initial Catalog=NorthWind;User ID=sa;Password=someThingComplicated1234";
            string connectionString = "Server= 127.0.0.1; Initial Catalog = Northwind; User ID=sa; Password =someThingComplicated1234;";

            SqlConnection connection = new(connectionString);
            connection.Open();
            Console.WriteLine("Connection Establihsed");

            string sql = "select * from customers where country= 'finland' ";
            // SQL command run takees command text and connection
            SqlCommand command = new(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            // Reading the data
            while (reader.Read())
            {
                string companyName = reader["CompanyName"].ToString();
                Console.WriteLine(companyName);
            }
            reader.Close();


            // SQL INSERT
            Console.WriteLine("Adding new customer ");
            Customers customer = ReadData();


            // Parameterized Instert, avoids sql injection

            sql = "INSERT INTO [dbo].[Customers]([CusomerID], [CompanyName], [ContactName], [ContactTitle], [Address])" +
                "[City], [Region],  [PostalCode], [Country], [Phone], [Fax]" +
                $"VALUES(@id, @name, @contact, @title, " +
                "'RaadinKatu', 'Turku', NULL, '21540', 'Finland', '123421908' NULL";


            SqlCommand command2 = new(sql, connection);
        }
        private static Customers ReadData()
        {
            Customers customer = new();
            Console.WriteLine("Give CustomerId");
            string  input = Console.ReadLine();
            customer.CustomerID = input;
            Console.WriteLine("Give Company Name");
             input = Console.ReadLine();
            customer.CompanyName = input;
            Console.WriteLine("Give Contact Name");
             input = Console.ReadLine();
            customer.ContactName = input;
            Console.WriteLine("Give Contact Title");
             input = Console.ReadLine();
            customer.ContactTitle = input;

            return (customer);
        }
    }
}
