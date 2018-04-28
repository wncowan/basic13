using System;

namespace basic_13
{
    class Program
    {

        public static void print1to255()
        {
            for(int i = 1 ; i < 256 ; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void printOddsBetween1to255()
        {
            for(int i = 1 ; i < 256 ; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void printSum()
        {
            int sum = 0;
            for(int i = 1 ; i < 256 ; i++)
            {
                sum += i;
                Console.WriteLine("new number: " + i + "Sum: " + sum);
            }
        }
        public static void iteratingThroughAnArray(int[] arr)
        {
            foreach(int number in arr)
            {
                Console.WriteLine(number);
            }
        }
        public static void findMax(int[] arr)
        {
            int max = arr[0];
            foreach(int number in arr)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }
        public static void findAverage(int[] arr)
        {
            double sum = 0;
            double arr_length = arr.Length;
            double average;
            foreach(int number in arr)
            {
                sum += number;
            }
            average = sum/arr_length;
            Console.WriteLine(average);
        }
        public static void arrayWithOddNumbers()
        {
            int[] y = new int[128];
            for(int x = 1; x < 256; x+=2)
            {
                int i = (x-1)/2;
                y[i] = x;
            }
            foreach(int number in y)
            {
                Console.WriteLine(number);
            }
        }
        public static int greaterThanY(int[] arr, int y)
        {
            int count = 0;
            foreach(int number in arr)
            {
                // Console.WriteLine(number);
                if(number > y)
                {
                    count++;
                }
            }
            // Console.WriteLine("count: " +  count);
            return count;
        }
        public static int[] squareArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                // Console.WriteLine(number);
                arr[i] *= arr[i];
            }
            foreach(int number in arr)
            {
                Console.WriteLine(number);
            }
            // Console.WriteLine("count: " +  count);
            return arr;
        }
        public static int[] eliminateNegativeIntegers(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                // Console.WriteLine(number);
                if(arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            foreach(int number in arr)
            {
                Console.WriteLine(number);
            }
            // Console.WriteLine("count: " +  count);
            return arr;
        }
        public static float[] minMaxAverage(float[] arr)
        {
            float sum = 0;
            float length = arr.Length;
            float average;
            float max = arr[0];
            float min = arr[0];
            float[] result = new float[3];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            average = sum/length;

            result[0] = min;
            result[1] = max;
            result[2] = average;

            foreach(float number in result)
            {
                Console.WriteLine(number);
            }
            return result;
        }
        public static int[] shiftValues (int[] arr)
        {
            for(int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = arr[i+1];
            }
            arr[arr.Length - 1] = 0;
            foreach(int number in arr)
            {
                Console.WriteLine(number);
            }
            // Console.WriteLine("count: " +  count);
            return arr;
        }
        public static object[] numberToString (int[] arr)
        {
            object[] result = new object[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    result[i] = "Dojo";
                }
                else
                {
                    result[i] = arr[i];
                }
            }
            foreach(object value in result)
            {
                Console.WriteLine(value);
            }
            // Console.WriteLine("count: " +  count);
            return result;
        }
        static void Main(string[] args)
        {
            int[] numArray = {-1,3,2,-4};
            // findAverage(numArray);
            Console.WriteLine(numberToString(numArray));
        }
    }
}

