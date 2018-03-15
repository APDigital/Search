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
    public class BinarySearchTests
    {
        [TestMethod()]
        public void BinarySingleTest()
        {
            string path = @"../../words.txt";
            var lines = File.ReadLines(path).ToList();

            BinarySearch search = new BinarySearch();
            search.Binary("AAA", lines);
            Assert.IsNotNull(search);
        }
        [TestMethod()]
        public void BinaryMultipleTest()
        {
            string path = @"../../words.txt";
            var lines = File.ReadLines(path).ToList();

            BinarySearch search = new BinarySearch();
            for (int i = 0; i < 10001; i++)
            {
                var searchItem = RandomLetter.GetLetter();
                search.Binary(searchItem, lines);
                Assert.IsNotNull(search);
            }
        }
    }
}