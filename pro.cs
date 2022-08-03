using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "Code academy";
            for (int i = 0; i < metin.Length; i++)
                if (metin[i] == 'a')
                {
                    Console.WriteLine("a herfi var");
                    break; }
                    else
                    {
                        
                            Console.WriteLine("a herfi yoxdur");
                        break;
                    }
                        
                }
            

            }
        }
    

