using System;
using System.Numerics;

namespace IntroToCSharp

{
    class HelloCSharp
    {
        static void Main()
        {
            //Chapter 1
            /*    DateTime now = DateTime.Now;
                double squareRoot = Math.Sqrt(12345);

                Console.WriteLine("1");
                Console.WriteLine("101");
                Console.WriteLine("1001");
                Console.WriteLine(now);
                Console.WriteLine(squareRoot);

                int sequence;
                for(int i = 2; i < 101; i++)
                {
                    if(i%2 == 0)
                    {
                        sequence = i;
                    }
                    else
                    {
                        sequence = i * (-1);
                    }
                    Console.WriteLine(sequence);
                }
                */
            //Chapter 2
            /*  byte centuries = 20;
              ushort years = 2000;
              uint days = 730480;
              ulong hours = 17531520;

              Console.WriteLine(centuries + " cneturies are " + years + " years, or " + days + " days, or " + hours + " hours. ");

              ulong maxIntValue = UInt64.MaxValue;
              Console.WriteLine(maxIntValue);

              float floatPI = 3.14f;
              Console.WriteLine(floatPI);
              double doublePI = 3.14;
              Console.WriteLine(doublePI);
              double nan = Double.NaN; Console.WriteLine(nan);
              double infinity = Double.PositiveInfinity;
              Console.WriteLine(infinity);


              float floatPi = 3.141592653589793238f;
              double doublePi = 3.141592653589793238;

              Console.WriteLine("Float PI is: " + floatPi);
              Console.WriteLine("Double PI is: " + doublePi);

              float f = 0.1f; 
              Console.WriteLine(f); 
              double d = 0.1f; 
              Console.WriteLine(d); 
              float ff = 1.0f / 3; Console.WriteLine(ff); 
              double dd = ff;
              Console.WriteLine(dd);

              decimal decimalPI = 3.14159265358979323846m;
              Console.WriteLine(decimalPI);

              int a = 1; int b = 2;
              // Which one is greater? 
              bool greaterAB = (a > b); // Is 'a' equal to 1?
              bool equalA1 = (a == 1); // Print the results on the console 
              if (greaterAB)
              { 
                  Console.WriteLine("A > B");
              }
              else 
              { 
                  Console.WriteLine("A <= B");
              }
              Console.WriteLine("greaterAB = " + greaterAB);
              Console.WriteLine("equalA1 = " + equalA1);

              // Declare a variable
              char ch = 'a';
              // Print the results on the console
              Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);

              ch = 'b';
              Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);

              // Declare some variables
              string firstName = "John";
              string lastName = "Smith";
              string fullName = firstName + " " + lastName; // Print the results on the console
              Console.WriteLine("Hello, " + firstName + "!");
              Console.WriteLine("Your full name is " + fullName + ".");

              //Declare some variables
              object container1 = 5;
              object container2 = "Five";

              // Print the result on the console
              Console.WriteLine("The value of container1 is: " + container1);
              Console.WriteLine("The value of container2 is: " + container2);

              int i = 5; 
              int? ni = i;
              Console.WriteLine(ni); // 5

              // i = ni; // this will fail to compile
              Console.WriteLine(ni.HasValue); // True
              i = ni.Value; Console.WriteLine(i); // 5
              ni = null;
              Console.WriteLine(ni.HasValue); // False //
             // i = ni.Value; // System.InvalidOperationException
              i = ni.GetValueOrDefault();
              Console.WriteLine(i); // 0

              int I = 42;
              char Ch = 'A';
              bool result = true;
              object obj = 42;
              string str = "Hello";
              byte[] bytes = { 1, 2, 3 };

              // An ordinary character
              char character = 'a';
              Console.WriteLine(character);
              // Unicode character code in a hexadecimal format
              character = '\u003A';
              Console.WriteLine(character);
              // Assigning the single quotiation character (escaped as \')
              character = '\'';
              Console.WriteLine(character);
              // Assigning the backslash character (escaped as \\)
              character = '\\';
              Console.WriteLine(character);

              string sentence = "The \" use \" of quotations causes difficulties.";
              Console.WriteLine(sentence);*/

            //Chapter 3

            /*  int t = 7 + 9;
              Console.WriteLine(t);

              string firstName = "John";
              string lastName = "Doe";

              // Do not forgert the space between them
              string fullName = firstName + " " + lastName;
              Console.WriteLine(fullName);

              int squarePerimeter = 17;
              double squareSide = squarePerimeter / 4.0;
              double squareArea = squareSide * squareSide;
              Console.WriteLine(squareSide); // 4.25
              Console.WriteLine(squareArea); // 18.0625
              int a = 5;
              int b = 4;
              Console.WriteLine(a + b); // 9
              Console.WriteLine(a + (b++)); // 9
              Console.WriteLine(a + b); // 10
              Console.WriteLine(a + (++b)); // 11
              Console.WriteLine(a + b); // 11
              Console.WriteLine(14 / a); // 2
              Console.WriteLine(14 % a); // 4
              int one = 1;
              int zero = 0;
              // Console.WriteLine(one / zero); // DivideByZeroException
              double dMinusOne = -1.0;
              double dZero = 0.0;
              Console.WriteLine(dMinusOne / zero); // -Infinity
              Console.WriteLine(one / dZero); // Infinity

              bool x = true;
              bool y = false;
              Console.WriteLine(x && y); // False
              Console.WriteLine(x || y); // True
              Console.WriteLine(!y); // True
              Console.WriteLine(y || true); // True
              Console.WriteLine((5 > 7) ^ (x == y)); // False

              string csharp = "C#";
              string dotnet = ".NET";
              string csharpDotNet = csharp + dotnet;
              Console.WriteLine(csharpDotNet); // C#.NET 
              string csharpDotNet4 = csharpDotNet + " " + 5;
              Console.WriteLine(csharpDotNet4); // C#.NET 5

              byte r = 3;
              byte s = 5;

              Console.WriteLine(r);
              Console.WriteLine(s);
              Console.WriteLine(r | s);
              Console.WriteLine(r & s);
              Console.WriteLine(r ^ s);
              Console.WriteLine(~r & s);
              Console.WriteLine(r << 1);
              Console.WriteLine(r << 2);
              Console.WriteLine(r >> 1);

              int c = 10, d = 5;
              Console.WriteLine("c > d : " + (c > d)); // True
              Console.WriteLine("c < d : " + (c < d)); // False
              Console.WriteLine("c >= d : " + (c >= d)); // True
              Console.WriteLine("c <= d : " + (c <= d)); // False
              Console.WriteLine("c == d : " + (c == d)); // False
              Console.WriteLine("c != d : " + (c != d)); // True

              int m = 2;
              int n = 4; 
              m *= n; // Same as m = m * n;
              Console.WriteLine(m); // 8

              int w = 6; int z = 3;
              Console.WriteLine(w + z / 2); // 7 
              Console.WriteLine((w + z) / 2); // 4
              string o = "Beer";
              Console.WriteLine(o is string); // True
              string notNullString = o;
              string nullString = null;
              Console.WriteLine(nullString ?? "Unspecified"); // Unspecified

              //implicit conversion9
              int myInt = 5;
              Console.WriteLine(myInt); // 
              long myLong = myInt;
              Console.WriteLine(myLong); // 5
              Console.WriteLine(myLong + myInt);

              //explicit conversion
              double myDouble = 5.1d;
              Console.WriteLine(myDouble); // 5.1
              long myLongg = (long)myDouble;
              Console.WriteLine(myLongg); // 5
              myDouble = 5e9d; // 5 * 10^9
              Console.WriteLine(myDouble); // 5000000000 
              int myIntt = (int)myDouble;
              Console.WriteLine(myInt); // -2147483648
              Console.WriteLine(int.MinValue); // -2147483648

              int aa = 5; int bb = 7;
              string sum = "Sum = " + (aa + bb);
              Console.WriteLine(sum);
              String incorrect = "Sum = " + aa + bb; 
              Console.WriteLine(incorrect);
              Console.WriteLine("Perimeter = " + 2 * (aa + bb) + ". Area = " + (aa * bb) + ".");*/
            //Chapter 3 exercises

            /* int a = 26;

             if(a%2 ==0)
             {
                 Console.WriteLine(a + " is even.");
             }
             else
             {
                 Console.WriteLine(a + " is odd.");
             }

             int Num = 23;
             bool Divisible = Num % 5 == 0 && Num % 7 == 0 ? true : false;
             Console.WriteLine(Divisible);

             int number = 36;
             bool divisible = number % 35 == 0 ? true : false;
             Console.WriteLine("{0} is divisible by both 5 and 7? {1}", number, divisible);

             int num = 1235;
             bool isSeven = (num / 100) % 10 == 7 ? true : false;
             Console.WriteLine(isSeven);

             int c = 3;
             int d = 3;
             int b = 9;
             int h = 9;

             double A = ((c + b) / 2) * h;
             Console.WriteLine(A);

             int area = c * b;
             int Perimeter = c + d + b + h;

             Console.WriteLine($"Area is: {area} and the perimeter is: {Perimeter}.");

             int Weight = 50;
             double weightOnTheMoon = (50 * 17) / 100;
             Console.WriteLine($"Weight on earth is {Weight} and the weight on the moon is {weightOnTheMoon}.");

             float t = 4;
             float s = -4;
             if(t <= 5 && s <= 5)
             {
                 Console.WriteLine("The point is within the circle.");
             }
             else
             {
                 Console.WriteLine("The point is not within the circle.");
             }

             Console.WriteLine("Enter a digit: ");
             int num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter a second digit: ");
             int num2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter a digit: ");
             int num3 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter a second digit: ");
             int num4 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("The sum is " + ( num1 + num2 + num3 + num4 ) + " in reverse its " + num4 + num3 + num2 + num1);*/

            //Chapter 4

            /* string name = "John";
             int age = 18;
             string town = "Seattle";
             Console.Write("{0} is {1} years old from {2}!\n", name, age, town);

             Console.Write("{1} is {0} years old from {3}!", 18, "John", 0, "Seattle");

             Console.WriteLine("{0,6}", 123);
             Console.WriteLine("{0,6}", 1234);
             Console.WriteLine("{0,6}", 12);
             Console.Write("{0,-6}", 123);
             Console.WriteLine("--end");

             Console.WriteLine("{0:C2}", 123.456);
             //Output: 123,46 лв.
             Console.WriteLine("{0:D6}", -1234);
             //Output: -001234
             Console.WriteLine("{0:E2}", 123);
             //Output: 1,23E+002
             Console.WriteLine("{0:F2}", -123.456);
             //Output: -123,46
             Console.WriteLine("{0:N2}", 1234567.8);
             //Output: 1 234 567,80
             Console.WriteLine("{0:P}", 0.456);
             //Output: 45,60 %
             Console.WriteLine("{0:X}", 254);
             //Output: FE

             Console.WriteLine("{0:0.00}", 1);
             //Output: 1.00
             Console.WriteLine("{0:#.##}", 0.234);
             //Output: .23
             Console.WriteLine("{0:#####}", 12345.67);
             //Output: 12346
             Console.WriteLine("{0:(0#) ### ## ##}", 29342525);
             //Output: (02) 934 25 25
             Console.WriteLine("{0:##%}", 0.234);
             //Output: %23

             DateTime d = new DateTime(2012, 02, 27, 17, 30, 22);
             Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);
             Console.WriteLine("{0:d.MM.yy}", d);

             Console.WriteLine("{0:G}", DayOfWeek.Wednesday);
             Console.WriteLine("{0:D}", DayOfWeek.Wednesday);
             Console.WriteLine("{0:X}", DayOfWeek.Wednesday);

             Console.Write("Please enter your first name: ");
             string firstName = Console.ReadLine();
             Console.Write("Please enter your last name: ");
             string lastName = Console.ReadLine();
             Console.WriteLine("Hello, {0} {1}!", firstName, lastName);

             int codeRead = 0;
             do
             {
                 codeRead = Console.Read();
                 if (codeRead != 0)
                 {
                     Console.Write((char)codeRead);
                 }
             }
             while (codeRead != 10);


             Console.Write("a = ");
             int a = int.Parse(Console.ReadLine());

             Console.Write("b = ");
             int b = int.Parse(Console.ReadLine());

             Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
             Console.WriteLine("{0} * {1} = {2}", a, b, a * b);

             Console.Write("f = ");
             double f = double.Parse(Console.ReadLine());
             Console.WriteLine("{0} * {1} / {2} = {3}", a, b, f, a * b / f);

             string str = Console.ReadLine();
             int intValue;
             bool parseSuccess = Int32.TryParse(str, out intValue);
             Console.WriteLine(parseSuccess ?
             "The square of the number is " + intValue * intValue + "."
             : "Invalid number!");

             ConsoleKeyInfo key = Console.ReadKey();
             Console.WriteLine();
             Console.WriteLine("Character entered: " + key.KeyChar);
             Console.WriteLine("Special keys: " + key.Modifiers);

                 Console.Write("Enter person name: ");
                 string person = Console.ReadLine();
                 Console.Write("Enter book name: ");
                 string book = Console.ReadLine();
                 string from = "Authors Team";
                 Console.WriteLine(" Dear {0},", person);
                 Console.Write("We are pleased to inform " +
                 "you that \"{1}\" is the best Bulgarian book. {2}" +
                 "The authors of the book wish you good luck {0}!{2}",
                 person, book, Environment.NewLine);
                 Console.WriteLine(" Yours,");
                 Console.WriteLine(" {0}", from);

             Console.WriteLine("This program calculates " + "the area of a rectangle or a triangle");
             Console.WriteLine("Enter a and b (for rectangle) " + "or a and h (for triangle): ");
          //   int a = int.Parse(Console.ReadLine());
            // int b = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter 1 for a rectangle or " + "2 for a triangle: ");
             int choice = int.Parse(Console.ReadLine());
             double area = (double)(a * b) / choice;
             Console.WriteLine("The area of your figure is " + area);

             Console.Write("Enter three digits: ");
             int number = int.Parse(Console.ReadLine());
             int num1 = number % 10;
             int num2 = (number / 10) % 10;
             int num3 = (number / 100) % 10;
             Console.WriteLine("The sum of the digits is: " + (num1 + num2 + num3));

             Console.Write("Enter radius: ");
             int radius = int.Parse(Console.ReadLine());
             double Area = Math.PI * Math.Sqrt(radius);
             double Perimeter = 2 * Math.PI * radius;
             Console.WriteLine("Area of a circle is: " + Area + "and its perimeter is: " + Perimeter);

             Console.Write("Enter your company name: ");
             string companyName = Console.ReadLine();
             Console.Write("Enter your companys address: ");
             string companyAddress = Console.ReadLine();
             Console.Write("Enter your compays phone number: ");
             Console.WriteLine("Your companys name is " + companyName + " and the address is " + companyAddress);

             int numbers = 6;
             switch (numbers)
             {
                 case 1:
                 case 4:
                 case 6:
                 case 8:
                 case 10:
                     Console.WriteLine("The number is not prime!"); break;
                 case 2:
                 case 3:
                 case 5:
                 case 7:
                     Console.WriteLine("The number is prime!"); break;
                 default:
                     Console.WriteLine("Unknown number!"); break;
             }

            Console.Write("Enter a first digit: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter a second digit: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter a third digit: ");
            int num3 = int.Parse(Console.ReadLine());
            if(num1 < num2 && num3 < num2)
            {
                Console.WriteLine(num2 + " is greater than " + num1 + " and " + num3);
            }
            else if(num1 > num2 && num3 < num1)
            {
                Console.WriteLine(num1 + " is greater than " + num2 + " and " + num3);
            }
            else if(num3 > num1 && num3 > num2)
            {
                Console.WriteLine(num3 + " is greater than " + num2 + " and " + num1);
            }
            else
            {
                if(num1 == num2 && num1 == num3)
                {
                    Console.WriteLine("All numbers are equal.");
                }
                Console.WriteLine("Invalid numbers");
            }

            Console.Write("Enter a digit (0-9): ");
            int number1 = int.Parse(Console.ReadLine());
            switch(number1)
            {
                case 0:
                    Console.WriteLine("You entered digit zero."); break;
                case 1:
                    Console.WriteLine("You entered digit one."); break;
                case 2:
                    Console.WriteLine("You entered digit two."); break;
                case 3:
                    Console.WriteLine("You entered digit three."); break;
                case 4:
                    Console.WriteLine("You entered digit four."); break;
                case 5:
                    Console.WriteLine("You entered digit five."); break;
                case 6:
                    Console.WriteLine("You entered digit six."); break;
                case 7:
                    Console.WriteLine("You entered digit seven."); break;
                case 8:
                    Console.WriteLine("You entered digit eight."); break;
                case 9:
                    Console.WriteLine("You entered digit nine."); break;
                default:
                    Console.WriteLine("Invalid"); break;
            }

            Console.Write("Enter a: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = int.Parse(Console.ReadLine());
            double solution = (-b + Math.Sqrt(Math.Pow(b, 2)) - 4 * a * c) / 2 * a;
            double solution2 = (-b - Math.Sqrt(Math.Pow(b, 2)) - 4 * a * c) / 2 * a;
            Console.WriteLine("x is " + solution + " or " + solution2);*/

            //Chapter 6

            /*  // Initialize the counter
              int counter = 0;
              // Execute the loop body while the loop condition holds
              while (counter <= 9)
              {
                  // Print the counter value
                  Console.WriteLine("Number : " + counter);
                  // Increment the counter
                  counter++;
              }

              Console.Write("n = ");
              int m = int.Parse(Console.ReadLine());
              int num = 1;
              int sum = 1;
              Console.Write("The sum 1");
              while (num < m)
              {
                  num++;
                  sum += num;
                  Console.Write(" + " + num);
              }
              Console.WriteLine(" = " + sum);

                  Console.Write("n = ");
                  int n = int.Parse(Console.ReadLine());
                  BigInteger factorial = 1;
                  do
                  {
                      factorial *= n;
                      n--;
                  } while (n > 0);
                  Console.WriteLine("n! = " + factorial);

              Console.Write("n = ");
              int l = int.Parse(Console.ReadLine());
              Console.Write("m = ");
              int m1 = int.Parse(Console.ReadLine());
              int num1 = l;
              long product = 1;
              do
              {
                  product *= num1;
                  num1++;
              } while (num1 <= m1);
              Console.WriteLine("product[n...m] = " + product);

              for (int i = 0; i <= 10; i++)
              {
                  Console.Write(i + " ");
              }

              for (int i = 1, sum2 = 1; i <= 128; i = i * 2, sum2 += i)
              {
                  Console.WriteLine("i={0}, sum={1}", i, sum2);
              }

              Console.Write("n = ");
              int n2 = int.Parse(Console.ReadLine());
              Console.Write("m = ");
              int m2 = int.Parse(Console.ReadLine());
              decimal result = 1;
              for (int i = 0; i < m2; i++)
              {
                  result *= n2;
              }
              Console.WriteLine("n^m = " + result);

              for (int small = 1, large = 10; small < large; small++, large--)
              {
                  Console.WriteLine(small + " " + large);
              }

              Console.Write("Enter n: ");
              int n3 = int.Parse(Console.ReadLine());
              int sum3 = 0;
              for (int i = 1; i <= n; i += 2)
              {
                  if (i % 7 == 0)
                  {
                      continue;
                  }
                  sum3 += i;
              }

              Console.WriteLine("sum = " + sum);
              int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
              foreach (int i in numbers)
              {
                  Console.Write(" " + i);
              }
              Console.WriteLine();
              string[] towns = { "London", "Paris", "Milan", "New York" };
              foreach (string town in towns)
              {
                  Console.Write(" " + town);
              }

              int n4 = int.Parse(Console.ReadLine());
              for (int row = 1; row <= n4; row++)
              {
                  for (int col = 1; col <= row; col++)
                  {
                      Console.Write(col + " ");
                  }
                  Console.WriteLine();
              }

              Console.Write("n = ");
              int n5 = int.Parse(Console.ReadLine());
              Console.Write("m = ");
              int m5 = int.Parse(Console.ReadLine());
              for (int num5 = n5; num5 <= m5; num5++)
              {
                  bool prime = true;
                  int divider = 2;
                  int maxDivider = (int)Math.Sqrt(num5);
                  while (divider <= maxDivider)
                  {
                      if (num5 % divider == 0)
                      {
                          prime = false;
                          break;
                      }
                      divider++;
                  }
                  if (prime)
                  {
                      Console.Write(" " + num5);
                  }

                  for (int a = 1; a <= 9; a++)
                  {
                      for (int b = 0; b <= 9; b++)
                      {
                          for (int c = 0; c <= 9; c++)
                          {
                              for (int d = 0; d <= 9; d++)
                              {
                                  if ((a + b) == (c + d))
                                  {
                                      Console.WriteLine(
                                      " " + a + " " + b + " " + c + " " + d);
                                  }
                              }
                          }
                      }
                  }

                  for (int i1 = 1; i1 <= 44; i1++)
                  {
                      for (int i2 = i1 + 1; i2 <= 45; i2++)
                      {
                          for (int i3 = i2 + 1; i3 <= 46; i3++)
                          {
                              for (int i4 = i3 + 1; i4 <= 47; i4++)
                              {
                                  for (int i5 = i4 + 1; i5 <= 48; i5++)
                                  {
                                      for (int i6 = i5 + 1; i6 <= 49; i6++)
                                      {
                                          Console.WriteLine(i1 + " " + i2 + " " +
                                          i3 + " " + i4 + " " + i5 + " " + i6);
                                      }
                                  }
                              }
                          }
                      }
                  }
              }*/

            /*  Console.Write("Enter n: ");
              int N = int.Parse(Console.ReadLine());
              int start = 1;

              while(start < N)
              {
                  Console.Write(start + " ");
                  start++;
              }

              Console.Write("Enter n: ");
              int N1 = int.Parse(Console.ReadLine());

              for(int i = 1; i < N1; i++)
              {
                  if (i % 3 != 0 && i % 7 != 0)
                  {
                      Console.Write(i + " ");
                  }
              }

              {
                  int firstN = 0, secondN = 1, thirdN = 0;

                  Console.Write("Enter N: ");
                  int length = Int32.Parse(Console.ReadLine());

                  Console.Write("0, 1,");

                  for (int i = 2; i < length; i++)
                  {
                      thirdN = firstN + secondN;
                      Console.Write(" {0},", thirdN);
                      firstN = secondN;
                      secondN = thirdN;
                  }
              }

              Console.Write("Enter a: ");
              int a = int.Parse(Console.ReadLine());
              Console.Write("Enter b: ");
              int b = int.Parse(Console.ReadLine());
              BigInteger factorialA = 1;
              BigInteger factorialB = 1;
              do
              {
                  factorialA *= a;
                  a--;
                  factorialB *= b;
                  b--;
              }
              while (a > 0 && b > 0 && 1 < b && b < a);
              {
                  if (1 < b && a < b)
                  {
                      Console.WriteLine("a must be greater than b");
                  }
                  else
                  {
                      Console.WriteLine("a!/b! = " + factorialA / factorialB);
                  }

              }

              Console.Write("Enter x: ");
              int x = int.Parse(Console.ReadLine());
              Console.Write("Enter y: ");
              int y = int.Parse(Console.ReadLine());
              int factorialX = 1;
              int factorialY = 1;
              int differenceFactorial = 1;
              int difference = (x - y); 
              do
              {
                  factorialX *= x;
                  x--;
                  factorialY *= y;
                  y--;
                  differenceFactorial *= difference;
                  difference--;
              }
              while (a > 0 && b > 0 && 1 < b && b < a);
              {
                      BigInteger fraction = (factorialX * factorialY) / difference;
                      Console.WriteLine("x!*k!/(x-k)! = " + fraction);
              }

              Console.Write("Enter f: ");
              int n = int.Parse(Console.ReadLine());
              for (int row = 1; row <= n; row++)
              {
                  for (int col = 1; col <= row; col++)
                  {
                      Console.Write(col + " ");
                  }
                  Console.WriteLine();
              }

              Console.Write("Enter g < 20: ");
              int g = int.Parse(Console.ReadLine());
              for(int row =1; row <= g; row++)
              {
                  for(int col = 1; col<= g; col++)
                  {
                      Console.Write(col + " ");
                  }
                  Console.WriteLine();
              }
              Console.WriteLine(100 % 10);*/

            //Chapter 7

            /*int[] array = { 1, 2, 3, 4, 5 };
            // Get array size
            int length = array.Length;
            // Declare and create the reversed array
            int[] reversed = new int[length];
            // Initialize the reversed array
            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }
            // Print the reversed array
            for (int index = 0; index < length; index++)
            {
                Console.Write(reversed[index] + " ");
            }

            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter a positive integer: ");
            int n2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[n2];
            Console.WriteLine("Enter the values of the array:");
            for (int i = 0; i < n2; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            bool symmetric = true;
            for (int i = 0; i < array2.Length / 2; i++)
            {
                if (array2[i] != array[n2 - i - 1])
                {
                    symmetric = false;
                    break;
                }
            }

            string[] array3 = { "one", "two", "three", "four" };
            for (int index = 0; index < array2.Length; index++)
            {
                // Print each element on a separate line
                Console.WriteLine("Element[{0}] = {1}", index, array2[index]);
            }
            Console.WriteLine("Is symmetric? {0}", symmetric);

            int[,] matrix =
                        {
                            {1, 2, 3, 4}, // row 0 values
                            {5, 6, 7, 8}, // row 1 values
                        };
            // The matrix size is 2 x 4 (2 rows, 4 cols)
            matrix.GetLength(1);

            // Declare and initialize a matrix1 of size 2 x 4
            int[,] matrix1 =
            {
                {1, 2, 3, 4}, // row 0 values
                {5, 6, 7, 8}, // row 1 value
            };
            // Print the matrix1 on the console
            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int col = 0; col < matrix1.GetLength(1); col++)
                {
                    Console.Write(matrix1[row, col]);
                }
                Console.WriteLine();
            }

            Console.Write("Enter the number of the rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of the columns: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix4 = new int[rows, cols];
            Console.WriteLine("Enter the cells of the matrix:");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix4[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < matrix4.GetLength(0); row++)
            {
                for (int col = 0; col < matrix4.GetLength(1); col++)
                {
                    Console.Write(" " + matrix4[row, col]);
                }
                Console.WriteLine();
            }

            // Declare and initialize the matrix
            int[,] matrix = {
                                { 0, 2, 4, 0, 9, 5 },
                                { 7, 1, 3, 3, 2, 1 },
                                { 1, 3, 9, 8, 5, 6 },
                                { 4, 6, 7, 9, 1, 0 }
                            };
            // Find the maximal sum platform of size 2 x 2
            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    long sum = matrix[row, col] + matrix[row, col + 1] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }

                    // Print the result
                    Console.WriteLine("The best platform is:");
                    Console.WriteLine(" {0} {1}",
                    matrix[bestRow, bestCol],
                    matrix[bestRow, bestCol + 1]);
                    Console.WriteLine(" {0} {1}",
                    matrix[bestRow + 1, bestCol],
                    matrix[bestRow + 1, bestCol + 1]);
                    Console.WriteLine("The maximal sum is: {0}", bestSum);
              

            int[][] myJaggedArray = {
                                            new int[] {5, 7, 2},
                                            new int[] {10, 20, 40},
                                            new int[] {3, 25}
                                        };
            Console.WriteLine(myJaggedArray[0][2]);

            const int HEIGHT = 12;
            // Allocate the array in a triangle form
            long[][] triangle = new long[HEIGHT + 1][];
            for (int row = 0; row < HEIGHT; row++)
            {
                triangle[row] = new long[row + 1];
            }
            // Calculate the Pascal's triangle
            triangle[0][0] = 1;
            for (int row = 0; row < HEIGHT - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }
            // Print the Pascal's triangle
            for (int row = 0; row < HEIGHT; row++)
            {
                Console.Write("".PadLeft((HEIGHT - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter the number of elements for the first array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];

            Console.WriteLine("Enter the elements of array1");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Array1[{0}] = ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(" " + array1[i]);
            }
            Console.WriteLine("Enter the number of elements of the second array: ");
            int m = int.Parse(Console.ReadLine());
            int[] array2 = new int[m];

            Console.WriteLine("Enter the elements of array2");

            for (int i = 0; i < m; i++)
            {
                Console.Write("Array2[{0}] = ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array2.Length; i++)
            {
                 Console.Write(" " + array2[i]);
            }

            if (array1.Length == array2.Length )
            {
                Console.WriteLine("array1 is equal to array2");              
            }
            else
            {
                Console.WriteLine("array1 and array2 are not equal.");
            }

            int count = 1, tempCount = 1, number = 0;

            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i])
            }

            int count = 1, tempCount = 1, number = 0;
            Console.Write("Enter: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
               
            for(int i = 0; i < array.Length - 1; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                    tempCount++;
                else
                {
                    tempCount = 1;
                }
                if(tempCount > count)
                {
                    count = tempCount;
                    number = array[i];
                }
            }
            for(int i = 0; i < count; i++)
            {
                Console.Write("{0}, ", number);
            }*/


            //Chapter 8

            /* int integerValue = 25;
             int integerHexValue = 0x002A;
             int y = Convert.ToInt32("1001", 2); // Converts binary to int

             float sum = 0f;
             for (int i = 0; i < 1000; i++)
             {
                 sum += 0.1f;
             }
             Console.WriteLine("Sum = {0}", sum);
             // Sum = 99.99905float sum = 0.0f;
             for (int i = 1; i <= 10; i++)
             {
                 sum += 0.1f;
             }
             Console.WriteLine("{0:r}", sum);

             Console.WriteLine("150 to binary {0}.", Convert.ToString(150, 2));
             Console.WriteLine("35 to binary {0}.", Convert.ToString(35, 2));
             Console.WriteLine("43 to binary {0}.", Convert.ToString(43, 2));
             Console.WriteLine("251 to binary {0}.", Convert.ToString(251, 2));sbyte*/

            // Chapter 9

            /* static void ModifyArray(int[] arrParam)
             {
                 arrParam[0] = 5;
                 Console.Write("In ModifyArray() the param is: ");
                 PrintArray(arrParam);
             }
             static void PrintArray(int[] arrParam)
             {
                 Console.Write("[");
                 int length = arrParam.Length;
                 if (length > 0)
                 {
                     Console.Write(arrParam[0].ToString());
                     for (int i = 1; i < length; i++)
                     {
                         Console.Write(", {0}", arrParam[i]);
                     }
                 }
                 Console.WriteLine("]");
             }

             int[] arrArg = new int[] { 1, 2, 3 };
             Console.Write("Before ModifyArray() the argument is: ");
             PrintArray(arrArg);
             // Modifying the array's argument
             ModifyArray(arrArg);
             Console.Write("After ModifyArray() the argument is: ");
             PrintArray(arrArg);

            // Entering the value of the variable n
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            // Printing the upper part of the triangle
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }
            // Printing the bottom part of the triangle
            // that is under the longest line
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

            //Chapter 09
            Console.Write("Enter your name: ");
            string name = (Console.ReadLine());

            Console.WriteLine($"\"Hello, {name}\"!");

            //2
            Console.Write("Enter the first digit: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second digit: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the third digit: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            GetMax(firstNumber, secondNumber, thirdNumber);

            //4
            Console.Write("Enter the length of your array: ");
            int length = int.Parse(Console.ReadLine());
            int[] numberList = new int[length];
            Console.WriteLine("Enter the values of the array:");
            for (int i = 0; i < length; i++)
            {
                numberList[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the number you want to count: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"There are {NumberCount(numberList, num)} {num}s in the array");

            //5
            Console.Write("Enter the length of your array: ");
            int length1 = int.Parse(Console.ReadLine());
            int[] array = new int[length1];
            Console.WriteLine("Enter the values of the array:");
            for (int i = 0; i < length1; i++)
            {
                numberList[i] = int.Parse(Console.ReadLine());
            }
            GreaterThanLeftDigit(array,1);

            //10
            Console.Write("Enter number: ");
            int factorailNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(factorailNumber));

            //01Chapter10
            {
                Console.Write("Enter N: ");
                int n = Int32.Parse(Console.ReadLine());
                int[] arr = new int[n];
                Loops(arr, 0);
            }*/

            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);


