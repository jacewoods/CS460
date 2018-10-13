﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generateBinary
{
    public class Program
    {
        static LinkedList<string> generateBinaryRepresentationList(int n)
        {
            LinkedQueue<StringBuilder> q = new LinkedQueue<StringBuilder>();

            LinkedList<string> output = new LinkedList<string>();

            if(n < 1)
            {
                return output;
            }

            q.Push(new StringBuilder("1"));

            while(n-- > 0)
            {
                StringBuilder sb = q.Pop();
                output.AddLast(sb.ToString());

                StringBuilder sbc = new StringBuilder(sb.ToString());

                sb.Append('0');
                q.Push(sb);

                sbc.Append('1');
                q.Push(sbc);

            }
            return output;
        }
        static void Main(string[] args)
        {
            int n = 10;
            if(args.Length < 1)
            {
                Console.WriteLine("Please invoke with the max value to print binary up to, like this:");
                Console.WriteLine("\tC# Program 12");
                return;
            }
            try
            {
                n = int.Parse(args[0]);
            }
            catch (FormatException e)
            {
                Console.WriteLine("I'm sorry, I can't understand the number: " + args[0]);
                return;
            }
            LinkedList<string> output = generateBinaryRepresentationList(n);

            int maxLength = output.Last().Length;
            foreach (string s in output)
            {
                for(int i =0; i < maxLength - s.Length; ++i)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(s);
            }

        }
           
    }
}
