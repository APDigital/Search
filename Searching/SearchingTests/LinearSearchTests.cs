using Microsoft.VisualStudio.TestTools.UnitTesting;
using Searching;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching.Tests
{
    [TestClass()]
    public class LinearSearchTests
    {
        [TestMethod()]
        public void SearchSingleLinearTest()
        {
            string path = @"../../words.txt";
            var lines = File.ReadLines(path).ToList();

            LinearSearch search = new LinearSearch();
            search.SearchLinear("AAA", lines);
            Assert.IsNotNull(search);
        }

        [TestMethod()]
        public void SearchMultipleLinearTest()
        {
            string path = @"../../words.txt";
            var lines = File.ReadLines(path).ToList();

            LinearSearch search = new LinearSearch();
            for (int i = 0; i < 10001; i++)
            {
                var searchItem = RandomLetter.GetLetter();
                search.SearchLinear(searchItem, lines);

            }
            Assert.IsNotNull(search);
        }
    }
}