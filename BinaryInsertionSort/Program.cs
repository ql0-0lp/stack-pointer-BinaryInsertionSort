using System;

namespace BinaryInsertionSort
{
    class Program
    {

        public static void Main(string[] args)
        {
            Stack values = new Stack();

            values.Push(6);
            values.Push(4);
            values.Push(8);
            values.Push(3);
            values.Push(2);
            values.Push(7);
            values.Push(9);
            values.Push(1);
            values.Push(0);
            values.Push(5);

            values.Print();
            Console.WriteLine("\n-----------------------------------\n");

            for (int i = 1; i < values.size; ++i) // бинарная сортировка вставкой
            {
                int j = i - 1;
                int temp = values.Get(i);
                int l = binarySearch(values, j, 0, temp);
                while (j >= l)
                {
                    values.Set(j + 1, values.Get(j));
                    --j;
                }
                values.Set(l, temp);
            }

            values.Print();

            Console.ReadKey();

        }

        public static int binarySearch(Stack values, int max, int min, int k)
        {
            if (max == min)
                return (k > values.Get(min)) ? (min + 1) : min;
            int mid = (max + min) / 2;
            if (k == values.Get(mid))
                return mid;
            else if (k < values.Get(mid))
                return binarySearch(values, mid - 1, min, k);
            else
                return binarySearch(values, max, mid + 1, k);
        }

    }
}
