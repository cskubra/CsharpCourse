using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deneme1();

            //ArrayList();

            //List();

            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item); // dictionary collecitiondur. 
            }
            
            Console.WriteLine(dictionary.ContainsKey("glass")); // CountainsKey (ilk veri tipi (string, int gibi gibi) ) verilen değer varsa true yoksa false döndürür
            Console.WriteLine(dictionary.ContainsKey("table")); // CountainsValue (ikinci veri tipi)
            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");


            //Console.WriteLine(cities.Contains("Ankara")); //cities içinde ankara varsa true döner. yoksa false


            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, Name = "Kubra" });
            //customers.Add(new Customer { Id = 2, Name = "Olga" });


            //farklı yazım tipi
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Kubra" },
                new Customer { Id = 2, Name = "Olga" }
            };


            var customer2 = new Customer
            {
                Id = 3,
                Name = "Dexter"
            };


            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer{Id = 4,Name="Dexter"},
                new Customer{Id=5,Name="Umut Kerem"}
            });


            var index = customers.IndexOf(customer2); //index değerini döndürür

            Console.WriteLine("Index : {0}", index);

            customers.Add(customer2);
            var index2 = customers.LastIndexOf(customer2); //son index değerinin döndürür
            Console.WriteLine("Index : {0}", index2);

            customers.Insert(0, customer2);   //insert kaçıncı sıraya neyi eklemek istiyorsun
            customers.Remove(customer2);  //ilk bulduğunu remove eder. bulamazsa işlem yapmaz
            customers.RemoveAll(c => c.Name == "Umut Kerem"); //umut kerem i siler






            //customers.Clear(); //elemanları silmek

            Console.WriteLine(customers.Contains(customer2)); //değerlerle ilgisi yoktur. referansı baz alır.


            var count = customers.Count;
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }

            Console.WriteLine("Count : {0} ", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');


            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            //Console.WriteLine(cities[2]);
        }

        private static void Deneme1()
        {
            string[] cities = new string[2] { "Ankara", "İstanbul" };
            cities = new string[3];

            Console.WriteLine(cities[0]);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
