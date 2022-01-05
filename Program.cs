using System;
using System.Collections.Generic;

namespace ForTest
{
    internal class Program
    {
        enum direction { north = 1, south = 2, west = 3, east = 4};
        enum Nummer { Ett = 1, Tva = 2, Tre = 3, Fyra = 4, Fem = 5 };
        static void Main(string[] args)
        {
            // 2
            //const int m = 100;
            //int n = 10;
            //Console.WriteLine(m*n);
            //Console.ReadLine();


            // 4
            //double a = 12.502;
            //float b = 12.80f;
            //float c;
            //c = (float)a + b;
            //Console.WriteLine(c);
            //Console.ReadLine();



            // 5
            //var dayCode = "MTWFS";
            //var daysArray = new List<string>();
            //var list = new Dictionary<string, string>
            //{
            //    { "M", "Monday" },
            //    { "T", "Tuesday" },
            //    { "W", "Wednesday" },
            //    { "R", "Thursday" },
            //    { "F", "Friday" },
            //    { "S", "Saturday" },
            //    { "U", "Sunday" }
            //};

            //for (int i = 0,max = dayCode.Length; i < max; i++)
            //{
            //    var tmp = dayCode[i].ToString();
            //    if (list.ContainsKey(tmp))
            //    {
            //        daysArray.Add(list[tmp]);
            //    }
            //}
            //Console.WriteLine(String.Join("\n", daysArray));


            //6
            //int a, b;
            //a = (b = 10) + 5;
            //Console.WriteLine($"a = {a}, b = {b}");
            //Console.ReadLine();


            //7
            //int i;
            //int b = 8, a = 32;
            //for (i = 0; i <= 10; i++)
            //{
            //    if ((a / b * 2) == 2)
            //    {
            //        Console.WriteLine(i + " ");
            //        continue;
            //    }
            //    else if (i != 4)
            //        Console.WriteLine(i + " ");
            //    else
            //        break;
            //}
            //Console.ReadLine();


            //9
            //int t = 112;
            //switch (t - 1)
            //{
            //    case 112:
            //        Console.WriteLine("coco" + "\t");
            //        break;
            //    default:
            //        Console.WriteLine("default");
            //        break;
            //}
            //Console.WriteLine("main");


            //10
            //int = 112;
            //switch (t)
            //{
            //    case 112:
            //        Console.WriteLine("hello" + "\t" + t);
            //        break;
            //    default:
            //        Console.WriteLine("default");
            //        break;
            //}
            //Console.WriteLine("done");


            //11
            //float f;
            //for (f= 0.1f; f <= 0.5; f+= 2)
            //{
            //    Console.WriteLine(++f);
            //}
            //Console.ReadLine();


            //13
            //int[] a = { 11, 3, 5, 9, 6 };
            //foreach (int i in a)
            //    Console.WriteLine(i);


            //14 - Rätt = 'a' är en 2-D ARRAY of 3 columns and 2 rows
            //int[,] a = { { 5, 4, 3 }, { 9, 2, 6 } };
            //a[0,0] //Skriver ut 5
            //a[1,0] //Skriver ut 9
            //15
            //int[] a = { 11, 3, 5, 9, 6 };
            //Console.WriteLine(a[0]);


            //25
            //A25 obj = new A25();
            //obj.math();


            //26 - !!! obj.display is inaccessible due to its protection level !!!
            //A26 obj = new A26();
            //obj.i = 1;
            //obj.i = 2;
            //obj.display();
            //Console.ReadLine();


            //32
            //A32 m = new A32(6);
            //A32 k = new A32(6, 2);
            //Console.WriteLine(k.length);
            //Console.WriteLine(m.length);
            //Console.ReadLine();


            //43
            //Console.Write("c ");
            //Console.Write("sharp");
            //Console.ReadLine();

            //44
            //Console.Write("c");
            //Console.Write(" sharp");
            //Console.ReadLine();

            //45
            //Console.Write("c");
            //Console.Write("sharp");
            //Console.ReadLine();

            //48
            //String a = "i love iostream";
            //Console.WriteLine(a.IndexOf('i') + " " + a.IndexOf('e') + " " + a.LastIndexOf('i') + " " + a.LastIndexOf('e'));
            //Console.ReadLine(); // i = 0                  e = 5                 i = 7                       e = 12


            //49
            //int i,j;
            //int[,] arr = new int[3, 3];
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 3; j++)
            //    {
            //        arr [i,j] = i * 2 + i * 2;
            //        Console.WriteLine(arr [i,j]+ ",");
            //    }
            //}


            //50 -  'a' represents a 2-D array of 3 columns (siffrorna) and 2 rows (måsvingarna)
            //int[,] a = { { 5, 4, 3, }, { 9, 2, 6 } };


            //51 - Initializing an array of 3 integers.
            //int[] a;
            //a = new int[3] { 78, 9, 54 };


            //52
            //string s1 = " Cshr ";
            //string s2 = s1.Insert(3, "a");
            //string s3 = s2.Insert(5, "p");
            //for (int i = 0; i < s3.Length; i++)
            //{
            //    Console.Write(s3);
            //}
            //Console.ReadLine();


            //53
            //string s1 = "One";
            //string s2 = "Two";
            //if (s1 == s2)
            //{
            //    Console.WriteLine("It's True");
            //}
            //if (s1.Equals(s2))
            //{
            //    Console.WriteLine("It's True");
            //}
            //else
            //{
            //    Console.WriteLine("It's False");
            //}
            //Console.ReadLine();


