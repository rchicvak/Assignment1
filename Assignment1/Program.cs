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
                // Prime number logic uses the idea that only needs to use square root of a number
                // a = x,  b = y
               // Debug.WriteLine(x);
                // Debug.WriteLine(y);
                // sets up number of iterations as x - y
                int iterations = y - x;
                for (int i = 0;
                    i <= iterations;
                        i++)
                {
                    int number = x + i;
                    var limit = Math.Ceiling(Math.Sqrt(number));
                    // sets up boolean logic to identify if isPrime = True / False
                    bool isPrime = true;
                    for (int j = 2; j <= limit; j++)
                    {
                        // identifies if prime, in this case if modulo = 0, then isPrime = False
                        if (number % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                    // sets up isPrime = true, writes out number
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
                //
        
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
                // logic was to understand the nuber of stars on each line and determine the relationship
                // for example each line in the tree decreased by 2
                // i = used in calculation number of stars
                for(int i = 1; 
                        i <= n; 
                        i++)
                {
                    int numberOfStars = i * 2 - 1;
                    // based on the number of stars for each line for example top line had 1 so  = 1*2-1 = 1,  2*2-1 = 3
                    int numberOfSpaces = n - i;
                    // below is the creation in the line of the tree comprised of the concatination on stars and spaces
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
                // Below sets up the number of accumulators for each type of number
                // includes a try and catch block to capture errors and end gracefully
                int numberOfOnes = 0;
                int numberOfTwos = 0;
                int numberOfThrees = 0;
                // loop used to go through the numbers and use an if statement to increment the accumulator
                for (int i = 0; i < a.Length; i++)
                {
                // a[i] is the position in the array,   it increments after it updates the accumulators found above
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
                // writes out the accumulator with concatination statement
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
