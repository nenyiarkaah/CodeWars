using ConsecutiveStrings;
using System;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ConsecutiveStrings.Tests
{
    [TestFixture]
    public static class LongestConsecutivesTests
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test01()
        {
            Console.WriteLine("Basic Tests");
            testing(
                LongestConsecutives.LongestConsec(
                    new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2), "abigailtheta");

        }
        [Test]
        public static void test02()
        {
            testing(
                LongestConsecutives.LongestConsec(
                    new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1),
                "oocccffuucccjjjkkkjyyyeehh");
        }
        [Test]
        public static void test03()
        {
            testing(LongestConsecutives.LongestConsec(new String[] { }, 3), "");
        }
        [Test]
        public static void test04()
        {
            testing(
                LongestConsecutives.LongestConsec(
                    new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" },
                    2), "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");
        }
        [Test]
        public static void test05()
        {
            testing(
                LongestConsecutives.LongestConsec(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2),
                "wlwsasphmxxowiaxujylentrklctozmymu");
        }

        public static void test06()
        {
            testing(
                LongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2), "");
        }
        [Test]
        public static void test07()
        {
            testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3),
                "ixoyx3452zzzzzzzzzzzz");
        }
        [Test]
        public static void test08()
        {
            testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15), "");
        }
        [Test]
        public static void test09()
        {
            testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0), "");
        }
    }

}