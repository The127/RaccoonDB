using System;
using RaccoonDB.Interface;

namespace RaccoonDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RaccoonDbDriver raccoonDbDriver = new RaccoonDbDriver("db.raccoon");
            var result = raccoonDbDriver.ExecuteSql("create table test;");
            Console.WriteLine(result);
        }
    }
}