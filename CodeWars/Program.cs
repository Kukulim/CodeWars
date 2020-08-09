using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            {
                var cos = UniqueInOrder(new List<int> { 1, 2 });
                //var cos = UniqueInOrder("111222");

                foreach (var item in cos)
                {
                    Console.Write(item);
                }
            }
        }
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var test = "";

            var testdupl=new List<char>();
            foreach (var item in iterable)
            {
                test +=Convert.ToChar(item);
            }
            if (test == "")
            {
                return (IEnumerable<T>)testdupl;
            }
            testdupl.Add(test[0]);

            for (int i = 1; i < test.Length - 1; i++)
            {
                if (test[i] != test[i - 1])
                {
                    testdupl.Add(test[i]);
                }
            }
            if (testdupl[testdupl.Count - 1] != test[test.Length - 1])
            {
                testdupl.Add(test[test.Length - 1]);
            }
            return (IEnumerable<T>)testdupl;
        }
    }
}