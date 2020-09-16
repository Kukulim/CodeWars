﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CodeWars
{
    internal static class Program
    {
        private static void Main()
        {
            //Console.WriteLine();
            Console.WriteLine(Evaluate("1 - 1+1"));
        }
        public static double Evaluate(string expression)
        {
            string Snumber = expression.Replace(" ", "");
            List<object> list = new List<object>();
            foreach (var item in Snumber)
            {
               list.Add(item);
            }

            while (list.Find(c => c.ToString() == "*") != null)
            {
                var result = 0;
                var index = list.FindIndex(r => r.ToString() == "*");
                result = int.Parse(list[index - 1].ToString()) * int.Parse(list[index + 1].ToString());
                list[index] = result;
                list.RemoveAt(index - 1);
                list.RemoveAt(index);
            }
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            while (list.Find(c => c.ToString() == "/") != null)
            {
                var result = 0;
                var index = list.FindIndex(r => r.ToString() == "/");
                result = int.Parse(list[index - 1].ToString()) / int.Parse(list[index + 1].ToString());

                list[index] = result;
                list.RemoveAt(index - 1);
                list.RemoveAt(index);
            }
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            while (list.Find(c=>c.ToString()=="-")!=null)
                {
                    var result = 0;
                    var index = list.FindIndex(r => r.ToString() == "-");
                    result = int.Parse(list[index - 1].ToString()) - int.Parse(list[index + 1].ToString());
                list[index] = result;
                list.RemoveAt(index - 1);
                list.RemoveAt(index);
            }
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            while (list.Find(c => c.ToString() == "+") != null)
            {
                var result = 0;
                var index = list.FindIndex(r => r.ToString() == "+");
                result = int.Parse(list[index - 1].ToString()) + int.Parse(list[index + 1].ToString());
                list[index] = result;
                list.RemoveAt(index - 1);
                list.RemoveAt(index);
            }
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            return double.Parse(list[0].ToString());
        }
    }
}