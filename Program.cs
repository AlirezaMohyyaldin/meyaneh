using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_meyaneh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] x = new int[50, 50];
            for (int b = 0; b < 50; b++) 
            {
                for (int c = 0; c < 50; c++)
                {
                    x[b, c] = random.Next(1, 10);
                }
            }
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    for (int y = 1; y < x[49, 49]; y++)
                    {
                        x[i, j] = (i - 1) + (i) + (i + 1) / 3;
                        x[i, j] = (j - 1) + (j) + (j + 1) / 3;
                        Console.WriteLine("[{0}, {1}] = {2}", i, j, x[i, j]);
                    }
                }
            }


            }
        }
    }

