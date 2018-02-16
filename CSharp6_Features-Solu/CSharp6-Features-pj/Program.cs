using System;
using System.Collections.Generic;
using CSharp6_Features_pj.PostClass;

namespace CSharp6_Features_pj
{
    public class Program
    {
        static void Main(string[] args)
        {
            Post p = new Post();
            Console.WriteLine($"Post Created Date: {p.DateCrated}.");
            Console.WriteLine("\nIn c#6, you can assign value to auto-property directly, previously, you have to pass value to constructor to assign value to property.\n");

            Console.WriteLine("Dictionary has index-like syntax.\n");
            var dictionary = new Dictionary<string, string>
            {
                ["LAX"] = "Los Angeles International Airport",
                ["MEL"] = "Melbourne Tullamarine Airport",
                ["KAN"] = "M-kda wuzimagi naludo wuqiha sasuke.",
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine($"key: {item.Key} -- value: {item.Value}.");
            }

            Console.WriteLine("\nNull-conditional Operator...\n");
            var pt = p?.Title;
            Console.WriteLine($"p?.Title -> title : {pt}.");

            List<Post> NewPosts = new List<Post>()
            {
                new Post{ Title="npt0", DateCrated = DateTime.Now.AddDays(-3) },
                new Post{ Title="npt1", DateCrated = DateTime.Now.AddDays(-30) },
                new Post{ Title="npt2", DateCrated = DateTime.Now.AddDays(-300) }
            };

            Post fp = NewPosts?[0];
            Console.WriteLine($"\nNewPosts First one -- title: {fp.Title} -- crated date: {fp.DateCrated}.\n");

            var titleType = p?.Title?.GetType();
            Console.WriteLine($"type of title is: {titleType}.");

            // In c#6 we can use => to implement property or method.
            p.Hw();

            ExitClass ec = new ExitClass();
            ec.ExitApp();
        }
    }
}
