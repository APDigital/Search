﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../words.txt";
            var lines = File.ReadLines(path).ToList();



            //Linear Search
            //Console.WriteLine("Write a word and see if it is in the List");
            //string searchItem = Console.ReadLine();
            //LinearSearch search = new LinearSearch();
            //search.SearchLinear(searchItem, lines);

            //for (int i = 0; i < 10001; i++)
            //{
            //    var searchItem = RandomLetter.GetLetter();
            //    search.SearchLinear(searchItem, lines);

            //}

            //Binary Search
            Console.WriteLine("Write a word and see if it is in the List");
            string searchItem = Console.ReadLine();
            //for (int i = 0; i < 10001; i++)
            //{
                //var searchItem = RandomLetter.GetLetter();
                int index = lines.BinarySearch(searchItem);

                Console.WriteLine("'{0}' found at index {1}", searchItem, index);
            //}




        }
    }
}
