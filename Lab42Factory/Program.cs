using System;
using Lab42Factory.Classes;

namespace Lab42Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Thesis thesis = new Thesis();
            Resume resume = new Resume();
            Console.WriteLine("Lets create some documents");
            Console.WriteLine("------------");
            thesis.CreateDocument();
            resume.CreateDocument();
            Console.WriteLine("------------");
            Console.WriteLine("Lets see what is inside of each document!");
            Console.WriteLine("------------");
            Console.WriteLine("Our thesis contains:");
            foreach(Page page in thesis.Pages)
            {
                Console.WriteLine(page.PageType());
            }
            Console.WriteLine("------------");
            Console.WriteLine("Our resume contains:");
            foreach (Page page in resume.Pages)
            {
                Console.WriteLine(page.PageType());
            }
            Console.WriteLine("------------");
        }
    }
}
