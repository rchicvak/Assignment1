using System;
using System.Diagnostics;

namespace Assignment1
{
    class Program
    {
        public static void Main()
        {
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Debug.WriteLine("The sum of the series is: " + r1);


            int n4 = 5;
            printTriangle(n4);

            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            // write your self-reflection here as a comment

        }

        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                // Write your code here
               // Debug.WriteLine(x);
                // Debug.WriteLine(y);
                int iterations = y - x;
                for (int i = 0;
                    i <= iterations;
                        i++)
                {
                    int number = x + i;
                    var limit = Math.Ceiling(Math.Sqrt(number));

                    bool isPrime = true;
                    for (int j = 2; j <= limit; j++)
                    {
                        if (number % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        Debug.WriteLine(number);
                    }
                }
                        

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        public static double getSeriesResult(int n)
        {
            try
            {
                // goal - fraction with odd numerator as +, Numerators increment by 1 and create factorial
                //        denominator = numerator + 1
                // n = max number for number of fractions  i.e.  5
        
                double result = 0;
                for (int i = 1;
                        i <= n;
                            i++)
                {
                    // 1/2 - 2!/3 + 3!/4 - 4!/5 + 5!/6
                    // create the factorial for the numerator
                    // use j to keep track of all numbers between 2 and i
                    int numerator = 1;
                    for (int j = 2;
                        j <= i;
                            j++)
                    {
                        // multiply the numerator so far by j to construct the factorial
                        numerator = numerator * j;
                    }
                    int denominator = i + 1;
                    double fraction = (double)numerator / denominator;
                    
                    if (i % 2 == 0)
                    {
                        result = result - fraction; 
                    }
                    else
                    {
                        result = result + fraction;
                    }

                }
                return result;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }

            return 0;
        }

        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here
                for(int i = 1; 
                        i <= n; 
                        i++)
                {
                    int numberOfStars = i * 2 - 1;
                    int numberOfSpaces = n - i;
                    string line = new String(' ', numberOfSpaces) + new String('*', numberOfStars);
                    Debug.WriteLine(line);
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static void computeFrequency(int[] a)
        {
            try
            {
                // a = { 1, 2, 3, 2, 2, 1, 3, 2 };
                // for example a[2] = 3 above   (starting at 0)
                // Write your code here
                int numberOfOnes = 0;
                int numberOfTwos = 0;
                int numberOfThrees = 0;
                for(int i = 0; i < a.Length; i++)
                {
                    if(a[i] == 1)
                    {
                        numberOfOnes++;
                    }
                    else if(a[i] == 2)
                    {
                        numberOfTwos++;
                    }
                    else
                    {
                        numberOfThrees++;
                    }
                }

                Debug.WriteLine("Number      Frequency");
                Debug.WriteLine("1           " + numberOfOnes);
                Debug.WriteLine("2           " + numberOfTwos);
                Debug.WriteLine("3           " + numberOfThrees);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}
