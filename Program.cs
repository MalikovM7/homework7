using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters;

namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {




            Task12();




        }



        static void Task1()
        {

            //1.  a massivinin (a[0],a[1] ....
            //a[n])  |a[i]| < c sertini odeyen elementlerini cap etmek
            //(c deyisheninin qiymeti istifadeciden sorushulur,hemcinin a massivinin elementleri de)

            int c = Readint("c ededini daxil edin");

            int len = Readint("daxil olunacaq massivde nece element olsun?: ");

            int[] a = new int[len];



            for (int i = 0; i < len; i++)
            {


                a[i] = Readint($"massivin {i + 1}-ci elementini daxil edin");


            }
            for (int j = 0; j < len; j++)
            {
                if (a[j] < c)
                {
                    Console.Write($"{a[j]}  ");
                }
            }

            static int Readint(string caption)
            {
            l1:
                Console.WriteLine(caption);
                string cStr = Console.ReadLine();
                bool state = int.TryParse(cStr, out int c);
                if (!state)
                {
                    Console.WriteLine("tam eded daxil edin");
                    goto l1;
                }
                return c;
            }


        }
        static double CalculateMean(int[] array)
        {
            if (array.Length == 0)
            {
                return 0; // Avoid division by zero
            }

            int sum = 0;

            foreach (int number in array)
            {
                sum += number;
            }

            return (double)sum / array.Length;
        }


        static int ReadInt(string caption)
        {
            var backupColor = Console.ForegroundColor;
        l1:

            string aStr = Console.ReadLine();
            bool state = int.TryParse(aStr, out int a);
            if (!state)
            {

                goto l1;
            }
            return a;
        }


        static void Task2()
        {
            // Ask the user for the size of the array
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            // Declare an array of integers with the specified size
            int[] numbers = new int[size];

            // Input numbers into the array
            Console.WriteLine($"Enter {size} numbers, one at a time:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Display the numbers in the console
            Console.WriteLine("Numbers entered in the array:");

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            double mean = CalculateMean(numbers);
            Console.WriteLine($"\nMean of the numbers: {mean}");


        }

        static void Task3()
        {


            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());


            int[] numbers = new int[size];


            Console.WriteLine($"Enter {size} numbers, one at a time:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Numbers entered in the array:");

            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }


            double algmean = GeometricMean(numbers);
            Console.WriteLine($"\nAlgebraic Mean of the numbers: {algmean}");


        }


        static double GeometricMean(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            int product = 1;

            foreach (int number in array)
            {
                product *= number;
            }

            return Math.Pow(product, 1.0 / array.Length);



        }


        static void Task4()
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

          
            int[] a = new int[size];

            
            Console.WriteLine($"Enter {size} numbers, one at a time:");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the threshold value (c): ");
            int c = int.Parse(Console.ReadLine());

            
            var filteredArray = a.Where(x => Math.Abs(x) > c).ToArray();

           
            Array.Sort(filteredArray, (x, y) => Math.Abs(y).CompareTo(Math.Abs(x)));

          
            Console.WriteLine("\nOriginal Array:");
            DisplayArray(a);

            Console.WriteLine($"\nElements with |a[i]| > {c}, sorted by absolute values:");
            DisplayArray(filteredArray);

            Console.ReadLine(); 
        }

        static void DisplayArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();





        }

        static void Task5()
        {



            int c = Readint("c ededini daxil edin");

            int len = Readint("daxil olunacaq massivde nece element olsun?: ");

            int[] a = new int[len];



            for (int i = 0; i < len; i++)
            {


                a[i] = Readint($"massivin {i + 1}-ci elementini daxil edin");


            }

            int maxElement = a[0];
            for (int j = 0; j < len; j++)
            {
                if (a[j] < c )
                {

                    if (a[j] > maxElement)
                    {
                        maxElement = a[j];

                        

                    }

                    

                }
            }
            Console.WriteLine(maxElement);

            static int Readint(string caption)
            {
            l1:
                Console.WriteLine(caption);
                string cStr = Console.ReadLine();
                bool state = int.TryParse(cStr, out int c);
                if (!state)
                {
                    Console.WriteLine("tam eded daxil edin");
                    goto l1;
                }
                return c;
            }

        }

        static void Task6()
        {
            Console.Write("Enter array X (example: 1 4 9 16 25): ");
            int[] X = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Enter array Y (example: 1 2 3 4 5): ");
            int[] Y = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] xIndices = new int[0];

            
            if (X.Length != Y.Length)
            {
                Console.WriteLine("Arrays X and Y do not have the same length!");
                return;
            }

            
            for (int i = 0; i < X.Length; i++)
            {
                if (X[i] == Y[i] * Y[i])
                {
                    Array.Resize(ref xIndices, xIndices.Length + 1);
                    xIndices[xIndices.Length - 1] = i;
                }
            }

            // Print the result
            Console.Write("Indices where X[i] = Y[i]^2: ");
            foreach (int index in xIndices)
            {
                Console.Write($"{index} ");
            }
        }

        static void Task7()
        {


            Console.Write("Enter array elements (example: 1 4 9 16 25): ");

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int maxValue = a[0];
            int minValue = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minValue)
                {
                    minValue = a[i];
                }
                else if (a[i] > maxValue)
                {
                    maxValue = a[i];
                }
            }


            Console.WriteLine(Math.Pow(minValue*maxValue, 1.0 / a.Length));

            Console.WriteLine((maxValue+minValue)/2);



        }
        static void Task8()
        {
            
            int[] array1 = { 2, 5, 8, -3, 12, 7, 6, -1, 9, 11, 15, -6, 4, 10 };
            int[] array2 = { -4, 9, 7, 0, 14, -2, 8, 3, 5, -7, 11, 6, -9, 1 };

          
            int[] resultArray = new int[Math.Min(array1.Length, array2.Length)];
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = array1[i] * array2[i];
            }

            
            resultArray = resultArray.Where(x => x > 0).ToArray();

            
            Console.WriteLine("Array 1:");
            DisplayArray(array1);

            Console.WriteLine("\nArray 2:");
            DisplayArray(array2);

            Console.WriteLine("\nResult array:");
            DisplayArray(resultArray);

            Console.ReadLine(); 
        }

      
        static void Task9()
        {

            int[] originalArray = new int[25];

            for (int i = 0; i < originalArray.Length; i++)
            {
                bool validInput = false;

                while (!validInput)
                {
                    Console.Write($"Enter element {i + 1} of the array: ");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out originalArray[i]))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }

            // Square the first 8 elements of the array
            for (int i = 0; i < Math.Min(8, originalArray.Length); i++)
            {
                originalArray[i] = originalArray[i] * originalArray[i];
            }

            // Divide the remaining elements by 4
            for (int i = 8; i < originalArray.Length; i++)
            {
                originalArray[i] = originalArray[i] / 4;
            }

            // Print the modified array
            Console.WriteLine("Modified Array:");
            foreach (int element in originalArray)
            {
                Console.Write($"{element} ");
            }




        }

        static void Task10()
        {

            int[] originalArray = new int[10];

            for (int i = 0; i < originalArray.Length; i++)
            {
                bool validInput = false;

                while (!validInput)
                {
                    Console.Write($"Enter element {i + 1} of the array: ");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out originalArray[i]))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }

            int maxNegative = int.MinValue;

            foreach (int element in originalArray)
            {
                if (element < 0 && element > maxNegative)
                {
                    maxNegative = element;
                }
            }

            if (maxNegative != int.MinValue)
            {
                Console.WriteLine($"Maximum negative element in the array: {maxNegative}");
            }
            else
            {
                Console.WriteLine("No negative elements found in the array.");
            }







        }


        static void Task11()
        {



            
            int n = 11;

            
            Random random = new Random();

            int[] X = new int[n];

            // 
            for (int i = 0; i < n; i++)
            {
                X[i] = random.Next(0, 101); 
            }

            Console.WriteLine("Original array:");
            foreach (int element in X)
            {
                Console.Write(element + " ");
            }

            Array.Sort(X);

           
            Array.Reverse(X);

           
            Console.WriteLine("\nSorted array:");
            foreach (int element in X)
            {
                Console.Write(element + " ");
            }




        }



        static void Task12()
        {

        
            int n = 20;

            Random random = new Random();

            int[] X = new int[n];

            
            for (int i = 0; i < n; i++)
            {
                X[i] = random.Next(0, 101); 
            }

           
            double firstHalfSum = 0;
            for (int i = 0; i < n / 2; i++)
            {
                firstHalfSum += X[i];
            }
            double firstHalfAverage = firstHalfSum / (n / 2);

            double secondHalfSum = 0;
            for (int i = n / 2; i < n; i++)
            {
                secondHalfSum += X[i];
            }
            double secondHalfAverage = secondHalfSum / (n / 2);

            Console.WriteLine("Array:");

            foreach (int element in X)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();

            Console.WriteLine($"Average of the first half: {firstHalfAverage}");
            Console.WriteLine($"Average of the second half: {secondHalfAverage}");






        }
    }

    }

