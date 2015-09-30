using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{
    public class StringExercises
    {
        //SayHi
        public string SayHi(string name)
        {
            return ("Hello " + name + '!');
        }

        //Abba
        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        //MakeTags
        public string MakeTags(string tag, string content)
        {
            return "<" + tag + ">" + content + "</" + tag + ">";
        }

        //InsertWord
        public string InsertWord(string container, string word)
        {
            string c1 = container.Substring(0, 2);
            string c2 = container.Substring(2, 2);
            return c1 + word + c2;
        }

        //mutipleEndings
        public string MultipleEndings(string str)
        {
            string lastTwo = str.Substring(str.Length - 2);
            return lastTwo + lastTwo + lastTwo;
        }

        //FirstHalf 
        public string FirstHalf(string str)
        {
            string fHalf = str.Substring(0, str.Length / 2);
            return fHalf;
        }

        //TrimOne
        public string TrimOne(string str)
        {
            string str1 = str.Substring(1, str.Length - 2);
            return str1;
        }

        //LongInMiddle
        public string LongInMiddle(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return b + a + b;
            }
            else
            {
                return a + b + a;
            }
        }

        //RotateLeft2
        public string Rotateleft2(string str)
        {
            string first2 = str.Substring(0, 2);
            string last = str.Substring(2, str.Length - 2);
            return last + first2;
        }

        //RotateRight
        public string RotateRight2(string str)
        {
            string last2 = str.Substring(str.Length - 2);
            string first = str.Substring(0, str.Length - 2);
            return last2 + first;
        }

        //TakeOne
        public string TakeOne(string str, bool fromFront)
        {
            if (fromFront == true)
            {
                return str.Substring(0, 1);
            }
            else
            {
                return str.Substring(str.Length - 1);
            }
        }

        //MiddleTwo ("string");//-> "ri"
        public string MiddleTwo(string str)
        {
            int strLength = str.Length;
            int middle = (strLength / 2) - 1;
            string middleString = str.Substring(middle, 2);
            return middleString;
        }
        //13 EndsWithLY
        public bool EndsWithLy(string str)
        {
            if (str.EndsWith("ly"))
            {
                return true;
            }
            return false;

        }
        //14.FrontAndBack
        public string FrontAndBack(string str, int n)
        {
            string str2Front = str.Substring(0, n);
            string str2Back = str.Substring(str.Length - n, n);
            return str2Front + str2Back;

        }
        //15.TakeTwoFromPosition
        public string TakeTwoFromPosition(string str, int n)
        {
            if (n > str.Length - 2)
            {
                string str2a = str.Substring(0, 2);
                return str2a;

            }
            string str2 = str.Substring(n, 2);
            return str2;
        }
        //HasBad
        public bool HasBad(string str)
        {
            if (str.Substring(0, 3) == "bad" || str.Substring(1, 3) == "bad")
            {
                return true;
            }
            return false;
        }
        //AtFirst
        public string AtFirst(string str)
        {
            if (str.Length >= 2)
            {
                string str2 = str.Substring(0, 2);
                return str2;
            }
            string str3 = str.Substring(0) + '@';
            return str3;

        }
        //LastChars
        public string LastChars(string a, string b)
        {
            if (a.Length > 0 && b.Length > 0)
            {
                string str3First = a.Substring(0, 1);
                string str3Last = b.Substring(b.Length - 1, 1);
                string str4 = str3First + str3Last;
                return str4;
            }
            string str5 = a.Substring(0, 1) + '@';
            return str5;
        }
        //ConCat
        public string ConCat(string a, string b)
        {
            if ((a.Length > 0 && b.Length > 0) && (a.Substring(a.Length - 1, 1) == b.Substring(0, 1)))
            {
                string str1 = a.Substring(0, a.Length - 1);
                string newString = str1 + b;
                return newString;
            }
            string str = a + b;
            return str;
        }
        //SwapLast
        public string SwapLast(string str)
        {
            string str1 = str.Substring(str.Length - 1, 1);//gets last letter

            string str2 = str.Substring(str.Length - 2, 1);//gets second to last letter
            string str3 = str.Substring(0, str.Length - 2);// gets str from 0 to end -2
            //str.Insert()
            string str4 = str3 + str1 + str2;
            return str4;
        }
        //FrontAgain
        public bool FrontAgain(string str)
        {
            if (str.Substring(0, 2) == str.Substring(str.Length - 2, 2))
            {
                return true;
            }
            return false;
        }
        //MinCat
        public string MinCat(string a, string b)
        {
            if (a.Length == b.Length)
            {
                return a + b;

            }
            else if (a.Length > b.Length)
            {
                string c = a.Substring((a.Length - 1) - (b.Length - 1)) + b;
                return c;
            }
            else
            {
                return a + b.Substring((b.Length - 1) - (a.Length - 1));
            }
        }
        //TweakFront
        public string TweakFront(string str)
        {
            char first = str[0];
            char second = str[1];

            if (first == 'a' && second != 'b')
            {
                string str3 = str.Remove(1, 1);
                return str3;
            }
            else if (first != 'a' && second == 'b')
            {
                string str4 = str.Remove(0, 1);
                return str4;
            }
            else if (first == 'a' && second == 'b')
            {
                return str;
            }

            string str2 = str.Remove(0, 2);
            return str2;
        }
        //StripX
        public string StripX(string str)
        {
            char first = str[0];
            char last = str[str.Length - 1];
            if (first == 'x' && last == 'x')
            {
                string str2 = str.Substring(1, str.Length - 2);
                // string str3 = str.Substring(1, str.Length - 2);
                return str2;
            }
            else if (first == 'x')
            {
                string str4 = str.Substring(1, str.Length - 1);
                return str4;
            }
            else if (last == 'x')
            {
                string str5 = str.Substring(0, str.Length - 1);
                return str5;
            }
            return str;
        }


        //*********************************************************************
        //*************Start CONDITIONALS*************************************
        //*********************************************************************
        //1.AreWeInTrouble
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if ((aSmile && bSmile) || (!aSmile && !bSmile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //2.CanSleepIn
        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (isWeekday && !isVacation)
            {
                return false;
            }
            else if ((!isWeekday && !isVacation) || (!isWeekday && isVacation))
            {
                return true;
            }
            return true;
        }

        //3.SumDouble
        public int SumDouble(int a, int b)
        {
            if (a == b)
            {
                int doubleSum = (a + b) * 2;
                return doubleSum;
            }
            else
            {
                return a + b;
            }
        }

        //4.Diff21
        public int Diff21(int n)
        {
            if (n > 21)
            {
                return (n - 21) * 2;
            }
            else
            {
                return (n - 21) * -1;
            }
        }

        //5.ParrotTrouble
        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if (isTalking && (hour < 7) || (hour > 20))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //6.Makes10
        public bool Makes10(int a, int b)
        {
            if (a == 10 || b == 10)
            {
                return true;
            }
            else if (a + b == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //7.NearHundred
        public bool NearHundred(int n)
        {
            if ((Math.Abs(n - 100) <= 10))
            {
                return true;
            }
            else if ((Math.Abs(n - 200) <= 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //8.PosNeg
        public bool PosNeg(int a, int b, bool negative)
        {
            if ((a < 0 && b < 0) && negative)
            {
                return true;
            }
            else if ((a < 0 && b > 0) || (a > 0 && b < 0) && !negative)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //9.NotString
        public string NotString(string s)
        {
            if ((s.Length >= 3) && (s.Substring(0, 3) == "not"))
            {
                return s;
            }
            else
            {
                return "not " + s;
            }
        }

        //10. MissingChar
        public string MissingChar(string str, int n)
        {
            string str2 = str.Remove(n, 1);
            return str2;
        }

        //11.FrontBack
        public string FrontBack(string str)
        {
            if (str.Length > 1)
            {
                string last = str.Substring(str.Length - 1, 1);
                string newString = str.Substring(1, str.Length - 2);
                var first = str[0];
                newString = last + newString + first;
                return newString;
            }
            return str;
        }
        //Front3
        public string Front3(string str)
        {
            if (str.Length < 3)
            {
                string str1 = str.Substring(0, str.Length);
                return str1 + str1 + str1;
            }
            string str2 = str.Substring(0, 3);
            return str2 + str2 + str2;
        }
        //BackAround
        public string BackAround(string str)
        {
            char front = str[0];
            if (str.Length > 1)
            {
                string back = str.Substring(str.Length - 1);
                string newString = back + str + back;
                return newString;
            }

            return str + str + str;

        }
        //Mutiple3Or5
        public bool Multiple3Or5(int number)
        {
            if (number % 3 == 0 || number % 5 == 0)
            {
                return true;
            }
            return false;
        }
        //StartHi
        public bool StartHi(string str)
        {
            if (str.Length > 2)
            {
                string str2 = str.Substring(0, 3);
                if (str2 == "hi ")
                {
                    return true;
                }
            }
            else if (str == "hi")
            {
                return true;
            }
            return false;
        }
        //icyHot
        public bool IcyHot(int temp1, int temp2)
        {
            if (temp1 < 0 && temp2 > 100)
            {
                return true;
            }
            else if (temp1 > 100 && temp2 < 0)
            {
                return true;
            }
            return false;
        }
        //Between10And20
        public bool Between10And20(int a, int b)
        {
            if ((a >= 10 && a <= 20) || (b >= 10 && b <= 20))
            {
                return true;
            }
            return false;
        }
        //HasTeen
        public bool HasTeen(int a, int b, int c)
        {
            if ((a >= 13 && a <= 19) || (b >= 13 && b <= 19) || (c >= 13 && c <= 19))
            {
                return true;
            }
            return false;
        }
        //SoAlone
        public bool SoAlone(int a, int b)
        {
            if ((a >= 13 && a <= 19) && !(b >= 13 && b <= 19) || !(a >= 13 && a <= 19) && (b >= 13 && b <= 19))
            {
                return true;
            }
            return false;
        }
        //RemoveDel
        public string RemoveDel(string str)
        {
            string str1 = str.Substring(1, 3);
            if (str1 == "del")
            {
                string str2 = str.Remove(1, 3);
                return str2;
            }
            return str;
        }
        //IxStart
        public bool IxStart(string str)
        {
            string str2 = str.Substring(1, 2);
            if (str2 == "ix")
            {
                return true;
            }
            return false;
        }
        //StartOz
        public string StartOz(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            if (str1 == "o" && str2 == "z")
            {
                string str3 = str1 + str2;
                return str3;
            }
            else if (str1 != "o" && str2 == "z")
            {
                return str2;
            }
            else if (str1 == "o" && str2 != "z")
            {
                return str1;
            }
            return str;
        }
        //Max
        public int Max(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else if (c > a && c > b)
            {
                return c;
            }
            return a;
        }
        //Closer
        public int Closer(int a, int b)
        {
            if (Math.Abs(a - 10) > Math.Abs(b - 10))
            {
                return b;
            }
            else if (Math.Abs(a - 10) < Math.Abs(b - 10))
            {
                return a;
            }
            else if (Math.Abs(a - 10) == Math.Abs(b - 10))
            {
                return 0;
            }
            return 1;
        }
        //EEEEEEE
        public bool GotE(string str) 
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'e')
                {
                    count++;

                }
            }
            if (count <= 3)
            {
                return true;
            }
            return false;
        }
        //26.EndUp
        public string EndUp(string str)
        {
            if (str.Length > 3)
            {
                string str2 = str.Substring(str.Length - 3).ToUpper();
                string str3 = str.Substring(0, str.Length - 3);
                return str3 + str2;
            }
            string str4 = str.ToUpper();
            return str4;
        }
        //27. EveryNth
        public string EveryNth(string str, int n)
        {
            string str1 = "";
            for (int i = 0; i < str.Length; i += n)//increment every nth char
            {
                str1 += str[i]; // store each char from str to str1
            }
            return str1;
        }

        //***********************************************************************
        //************** START LOOPS**********************************************
        //**********************************************************************
        //1.String Times
        public string StringTimes(string str, int n)
        {
            string s = "";

            for (int i = 0; i < n; i++)
            {
                s = s + str;
            }
            return s;
        }
        // 2.FrontTimes
        public string FrontTimes(string str, int n)
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s = s += str.Substring(0, 3);
            }
            return s;
        }

        //3.CountXX
        public int CountXX(string str)
        {
            int counter = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str.Substring(i, 2) == "xx")
                {
                    counter++;
                }
            }
            return counter;
        }
        //4. DoubleX
        public bool DoubleX(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'x')
                {
                    if (str[i + 1] == 'x')
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        //5.EveryOther
        public string EveryOther(string str)
        {
            string s = "";
            for (int i = 0; i < str.Length; i += 2)
            {
                s += str.Substring(i, 1);
            }
            return s;
        }
        //6. StringSplosion
        public string StringSplosion(string str)
        {
            string s = "";
            for (int i = 0; i <= str.Length; i++)
            {
                s += str.Substring(0, i);
            }
            return s;
        }
        //7.CountLast2
        public int CountLast2(string str)
        {
           string str2 =  str.Substring(str.Length - 2, 2);
            int count = 0;
            for (int i = 0; i < str.Length-2; i++)
            {
                if (str.Substring(i, 2) == str2)
                {
                    count++;
                }
            }
            return count;
        }

        //8.Count9
        public int Count9(int[] numbers)
        {
            int count = 0;
            foreach (var a in numbers)
            {
                if (a == 9)
                {
                    count++;
                }
            }
            return count;
        }
        //9. ArrayFront9
        public bool ArrayFront9(int[] numbers)
        {
            for (int i = 0; i < 4; i++)
            {
                if (numbers[i] == 9)
                {
                    return true;
                }
            }
            return false;
        }
        //10.Array123
        public bool Array123(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                {
                    return true;
                }
            }
            return false;
        }
        //11. SubStringMatch
        public int SubStringMatch(string a, string b)
        {
            int count = 0;
            for (int i = 0; i < a.Length - 1 && i < b.Length - 1; i++)
            {
                if (a.Substring(i, 2).Equals(b.Substring(i, 2)))
                    count++;
            }
            return count;
        }
        //12. StringX
        public string StringX(string str)
        {
            char temp1 = str[0];
            char temp2 = str[str.Length-1];
            string temp3 = str.Substring(1,str.Length-2) ;
            string s = "";
            for (int i = 0; i < temp3.Length; i++)
            {
                if(temp3[i] != 'x')
                {
                    s += temp3[i];
                }
            }
            return temp1 + s + temp2;
        }

        //13. AltPairs 
        public string AltPairs(string str)
        {
            string str2 = "";
            for (int i = 0; i <= str.Length-1; i += 4)
            {
                if (i == str.Length - 1)
                {
                    str2 += str.Substring(i , 1);
                }
                else
                {
                    str2 += str.Substring(i, 2);
                }
            }
            return str2;

        }
        //14.DoNotYak
        public string DoNotYak(string str)
        {
            string str2 = "";
            int x = 3;
            for (int i = 0; i < str.Length; i += 3)
            {
                if (i + 3 > str.Length)
                {
                    x = 2;
                }
                if (str.Substring(i, x) != ("yak"))
                {
                    str2 += str.Substring(i, x);
                }
            }
            return str2;
        }

        //15. Array667
        public int Array667(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 6 && numbers[i + 1] == 6 || numbers[i] == 6 && numbers[i + 1] == 7)
                {
                    count++;
                }
            }
            return count;
        }
        //NoTripples
        public bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2])
                {
                    return false;
                }
            }
            return true;
        }
        //Pattern51
        public bool Pattern51(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length - 3; i++)
            {
                if ((numbers[i + 1] == numbers[i] + 5) && (numbers[i + 2] == numbers[i] -1))
                {
                    return true;
                }
            }
            return false;
        }


        //****************************************************
        //************START LOGIC****************************
        //**************FINISHED****************************
        //1. GreatParty
        public
            bool GreatParty(int cigars, bool isWeekend)
        {
            if ((!isWeekend && cigars >= 40 && cigars <= 60) || (isWeekend && cigars > 40))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //2. CanHazTable
        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if (yourStyle >= 8 || dateStyle >= 8)
            {
                return 2;
            }
            else if (yourStyle <= 2 || dateStyle <= 2)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        } // endCanHazTable

        //  3. PlayOutside      
        public bool PlayOutside(int temp, bool isSummer)
        {
            if ((temp >= 60 && temp <= 90) && (!isSummer) || (temp >= 60 && temp <= 100) && (isSummer))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //4. CaughtSpeeding
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (!isBirthday)
            {
                if (speed <= 60)
                {
                    return 0;
                }
                else if ((speed >= 61) && (speed <= 80))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                if (speed <= 65)
                {
                    return 0;
                }
                else if ((speed >= 66) && (speed <= 85))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
        //5. SkipSum
        public int SkipSum(int a, int b)
        {
            int sum = a + b;
            if (sum >= 10 && sum <= 19)
            {
                return 20;
            }
            else
            {
                return sum;
            }
        }
        //6. AlarmClock
        public string AlarmClock(int day, bool vacation)
        {
            if (!vacation)
            {
                if (day >= 1 && day < 6)
                {
                    return "7:00";
                }
                else
                {
                    return "10:00";
                }
            }
            else
            {
                if (day >= 1 && day < 6)
                {
                    return "10:00";

                }
                else
                {
                    return "off";
                }
            }
        }
        //7. LoveSix
        public bool LoveSix(int a, int b)
        {
            if (a == 6 || b == 6)
            {
                return true;
            }
            else if (a + b == 6)
            {
                return true;
            }
            else if (a - b == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //8. InRange
        public bool InRange(int n, bool outsideMode)
        {
            if (!outsideMode)
            {
                if (n >= 1 && n <= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (n <= 1 || n >= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        //9. SpecialEleven
        public bool SpecialEleven(int n)
        {
            if (n % 11 == 0)
            {
                return true;
            }
            else if ((n - 1) % 11 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //10. Mod20
        public bool Mod20(int n)
        {
            if ((n - 1) % 20 == 0)
            {
                return true;
            }
            else if ((n - 2) % 20 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //11. Mod35
        public bool Mod35(int n)
        {
            if ((n % 3) == 0 && (n % 5) == 0)
            {
                return false;
            }
            else if ((n % 3) == 0 || (n % 5) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //12. AnswerCell
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep)
            {
                return false;
            }
            else if ((isMorning && isMom) || !isMorning)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //13. TwoIsOne
        public bool TwoIsOne(int a, int b, int c)
        {
            if (a + b == c || a + c == b || b + a == c || b + c == a || c + a == b || c + b == a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //14. AreInOrder
        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if (bOk && (c > b))
            {
                return true;
            }
            else if (!bOk && b > a && c > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //15. InOrderEqual
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (!equalOk)
            {
                if ((b > a) && (c > b))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (equalOk)
            {
                if ((b == a || b > a) && ((c == b) && (c == a)) || (c > b))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        //16. LastDigit
        public bool LastDigit(int a, int b, int c)
        {
            if ((a % 10 == b % 10) || (a % 10 == c % 10) || (b % 10 == c % 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //17. RollDice
        public int RollDice(int a, int b, bool noDoubles)
        {
            if (noDoubles)
            {
                if (a == b)
                {
                    b = b + 1;
                    if (b > 6)
                    {
                        b = 1;
                        return a + b;
                    }
                }
                else
                {
                    return a + b;
                }
            }
            return a + b;
        }

    }//end class
}//end namespace


