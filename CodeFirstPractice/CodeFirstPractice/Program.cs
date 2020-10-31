using CodeFirstPractice.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CodeFirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("Please enter a shelf name to add: ");
            input = Console.ReadLine().Trim();

            using (ShelfContext context = new ShelfContext())
            {
                try
                {
                    addShelf(input, context);
                    Console.WriteLine("Shelf successully added.");
                }
                catch
                {
                    Console.WriteLine("ERROR: Please ensure input is valid and try again.");
                }
            }
        }
        public static void addShelf(string shelfName, ShelfContext context)
        {
            var newShelf = new Shelf(shelfName);
            context.Shelves.Add(newShelf);
            context.SaveChanges();
        }
    }
}
