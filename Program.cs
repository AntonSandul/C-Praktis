﻿/*
        int[] array = {15, 26, 33, 47, 52, 15, 16, 17, 38, 59};
        int n = array.Length;
        int find = 15;
        int index = 0;
        while (index < n)
        {
            if (array[index] == find)
            {
                Console.WriteLine(index);
                break;
            }
            index++;
        }*/

/*
        void FillArray(int[] collection)
        {
            int length = collection.Length;
            int index = 0;
            while(index < length)
            {
                collection[index] = new Random().Next(1, 10);
                index++;
            }
        }
        void PrintArray(int[] col)
        {
            int count = col.Length;
            int position = 0;
            while(position < count)
            {
                Console.WriteLine(col[position]);
                position++;
            }
        }
        int IndexOf(int[]collection, int find)
        {
            int count = collection.Length;
            int index = 0;
            int position = -1;
            while(index < count)
            {
                if(collection[index] == find)
                {
                  position = index;
                  break;
                }
                index++;
            }
            return position;
        }
        int[] array = new int[10];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine();
        int pos = IndexOf(array, 76);
        Console.WriteLine(pos);
        *//*
 static void Main()
 {
  double a = 3;
  double b = 7;
  double res = (a / b);
  Console.WriteLine(res);
  Console.ReadKey();
 }
 */
//вывод двухчисел после запятой
/*
double a = 500d/7;
 Console.WriteLine("{0:#.##}", a);
 Console.ReadKey();
*/
