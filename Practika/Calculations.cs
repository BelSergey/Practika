using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practika
{
    public static class Calculations
    {

        // ++ sorting
        public static void sorting(int[,] a)
        {
            if (a == null)
            {
                throw new ArgumentNullException(nameof(a));
            }

            int rLng = a.GetLength(0);
            int cLng = a.GetLength(1);
            if (rLng != cLng)
            {
                throw new ArgumentException($"incorrect array size: {rLng} * {cLng}");
            }

            if (rLng % 2 > 0)
            {
                throw new ArgumentException($"incorrect array size: {rLng} нечетное", nameof(a));
            }

            int n = rLng / 2;

            int i, k, jmax;
            int z;
            for (i = 0; i < 2 * n; i++)
            {
                for (int j = n; j < 2 * n; j++)
                {
                    jmax = j;   //поиск очередного максимума
                    for (k = j + 1; k < 2 * n; k++)
                    {
                        if (a[i, k] > a[i, jmax] && i >= n - j + 1 && i <= j)
                        {
                            jmax = k;
                        }
                    }
                    //перестановка элементов
                    z = a[i, j];
                    a[i, j] = a[i, jmax];
                    a[i, jmax] = z;

                }
            }

            for (i = 0; i < 2 * n; i++)
            {
                for (int j = n - 1; j >= 1; j--)
                {
                    jmax = j;       //поиск очередного максимума
                    for (k = j - 1; k >= 0; k--)
                    {
                        if (a[i, k] > a[i, jmax] && i <= n - j + 1 && i >= j)
                        {
                            jmax = k;
                        }
                    }       //перестановка элементов
                    z = a[i, j];
                    a[i, j] = a[i, jmax];
                    a[i, jmax] = z;
                }
            }
        }

        // -- sorting
        // ++ zeroing
        public static void zeroing(int[,] a)
        {
            if (a == null)
            {
                throw new ArgumentNullException(nameof(a));
            } 

            int rLng = a.GetLength(0);
            int cLng = a.GetLength(1);
            if (rLng != cLng)
            {
                throw new ArgumentException($"incorrect array size: {rLng} * {cLng}");
            }

            if (rLng % 2 > 0)
            {
                throw new ArgumentException($"incorrect array size: {rLng} нечетное", nameof(a));
            }

            int n = rLng / 2;


            for (int i = 0; i < n; i++)
            {
                for (int j = 1 + i; j < 2 * n - 1 - i; j++)
                {
                    a[i, j] = 0;
                }
            }
            for (int i = n + 1; i < 2 * n; i++)
            {
                for (int j = 2 * n - i; j < i; j++)
                    a[i, j] = 0;

            }


        }
    }
}
