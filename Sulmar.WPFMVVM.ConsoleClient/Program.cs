using Sulmar.WPFMVVM.ConsoleClient.Models;
using Sulmar.WPFMVVM.ConsoleClient.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerValidateTest();


            Console.WriteLine($"#{Thread.CurrentThread.ManagedThreadId}");

            // Calculate();
            // Console.WriteLine($"Result = {result}");

            //Task<decimal> task = Task.Run(()=>Calculate());

            //CalculateAsync()
            //    .ContinueWith(task => Console.WriteLine($"Result = {task.Result}"));

            // Task.Run(() => TestAsync());
         
            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }

        private static void CustomerValidateTest()
        {
            Customer customer = new Customer
            {
                FirstName = "Ma",
                Email = "marcin.sulecki"
            };


            
            var validator = new CustomerValidator();


            var result = validator.Validate(customer);

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error);
                }
            }


        }

        static async void TestAsync()
        {
            decimal result = await CalculateAsync();

            Console.WriteLine($"Result = {result}");


        }


        //static void Main(string[] args)
        //{
        //    decimal result = Calculate();

        //    Console.WriteLine($"Result = {result}");

        //    Console.WriteLine("Press any key to exit.");

        //    Console.ReadKey();
        //}


        //static Task<decimal> CalculateAsync()
        //{
        //    return Task.Run(() => Calculate());
        //}


        static Task<decimal> CalculateAsync()
        {
            return Task.Run(() => Calculate());
        }

        static decimal Calculate()
        {
            Console.WriteLine($"#{Thread.CurrentThread.ManagedThreadId} Calculating...");

            Thread.Sleep(TimeSpan.FromSeconds(5));

            Console.WriteLine($"#{Thread.CurrentThread.ManagedThreadId} Calculated");

            return 100;
        }
    }
}
