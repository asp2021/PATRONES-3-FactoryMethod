using System;

namespace FactoryMethod
{
    class Program
    {
        public class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Country { get; set; }

            private User (string name, string email, string country)
            {
                Name = name;
                Email = email;
                Country = country;
            }

            public static class Factory
            {
                public static User CreateWithDefaultCountry(string name, string email)
                {
                    return new User(name, email, "Argentina");
                }

                public static User CreateWithDefaultEmail(string name, string country)
                {
                    return new User(name, "daniel@gmail.com", country);
                }
            }
        }

        static void Main(string[] args)
        {
            var user = User.Factory.CreateWithDefaultCountry("Daniel", "daniel@gmail.com");

            Console.WriteLine("FACTORY METHOD" + '\n');
            Console.WriteLine("El proceso de inicializacion se puede realizar dentro de una funcion en donde entra el patron de diseño factory metod" + '\n');


            Console.WriteLine($"Usuario: {user.Name}, Email: {user.Email}, País: {user.Country}");
            Console.ReadLine();
        }
        
    }
}
