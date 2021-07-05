using System;
using RaccoonDB.Interface;

namespace RaccoonDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RaccoonDbDriver raccoonDbDriver = new RaccoonDbDriver("db.raccoon");
            var result = raccoonDbDriver.ExecuteSql("create table test (foo int);");
            Console.WriteLine(result);
        }
    }
}