using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWarmUps
{
    public class ArrayExercises
    {
        //1.FirstLast6
        public bool FirstLast6(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[0] == 6 || numbers[numbers.Length - 1] == 6)
                {
                    return true;
                }
            }
            return false;
        }
        //2.SameFirstLast
        public bool SameFirstLast(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers.Length > 1 && numbers[0] == numbers[numbers.Length - 1])
                {
                    return true;
                }
            }
            return false;
        }

        //3.MakePi
        public int[] MakePi(int n)
        {
            string s1 = Math.Truncate(Math.PI * Math.Pow(10, n - 1)).ToString();
            int[] result = new int[s1.Length];
            for (int i = 0; i < s1.Length; i++)
            {
                result[i] = int.Parse(s1.Substring(i, 1));
            }
            return result;
        }

        //4.CommonEnd
        public bool CommonEnd(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < b.Length - 1; j++)
                {
                    if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //5.Sum
        public int Sum(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }

        //6.RotateLeft
        public int[] RotateLeft(int[] numbers)
        {
            int temp = numbers[0];//hold first element
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = temp;//replace last element with the first element value

            return numbers;
        }

        //7.Reverse
        public int[] Reverse(int[] numbers)
        {
            int[] array = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                array[i] = numbers[numbers.Length - 1 - i];
            }
            return array;
        }

        //8.HigherWins
        public int[] HigherWins(int[] numbers)
        {
            int[] a = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[0] > numbers[numbers.Length - 1])
                {
                    a[i] = numbers[0];
                }
                else if (numbers[numbers.Length - 1] > numbers[0])
                {
                    a[i] = numbers[numbers.Length - 1];
                }
            }
            return a;
        }

        //9.GetMiddle
        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] c = new int[2];
            for (int i = 0; i < a.Length - 1; i++)
            {
                c[0] = a[1];
                for (int j = 0; j < b.Length - 1; j++)
                {
                    c[1] = b[1];
                }
            }
            return c;
        }

        //10. HasEven
        public bool HasEven(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
        //11.KeepLast
        public int[] KeepLast(int[] numbers)
        {
            int[] a = new int[numbers.Length * 2];

            a[a.Length - 1] += numbers[numbers.Length - 1];

            return a;
        }

        //12.Double23
        public bool Double23(int[] numbers)
        {
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers[i] == 2)
                {
                    count1++;
                }
                if (numbers[i] == 3)
                {
                    count2++;
                }
            }
            if (count1 == 2 || count2 == 2)
            {
                return true;
            }
            return false;

        }
        //13 Fix23
        public int[] Fix23(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2 && numbers[i + 1] == 3)
                {
                    numbers[i + 1] = 0;
                }
            }
            return numbers;
        }

        //14. Unlucky1
        public bool Unlucky1(int[] numbers)
        {
            if ((numbers[0] == 1 && numbers[1] == 3) || (numbers[1] == 1 && numbers[2] == 3)
                || (numbers[numbers.Length - 2] == 1 && numbers[numbers.Length - 1] == 3))
            {
                return true;
            }
            return false;
        }

        //15. Make2
        public int[] Make2(int[] a, int[] b)
        {
            int[] c = new int[2];
            if (a.Length == 0)
            {
                c[0] = b[0];
                c[1] = b[1];
            }
            else if (a.Length > 1)
            {
                c[0] = a[0];
                c[1] = a[1];
            }
            else if (a.Length == 1)
            {
                c[0] = a[0];
                c[1] = b[0];
            }

            return c;
        }

    






}//end class
}//end namespace