            //2Method
            /*  static void GetMax(int firstNumber, int secondNumber, int thirdNumber)
              {
                  if (firstNumber > secondNumber && firstNumber > thirdNumber)
                  {

                      // return firstNumber;
                      Console.WriteLine($"The biggest number is: {firstNumber}");

                  }

                  else if (secondNumber > firstNumber && secondNumber > thirdNumber)
                  {
                      Console.WriteLine($"The biggest number is: {secondNumber}");

                  }
                  else
                  {
                      Console.WriteLine($"The biggest number is: {thirdNumber}");
                  }
              }

              //4Method

              static int NumberCount(int[] numberList, int num2)
              {
                  int numberCount = 0;
                  foreach (int digit in numberList)
                  {
                      if (num2 == digit)
                          numberCount++;
                  }
                  return numberCount;
              }

              //5Method
              static void GreaterThanLeftDigit(int[] array, int number1)
              {
                  for(int i = 0; i < array.Length + 1; i++)
                  {
                      if (number1 > array[i - 1])
                          Console.WriteLine($"{array[i]} is greater than its neighbours!");
                      else
                      {
                          Console.WriteLine($"{array[i]} is not greater than its neigbours");
                      }
                  }   
              }

              //10Method
              static  int Factorial(int number)
              {
                  int num1 = 1;
                  for(int num = 1; num < number; num++)
                  {
                      number = num1 * num;
                  }
                  return number;
              }

              //01MethodChapter10
              static void Loops(int[] arr, int index)
              {
                  if (index >= arr.Length)
                  {
                      foreach (int element in arr) Console.Write("{0} ", element);
                      Console.WriteLine();
                  }
                  else
                      for (int i = 1; i <= arr.Length; i++)
                      {
                          arr[index] = i;
                          Loops(arr, index + 1);
                      }
              }

            //Chapter11
            Random rnd = new Random();
            int randomNumbers = rnd.Next(100, 200);
            string tenNumbers = randomNumbers.ToString();
            for (int digit = 0; digit < tenNumbers.Length; digit++)
            {
                if(tenNumbers.Length < 11)
                {
                    Console.WriteLine(tenNumbers);
                }
            }*/
            //5
            Console.Write("Enter the first side: ");
            double firstSide = double.Parse(Console.ReadLine());
            Console.Write("Enter the second side: ");
            double secondSide = double.Parse(Console.ReadLine());

            double hypot = Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2);
            Console.WriteLine(hypot);

            //7
            {
                
                    String name = "Cat";
                    for (int i = 0; i < 10; i++)
                    {
                        Cat cat = new Cat(name + Sequence.NextValue(), "Black");
                        cat.sayMiau();
                    }
                    Console.ReadLine();
                
            }
        }
    }
}

       
    
    






