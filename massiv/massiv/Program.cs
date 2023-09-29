using System;

namespace massiv
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] massiv = new int[100];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = i;
                Console.Write(massiv[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(Search(massiv, 156));

        }

        public static int Search(int[] value, int val)
        {
            int l = 0;
            int r = value.Length - 1;
            int s = value.Length / 2;
            while (l <= r)
            {
                if (value[s] == val)
                {
                    return s;
                }

                if (value[s] < val)
                {
                    l = s + 1;
                }
                else
                {
                    r = s - 1;
                }

                s = (l + r) / 2;
            }

            return -1;
        }
        
        
    }
}