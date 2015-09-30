using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWarmUps
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayExercises exercises = new ArrayExercises();


            //FirstLast6
            Console.WriteLine(":::::::FIrstLast6::::::::::");
            int[] a = new int[] { 1, 2, 6 };
            Console.WriteLine(exercises.FirstLast6(a));//-> true
            int[] a1 = new int[] { 6, 1, 2, 3 };
            Console.WriteLine(exercises.FirstLast6(a1));// -> true
            int[] a2 = new[] { 13, 6, 1, 2, 3 };
            Console.WriteLine(exercises.FirstLast6(a2));// -> false

            //SameFirstLast
            Console.WriteLine("::::SAMEFIRSTLAST:::::::::");
            int[] b = new[] { 1, 2, 3 };
            Console.WriteLine(exercises.SameFirstLast(b));// -> false
            int[] b1 = new[] { 1, 2, 3, 1 };
            Console.WriteLine(exercises.SameFirstLast(b1));// -> true
            int[] b2 = new[] { 1, 2, 1 };
            Console.WriteLine(exercises.SameFirstLast(b2));// -> true

            //MakePi
            //Console.WriteLine(exercises.MakePi(3));//-> { 3, 1, 4}

            //CommonEnd
            Console.WriteLine(":::::::::COMMONEND::::::::::::::");
            int[] c = new[] { 1, 2, 3 };
            int[] c1 = new[] { 7, 3 };
            Console.WriteLine(exercises.CommonEnd(c, c1));// -> true
            int[] d = new[] { 1, 2, 3 };
            int[] d1 = new[] { 7, 3, 2 };
            Console.WriteLine(exercises.CommonEnd(d, d1));// -> false
            int[] e = new[] { 1, 2, 3 };
            int[] e1 = new[] { 1, 3 };
            Console.WriteLine(exercises.CommonEnd(e, e1));// -> true

            //Sum
            Console.WriteLine("::::::SUM:::::::::::::");
            int[] f = new[] { 1, 2, 3 };
            Console.WriteLine(exercises.Sum(f));// -> 6
            int[] f1 = new[] { 5, 11, 2 };
            Console.WriteLine(exercises.Sum(f1));// -> 18
            int[] f2 = new[] { 7, 0, 0 };
            Console.WriteLine(exercises.Sum(f2));// -> 7

            //RotateLeft
            Console.WriteLine("::::::::::ROTATELEFT::::::::::::");
            int[] g = new[] { 1, 2, 3 };
            int[] rotateLeft = exercises.RotateLeft(g);
            foreach (var i in rotateLeft)
            {
                Console.Write(i);// -> {2, 3, 1}
            }
            Console.WriteLine();
            int[] g1 = new[] { 5, 11, 9 };
            int[] g2 = exercises.RotateLeft(g1);
            foreach (var i in g2)
            {
                Console.Write(i);// -> {11, 9, 5}
            }
            Console.WriteLine();

            int[] g3 = new[] { 7, 0, 0 };
            int [] g4 = exercises.RotateLeft(g3);
            foreach (var i in g4)
            {
                Console.Write(i); // -> {0, 0, 7}
            }
            Console.WriteLine();



            //Reverse
            //int[] h = new[] { 1, 2, 3 };
            //Console.WriteLine("::::::::::::::ReVERSE::::::::::");
            //Console.WriteLine(exercises.Reverse(h));//
            //so for example {h} becomes {3, 2, 1}. 
            //HigherWins
            //Console.WriteLine(":::::::::::::::HIGHERWINS:::::::::::::");
            //int[] i = {1, 2, 3};
            //Console.WriteLine(exercises.HigherWins(i));// -> {3, 3, 3}
            //int[] i2 = {11, 5, 9};
            //Console.WriteLine(exercises.HigherWins(i2));// -> {11, 11, 11}
            //int[] i3 = {2, 11, 3};
            //Console.WriteLine(exercises.HigherWins(i3));// -> {3, 3, 3}

            //11.HasEven
            //HasEven({ 2, 5}) -> true
            //HasEven({ 4, 3}) -> true
            //HasEven({ 7, 5}) -> false
            Console.WriteLine(":::::::::::::::::HASEVEN::::::::::::::::");




            Console.ReadLine();

        }
    }
}
