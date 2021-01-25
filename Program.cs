using System;
using System.Collections.Generic;

namespace Preparing
{

    class Program
    {
        static void Main(string[] args)
        {
            string task = Console.ReadLine();
            string[] parts = task.Split(new char[] { ' ', '/' });
            List<int> znam = new List<int>();
            List<int> chisl = new List<int>();
            char slozh = '+';
            char vich = '-';
            char umn = '*';
            char del = ':';
            
            for (int i = 0; i<parts.Length; i++)
            {
                chisl.Add(int.Parse(parts[0]));
                znam.Add(int.Parse(parts[1]));
                chisl.Add(int.Parse(parts[3]));
                znam.Add(int.Parse(parts[4]));

            }
            int res = 0;
            if (parts[2] == slozh.ToString())
            {

                if (znam[0] == znam[1])
                {
                    res = res + chisl[0] + chisl[1];
                    Console.WriteLine(res + $"/{znam[0]}");
                }
                if (znam[0] != znam[1])
                {
                    chisl[1] = znam[0] * chisl[1];
                    znam[1] = znam[1] * znam[0];
                    res = res + chisl[0] + chisl[1];
                    Console.WriteLine(res + $"/{znam[0]}");
                }
            }
            if((parts[2] == vich.ToString()))
            {
                if (znam[0] == znam[1])
                {
                    res = res + chisl[0] - chisl[1];
                    Console.WriteLine(res + $"/{znam[0]}");
                }
                if (znam[0] != znam[1])
                {
                    chisl[1] = znam[0] * chisl[1];
                    znam[1] = znam[1] * znam[0];
                    res = res + chisl[0] - chisl[1];
                    Console.WriteLine(res + $"/{znam[0]}");
                }
            }
            if ((parts[2] == umn.ToString()))
            {
                chisl[0] = chisl[0] * chisl[1];
                znam[0] = znam[0] * znam[1];
                Console.WriteLine($"{chisl[0]}" + "/" + $"{znam[0]}");
            }
            if ((parts[2] == del.ToString()))
            {
                
                chisl[0] = chisl[0] * znam[1];
                znam[0] = znam[0] * chisl[1];
                Console.WriteLine($"{chisl[0]}" + "/" + $"{znam[0]}");
            }
        }
    }
}
