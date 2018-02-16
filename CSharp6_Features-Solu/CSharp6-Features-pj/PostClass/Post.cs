using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp6_Features_pj.PostClass
{
    internal class Post
    {
        // In c#6, you can assign value to auto-property directly, previously, you have to pass value to constructor to assign value to property.
        public DateTime DateCrated { get; set; } = DateTime.Now;
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public string Title { get; set; } = "Post-Title-Haha";

        // in c#6 -->  you can have getter only property.
        public int Votes { get; } = 100;

        // In C# 6, we can use the => notation to immediately implement the getter for DaysOld property:
        // public int DaysOld => (DateCrated - DateTime.Today).TotalDays;

        internal void Hw() => Console.WriteLine($"In c#6 we can use => to implement property or method.");
    }
}
