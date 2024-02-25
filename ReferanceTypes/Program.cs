using System;
using System.Threading.Tasks;

namespace ReferanceTypes
{
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    class program
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
    {
        static void Main(string[] args)
        {
            // INT - DECIMAL- FLOAT -ENUM - BOOLEAN- VALUE TYPES

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("sayi :" + sayi2);


            //ARRAYS

            int[] sayilar1 = new int[] { 1, 2, 3 };

            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("Sayilar[0] = " + sayilar1[0]);



            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "ilayda";

            person2 = person1;
            person1.FirstName = "Samet";

            //Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "Berat";
            customer.CreditCardNumber = "123458697";


            Employee employee = new Employee();
            employee.FirstName = "Beyhan";
            //employe.EmployeNumber = "258";


            Person person3 = customer;
            customer.FirstName = "Eyup";


            //Console.WriteLine(((Customer).person3).CreditCardnumber);

            personManager personManager = new personManager();
            personManager.Add(employee);
        }
    }
    class Person
    {
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string FirstName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string LastName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
    class Customer : Person
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string CreditCardNumber { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
    class Employee : Person
    {

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string EmployeNumber { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    }
    class personManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