            //66
            //double tal = 3 / 4; // numbers are of int datatype.
            //double talD = 3.0 / 4; // numbers need to be specified as double with the 'd' or '3.0'
            //Console.WriteLine(tal);
            //Console.WriteLine(talD);
            //Console.ReadLine();


            //69 och 72
            //int a = 1; //Local variable in Main
            //Console.WriteLine(a);
            //Hej();
            //static void Hej()
            //{
            //    int b = 2;  // Local variable in Hej method
            //    Console.WriteLine(b);
            //}
            //A69 obj = new();
            //obj.A69func();
            //Console.ReadLine();

            //73
            //decimal number = 0.15m; //m suffix needed for double to be of decimaltype.
            //Console.WriteLine(number);
            //Console.ReadLine();


            //74
            //double a = Math.Sqrt(2);
            //Console.WriteLine(a);
            //Console.ReadLine();

            //75
            //double a = Math.Sqr(2.0);
            //Console.WriteLine(a);
            //Console.ReadLine();


            //77
            //Console.Write("{1:D1} and {0:F1}", Math.PI, 7);
            //Console.ReadLine();


            //80
            //int size = 3;
            //bool testett = size < 5;
            //bool testtva = size == 7;
            //bool testtre = size => 2;     // !!!Cannot convert error!!!
            //bool testfyra = size = 3;     // !!!Cannot convert error!!!


            //81
            //if (false) // !!!Unreachable code error!!!
            //{
            //    Console.WriteLine("Hi false!");
            //}
            //if (2 < 3)
            //{
            //    Console.WriteLine("Hi 2 less than 3!");
            //}
            //if true // !!!Saknar ( ) runt true!!!
            //{
            //    Console.WriteLine("Hi true!");
            //}


            //82
            //int number = 4;
            //if ((number == 4) || (2 < 1))
            //{
            //    Console.WriteLine("Ett");
            //}
            //if ((number == 4) && (2 < 1))
            //{
            //    Console.WriteLine("Två");
            //}
            //if ((number == 3) && (1 < 2))
            //{
            //    Console.WriteLine("Tre");
            //}
            //if ((number == 3) || (1 < 2))
            //{
            //    Console.WriteLine("Fyra");
            //}
            //else
            //{
            //    Console.WriteLine("None!");
            //}
            //Console.ReadLine();


            //84
            //for (int number = 1; number <3; number++)
            //{
            //    Console.Write(number + ",");
            //}
            //Console.ReadLine();


            //88
            //int sum88 = 0;
            //for ( ; ; )
            //{
            //    if (sum88 < 10)
            //    {
            //        sum88 = sum88 + 1;
            //        Console.WriteLine(sum88);
            //    }
            //    else
            //        break;
            //}

            //int sum88 = 0;
            //for (; ;) //infinite loop
            //{
            //    sum88 = sum88 + 1;
            //    Console.WriteLine(sum88);
            //}


            //89
            //int sum = 0;
            //do
            //{
            //    sum = sum + 1;  // 2, 4, 6, 8, 10, 12, 14
            //    Console.WriteLine(sum);
            //}
            //while (sum <= 12);
            //Console.WriteLine();
            //Console.WriteLine(sum);
            //Console.ReadLine();

            //89 - exempel av do-while från progsharp
            //int i = 4;
            //do
            //{
            //    Console.WriteLine($"i={i}");
            //    i++;
            //} while (i > 4 && i < 10);


            //90
            //for (int i = 0; i < 4; i++)
            //{ 
            //    for (int j = 0; j < 6; j++)
            //    {
            //        Console.WriteLine("Hi!");
            //    }
            //}
            //Console.ReadLine();


            //EnumTest          
            //Nummer num1 = Nummer.Ett;
            //Nummer num2 = Nummer.Tva;
            //Nummer num3 = Nummer.Tre;
            //int num1num = (int)num1;
            //int num2num = (int)num2;
            //int num3num = (int)num3;
            //Console.WriteLine($"{num1num} {num2num} {num3num}");
            //Console.WriteLine($"{num1} {num2} {num3}");
            //Console.WriteLine($"{Nummer.Ett} {(int)Nummer.Ett}");
            //Console.ReadLine();

        } /* MAIN END */

        /* CLASSES FOR QUESTIONS */

        //class A25 //25
        //{
        //    int a = 10;
        //    public void math()
        //    {
        //        Console.WriteLine(a.ToString() + " " + (a * 10).ToString());
        //        Console.ReadLine();
        //    }
        //}

        //class A26  //26 - !!! Fel i frågan då display inte är public kan den inte nås utifrån !!!
        //{ 
        //    public int i;
        //    public void display()
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //class A32   //32
        //{
        //    public int length;
        //public A32(int x)
        //{
        //    length = x + 1;
        //}
        //public A32(int x, int y)
        //{
        //    length = x + 2;
        //}
        //}


        //class A69 //69
        //{
        //    public int c = 3;  // Not local, Field for class.
        //    public void A69func()
        //    {
        //        int d = 4;  // Local variable for method A69func

        //        Console.WriteLine(c.ToString());
        //        Console.WriteLine(d);
        //    }
        //}


    } /* CLASS END */
} /* NAMESPACE END */
