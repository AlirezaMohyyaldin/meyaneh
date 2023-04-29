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
            int[,] x = new int[50, 50];
            for (int i = 1; i < 50; i++)
            {
                for (int j = 1; j < 50; j++)
                {
                    for(int y = 1; y < x[50,50]; y++)
                    x[i, j] = (i - 1) + (i) + (i + 1) / 3;
                    Console.WriteLine("[{0}, {1}] = {2}", i, j, x[i, j]);
                }
            }


            }
        }
    }

