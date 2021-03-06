using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  

namespace QuickSort
{

    class Program
    {
        static int q;
        static void Main(string[] args)
        {
            int[] siralanacak = { 4, 7, 1, 15, 3, 8 };
            int[] sirali = QuickSort(siralanacak, 0, 5);
            foreach (var item in sirali)
            {

                Console.WriteLine(item);
            }
        }

        static int[] QuickSort(int[] siralanacak, int p, int r)
        {
            if (p < r)
            {
                siralanacak = Parcala(siralanacak, p, r);
                QuickSort(siralanacak, p, q - 1);
                QuickSort(siralanacak, q + 1, r);

            }
            return siralanacak;
        }

        static int[] Parcala(int[] siralanacak, int p, int r)
        {
            int i = p - 1;
            int temp;
            int x = siralanacak[r];
            for (int j = p; j <= r - 1; j++)
            {
                if (siralanacak[j] <= x)
                {
                    i++;
                    Degistir(siralanacak, j, i);
                }
            }
            Degistir(siralanacak, i + 1, r);
            q = i + 1;
            return siralanacak;
        }

        static int[] Degistir(int[] siralanacak, int indis1, int indis2)
        {
            int temp;
            temp = siralanacak[indis1];
            siralanacak[indis1] = siralanacak[indis2];
            siralanacak[indis2] = temp;
            return siralanacak;
        }
    }
}

