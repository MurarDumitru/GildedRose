using System.Collections.Generic;
using System;


namespace GildedRose.Console
{
    public static class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Item();
            app.GetItem();

            app.UpdateQuality();

            System.Console.ReadKey();

        }
    }




}
