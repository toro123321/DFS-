using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFS_
{
    class Program
    {
        static void Main(string[] args)
        {
            const int w = 3, h = 3;
            int counter = 0;
            /*Console.Write("Jaka jest szerokosc? ");
            int w = Convert.ToInt32(Console.ReadLine());

            Console.Write("Jaka jest wysokosc? ");
            int h = Convert.ToInt32(Console.ReadLine());
            */
            Node[,] things = new Node[w, h]
            {
                {new Node("mleko"), new Node("hg"), new Node("chleb") },
                {new Node("pumpernikiel"), new Node("nic"), new Node("nic") },
                {new Node("maslo"), new Node("nic"), new Node("nic") },
            };


            //for (int a = 0; a < w; a++)
            //{
            //    for (int b = 0; b < h; b++)
            //    {
            //        things[a, b].product = Convert.ToString(Console.ReadLine());
            //        things[a, b].id = counter++;
            //    }
            //}
            /*
            if (things[0, 1].product != "nic")
                things[0, 0].epsilon.Add(1);
            if (things[1, 0].product != "nic")
                things[1, 0].epsilon.Add(w);
            */
            for (int x = 0; x < w; x++) // zliczanie otoczenia
            {
                for (int y = 0; y < h; y++)
                {
                    if (things[x, y].product == "nic")
                        break;
                    else
                    {
                        if (x - 1 >= 0 && things[x - 1, y].product != "nic") things[x, y].epsilon.Add(things[x - 1, y].id);
                        if (y - 1 >= 0 && things[x, y - 1].product != "nic") things[x, y].epsilon.Add(things[x, y - 1].id);
                        if (x + 1 < w  && things[x + 1, y].product != "nic") things[x, y].epsilon.Add(things[x + 1, y].id);
                        if (y + 1 < h  && things[x, y + 1].product != "nic") things[x, y].epsilon.Add(things[x, y + 1].id);
                    }
                }
            }
            /*
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    Console.WriteLine("Otoczenie liczby {0} {1} rowna sie ", x, y);
                    for (int z = 0; z < things[x,y].epsilon.Count; z++)
                    {                        
                        Console.WriteLine(things[x, y].epsilon[z]);
                    }
                }
            }
            */

            List <string> zakupy = new List <string> ();
            zakupy.Add("chleb");
            zakupy.Add("mleko");
            zakupy.Add("maslo");

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    for (int z = 0; z < zakupy.Count; z++)
                    {
                        if (things[x, y].product == zakupy[z]) things[x, y].seek = true;
                    }
                }
            }


            Console.ReadKey();
        }
        
    }
}
