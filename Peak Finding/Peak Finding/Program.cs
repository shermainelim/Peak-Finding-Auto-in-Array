using System;

namespace Peak_Finding
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[] { 1, 2, 6, 5, 3, 7, 4};
            //Array.Sort(marks);
            Console.WriteLine(peak1d(marks, 0, marks.Length-1));
            // i is first index, j is last is last index
            //Console.WriteLine(peak1d2(marks));
            
            //Console.WriteLine(peak(marks));
        }

        static int peak1d(int[] array, int i, int j)
        {
            //O(1)
            int m = (i + j) / 2;
            if (array[m] >= array[m - 1] && array[m] >= array[m + 1])
            {
                return m;
            }
            else if (array[m - 1] > array[m])
            {
                return peak1d(array, i, m - 1);
            }
            else if (array[m] < array[m + 1])
            {
                return peak1d(array, m + 1, j);
            }
            return m;
        }
        //static int peak1d2(int[] array)
        //{
        //    return search(array, 0, array.Length - 1);
        //}

        //public static int search(int[] array, int l, int r)
        //{
        //    if (l == r)
        //    {
        //        return l;
        //    }
        //    int mid = (l + r) / 2;
        //    if (array[mid] > array[mid + 1])
        //    {
        //        return search(array, l, mid);
        //    }
        //    return search(array, mid + 1, r);
        //}
        //int l = 0;
        //int r = array.Length - 1;
        //int mid = 0;

        //    while (l<r)
        //    {
        //        mid = (l + r) / 2;
        //    }
        //    //if left side is bigger than mid
        //    if (array[mid - 1] > array[mid])
        //    {
        //        r = mid - 1;
        //    }
        //    // if right side is bigger than mid
        //    else if (array[mid + 1] > array[mid])
        //    {
        //        l = mid + 1;
        //    }
        //    //larger than both neighbours
        //    else
        //    {
        //        return mid;
        //    }
        //    return l; // leftmost index or rightmost index
        //}
    }
            }
