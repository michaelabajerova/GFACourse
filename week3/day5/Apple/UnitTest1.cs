using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace Apple
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
        // Get Apple //
        public void Epl()
        {
            var appol = new Apples();
            string output = appol.GetApple("apple");
            string expected = "apple";
            Assert.Equal(expected, output);
        }
        [Fact]
        // Sum //
        public void Summ()
        {
            var sumList = new List<int>() { 5, 10, 15, 20 };

            var test = new Sum();
            int output = test.Summon(sumList);
            int expected = 50;
            Assert.Equal(expected, output);
        }
        [Fact]
        public void emptyList()
        {
            Sum empty = new Sum();
            List<int> emptyList = new List<int>();
            int expected = 0;
            Assert.Equal(expected.ToString(), empty.ToString());
        }
        [Fact]
        // Anagram //
        public void Anam()
        {
            var isAn = new Anagram();
            bool output = isAn.IsAnagramm("Hello there", "general Kenobi");
            bool expected = true;
            Assert.Equal(expected, output);
        }
        [Fact]
        // Count Letters //
        public void Counting()
        {
            var test = new CountLetter();
            Dictionary<char, int> expected = new Dictionary<char, int>(); { {'b', 7}, { 'r', 9}, { 'u', 4}, { 'h', 1} };
            var output = test.Count("bruh");

            Assert.Equal(expected, output);

        }
    }
}
