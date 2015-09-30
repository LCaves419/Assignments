using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create object exercises of type StringExercises
            StringExercises exercises = new StringExercises();
            //SayHi
            Console.WriteLine(exercises.SayHi("Bob"));//-> "Hello Bob!"
            Console.WriteLine(exercises.SayHi("Alice"));//-> "Hello Alice!"
            Console.WriteLine(exercises.SayHi("X"));// -> "Hello X!"
                                                    //Abba
            Console.WriteLine(exercises.Abba("HI", "Bye"));// HiByeByeHi
            Console.WriteLine(exercises.Abba("Yo", "Alice"));//-> "YoAliceAliceYo"
            Console.WriteLine(exercises.Abba("What", "Up"));//-> "WhatUpUpWhat"
                                                            // MakeTags
            Console.WriteLine(exercises.MakeTags("i", "Yay"));// MakeTags-> "<i>Yay</i>"
            Console.WriteLine(exercises.MakeTags("i", "Hello"));//-> "<i>Hello</i>"
            Console.WriteLine(exercises.MakeTags("cite", "Yay"));//-> "<cite>Yay</cite>"

            //InsertWord
            Console.WriteLine(exercises.InsertWord("<<>>", "Yay"));//-> "<<Yay>>"
            Console.WriteLine(exercises.InsertWord("<<>>", "WooHoo"));//-> "<<WooHoo>>"
            Console.WriteLine(exercises.InsertWord("[[]]", "word"));//-> "[[word]]"
                                                                    //mutipleEndings
            Console.WriteLine(exercises.MultipleEndings("Hello"));//-> "lololo"
            Console.WriteLine(exercises.MultipleEndings("ab"));//-> "ababab"
            Console.WriteLine(exercises.MultipleEndings("Hi"));//-> "HiHiHi"
                                                               //firstHalf
            Console.WriteLine(exercises.FirstHalf("WooHoo")); //-> "Woo"
            Console.WriteLine(exercises.FirstHalf("HelloThere")); //-> "Hello"
            Console.WriteLine(exercises.FirstHalf("abcdef")); //-> "abc"
                                                              //TrimOne
            Console.WriteLine(exercises.TrimOne("Hello"));//-> "ell"
            Console.WriteLine(exercises.TrimOne("java"));//-> "av"
            Console.WriteLine(exercises.TrimOne("coding"));//-> "odin"
                                                           //LongInMiddle
            Console.WriteLine(exercises.LongInMiddle("Hello", "hi"));//-> "hiHellohi"
            Console.WriteLine(exercises.LongInMiddle("hi", "Hello"));//-> "hiHellohi"
            Console.WriteLine(exercises.LongInMiddle("aaa", "b"));//-> "baaab"
                                                                  //RotateLeft2
            Console.WriteLine(exercises.Rotateleft2("Hello")); //-> "lloHe"
            Console.WriteLine(exercises.Rotateleft2("java")); //-> "vaja"
            Console.WriteLine(exercises.Rotateleft2("Hi"));//"Hi"
                                                           //RotateRight2
            Console.WriteLine(exercises.RotateRight2("Hello"));//"loHel"
            Console.WriteLine(exercises.RotateRight2("java"));//-> "vaja"
            Console.WriteLine(exercises.RotateRight2("Hi"));//-> "Hi"
                                                            //TakeOne
            Console.WriteLine(exercises.TakeOne("Hello", true));//-> "H"
            Console.WriteLine(exercises.TakeOne("Hello", false));//-> "o"
            Console.WriteLine(exercises.TakeOne("oh", true));//-> "o"
            //MiddleTwo
            Console.WriteLine("This is the middleTwo");
            Console.WriteLine(exercises.MiddleTwo("string"));//-> "ri"
            Console.WriteLine(exercises.MiddleTwo("code"));//-> "od"
            Console.WriteLine(exercises.MiddleTwo("Practice"));//-> "ct"
            //EndsWithLY
            Console.WriteLine("ENDS WITHLY:::::::::");
            Console.WriteLine(exercises.EndsWithLy("oddly"));//-> true
            Console.WriteLine(exercises.EndsWithLy("y"));// -> false
            Console.WriteLine(exercises.EndsWithLy("oddy"));// -> false
                                                            //FrontAndBack
            Console.WriteLine("FRONTANDBACK::::::::::");
            Console.WriteLine(exercises.FrontAndBack("Hello", 2));//-> "Helo"
            Console.WriteLine(exercises.FrontAndBack("Chocolate", 3));// -> "Choate"
            Console.WriteLine(exercises.FrontAndBack("Chocolate", 1));// -> "Ce"
            //TakeTwoFromPosition
            Console.WriteLine("TAKETWOFROMPOSITION::::::::::::::::::::");
            Console.WriteLine(exercises.TakeTwoFromPosition("java", 0));//-> "ja"
            Console.WriteLine(exercises.TakeTwoFromPosition("java", 2));// -> "va"
            Console.WriteLine(exercises.TakeTwoFromPosition("java", 3));// -> "ja"
            //HasBad
            Console.WriteLine("HASBAD::::;HASBAD:::::::::::");
            Console.WriteLine(exercises.HasBad("badxx"));//-> true
            Console.WriteLine(exercises.HasBad("xbadxx"));// -> true
            Console.WriteLine(exercises.HasBad("xxbadxx"));// -> false
                                                           //AtFirst
            Console.WriteLine("ATFIRST::::ATFIRST:::::");
            Console.WriteLine(exercises.AtFirst("hello"));//-> "he"
            Console.WriteLine(exercises.AtFirst("hi"));// -> "hi"
            Console.WriteLine(exercises.AtFirst("h"));// -> "h@"
            //LastChars
            Console.WriteLine("LASTCHARS:::::::LASTCHARS:::::::");
            Console.WriteLine(exercises.LastChars("last", "chars"));//-> "ls"
            Console.WriteLine(exercises.LastChars("yo", "mama"));//-> "ya"
            Console.WriteLine(exercises.LastChars("hi", ""));//-> "h@"
            //ConCat
            Console.WriteLine("CONCAT::::::CONCAT::::::::");
            Console.WriteLine(exercises.ConCat("abc", "cat"));//-> "abcat"
            Console.WriteLine(exercises.ConCat("dog", "cat"));// -> "dogcat"
            Console.WriteLine(exercises.ConCat("abc", ""));// -> "abc"
            //SwapLast
            Console.WriteLine("SWAPLAST:::::::::SWAPLAST::::::::");
            Console.WriteLine(exercises.SwapLast("coding"));//-> "codign"
            Console.WriteLine(exercises.SwapLast("cat"));// -> "cta"
            Console.WriteLine(exercises.SwapLast("ab"));// -> "ba"
                                                        //FrontAgain
            Console.WriteLine("FRONTAGAIN::::::::FRONTAGAIN:::::::");
            Console.WriteLine(exercises.FrontAgain("edited"));//-> true
            Console.WriteLine(exercises.FrontAgain("edit"));// -> false
            Console.WriteLine(exercises.FrontAgain("ed"));// -> true
            //MinCat
            Console.WriteLine("MINCAT:::::::::::MINCAT::::::::");
            Console.WriteLine(exercises.MinCat("Hello", "Hi"));//-> "loHi"
            Console.WriteLine(exercises.MinCat("Hello", "java"));// -> "ellojava"
            Console.WriteLine(exercises.MinCat("java", "Hello"));// -> "javaello"
            //TweakFront
            Console.WriteLine("TWEAKFRONT:::::::TWEAKFRONT::::");
            Console.WriteLine(exercises.TweakFront("Hello"));//-> "llo"
            Console.WriteLine(exercises.TweakFront("away"));// -> "aay"
            Console.WriteLine(exercises.TweakFront("abed"));// -> "abed"
                                                            //StripX
            Console.WriteLine(exercises.StripX("xHix"));// -> "Hi"
            Console.WriteLine(exercises.StripX("xHi"));// -> "Hi"
            Console.WriteLine(exercises.StripX("Hxix"));// -> "Hxi"
                                                        //************START CONDITIONALS*************************************
                                                        //MischeviousChildren 
            Console.WriteLine(exercises.AreWeInTrouble(true, true));//-> true
            Console.WriteLine(exercises.AreWeInTrouble(false, false));//-> true
            Console.WriteLine(exercises.AreWeInTrouble(true, false));//-> false

            //CanSleepIn
            Console.WriteLine(exercises.CanSleepIn(false, false));//-> true
            Console.WriteLine(exercises.CanSleepIn(true, false));//-> false
            Console.WriteLine(exercises.CanSleepIn(false, true));//-> true
            //SumDouble
            Console.WriteLine(exercises.SumDouble(1, 2));//-> 3
            Console.WriteLine(exercises.SumDouble(3, 2));//-> 5
            Console.WriteLine(exercises.SumDouble(2, 2));//-> 8
            //Diff21
            Console.WriteLine(exercises.Diff21(23));//-> 4
            Console.WriteLine(exercises.Diff21(10));//-> 11
            Console.WriteLine(exercises.Diff21(21));//-> 0
            //ParrotTrouble
            Console.WriteLine(exercises.ParrotTrouble(true, 6));//T
            Console.WriteLine(exercises.ParrotTrouble(true, 7));//F
            Console.WriteLine(exercises.ParrotTrouble(false, 6));//F
            Console.WriteLine(exercises.ParrotTrouble(true, 21));//T
            //Makes10
            Console.WriteLine(exercises.Makes10(9, 10));//-> true
            Console.WriteLine(exercises.Makes10(9, 9));//-> false
            Console.WriteLine(exercises.Makes10(1, 9));//-> true
            Console.WriteLine(exercises.Makes10(10, 9));//-> true
            //NearHundred
            Console.WriteLine(exercises.NearHundred(103));//-> true
            Console.WriteLine(exercises.NearHundred(90));//-> true
            Console.WriteLine(exercises.NearHundred(89));//-> false
            Console.WriteLine(exercises.NearHundred(205));//-> true
            //PosNeg
            Console.WriteLine(exercises.PosNeg(1, -1, false));//-> true
            Console.WriteLine(exercises.PosNeg(-1, 1, false));//-> true
            Console.WriteLine(exercises.PosNeg(-4, -5, true));//-> true
            Console.WriteLine(exercises.PosNeg(4, -5, true));//-> false
            //NotString
            Console.WriteLine(exercises.NotString("candy"));//-> "not candy"
            Console.WriteLine(exercises.NotString("x"));//-> "not x"
            Console.WriteLine(exercises.NotString("not bad"));//-> "not bad"
            //MissingChar
            Console.WriteLine("This is the MissingChar Method::::");
            Console.WriteLine(exercises.MissingChar("kitten", 1));//-> "ktten"
            Console.WriteLine(exercises.MissingChar("kitten", 0));//-> "itten"
            Console.WriteLine(exercises.MissingChar("kitten", 4));//-> "kittn"
            Console.WriteLine("THis is end of MissingCharMethod::::");
            //FrontBack
            Console.WriteLine("This is FRONTBACK::::::");
            Console.WriteLine(exercises.FrontBack("code"));//-> "eodc"
            Console.WriteLine(exercises.FrontBack("a"));//-> "a"
            Console.WriteLine(exercises.FrontBack("ab"));//-> "ba"  
                                                         //Front3
            Console.WriteLine(":::::::::::::FRONT3:::::::::::");
            Console.WriteLine(exercises.Front3("Microsoft"));//-> "MicMicMic"
            Console.WriteLine(exercises.Front3("Chocolate"));// -> "ChoChoCho"
            Console.WriteLine(exercises.Front3("at"));// -> "atatat"
                                                      //BackAround
            Console.WriteLine("::::::::::::BACKAROUND:::::::::");
            Console.WriteLine(exercises.BackAround("cat"));//-> "tcatt"
            Console.WriteLine(exercises.BackAround("Hello"));// -> "oHelloo"
            Console.WriteLine(exercises.BackAround("a"));// -> "aaa"
                                                         //Mutiple3Or5
            System.Console.WriteLine(":::::MULTIPLE3OR5:::::::::::");
            Console.WriteLine(exercises.Multiple3Or5(3));//-> true
            Console.WriteLine(exercises.Multiple3Or5(10));// -> true
            Console.WriteLine(exercises.Multiple3Or5(8));// -> false
            //StartHi
            Console.WriteLine(":::::::STARTHI:::::::::::::");
            Console.WriteLine(exercises.StartHi("hi there"));//-> true
            Console.WriteLine(exercises.StartHi("hi"));// -> true
            Console.WriteLine(exercises.StartHi("high up"));// -> false
                                                            //IcyHot
            Console.WriteLine(":::::ICYHOT:::::::::");
            Console.WriteLine(exercises.IcyHot(120, -1));//-> true
            Console.WriteLine(exercises.IcyHot(-1, 120));// -> true
            Console.WriteLine(exercises.IcyHot(2, 120));// -> false
                                                        //Between10And20
            Console.WriteLine("::::::::::::BETWEEN10AND20:::::::::::::");
            Console.WriteLine(exercises.Between10And20(12, 99));//-> true
            Console.WriteLine(exercises.Between10And20(21, 12));// -> true
            Console.WriteLine(exercises.Between10And20(8, 99));//) -> false
                                                               //HasTeen
            Console.WriteLine(":::::HASTEEN:::::::::::::");
            Console.WriteLine(exercises.HasTeen(13, 20, 10));// -> true
            Console.WriteLine(exercises.HasTeen(20, 19, 10));// -> true
            Console.WriteLine(exercises.HasTeen(20, 10, 12));// -> false
            //SoAlone
            Console.WriteLine(":::::::::::SOALONE::::::::::::");
            Console.WriteLine(exercises.SoAlone(13, 99));// -> true
            Console.WriteLine(exercises.SoAlone(21, 19));// -> true
            Console.WriteLine(exercises.SoAlone(13, 13));// -> false
            //RemoveDel
            Console.WriteLine(":::::::::::REMOVEDEL:::::::");
            Console.WriteLine(exercises.RemoveDel("adelbc"));// -> "abc"
            Console.WriteLine(exercises.RemoveDel("adelHello"));// -> "aHello"
            Console.WriteLine(exercises.RemoveDel("adedbc"));// -> "adedbc"

            //IxStart
            Console.WriteLine("::::::::IXSTART:::::::::::");
            Console.WriteLine(exercises.IxStart("mix snacks"));// -> true
            Console.WriteLine(exercises.IxStart("pix snacks"));// -> true
            Console.WriteLine(exercises.IxStart("piz snacks"));// -> false

            //StartOz
            Console.WriteLine("::::::::::STARTOZ:::::::::::::");
            Console.WriteLine(exercises.StartOz("ozymandias"));// -> "oz"
            Console.WriteLine(exercises.StartOz("bzoo"));// -> "z"
            Console.WriteLine(exercises.StartOz("oxx"));// -> "o"

            //Max
            Console.WriteLine(":::::::::::::MAX::::::::::::::");
            Console.WriteLine(exercises.Max(1, 2, 3));// -> 3
            Console.WriteLine(exercises.Max(1, 3, 2));// -> 3
            Console.WriteLine(exercises.Max(3, 2, 1));// -> 3
                                                      //Closer
            Console.WriteLine("::::::::::::CLOSER::::::::::::");
            Console.WriteLine(exercises.Closer(8, 13));// -> 8
            Console.WriteLine(exercises.Closer(13, 8));// -> 8
            Console.WriteLine(exercises.Closer(13, 7));// -> 0

            //EEEEEE
            Console.WriteLine(":::::::::::EEEEEEEEEEEEE:::::::::");
            Console.WriteLine(exercises.GotE("Hello"));// -> true
            Console.WriteLine(exercises.GotE("Heelle"));// -> true
            Console.WriteLine(exercises.GotE("Heelele"));// -> false

            //EndUp
            Console.WriteLine(":::::::ENDUP:::::::::::::::");
            Console.WriteLine(exercises.EndUp("Hello"));// -> "HeLLO"
            Console.WriteLine(exercises.EndUp("hi there"));// -> "hi thERE"
            Console.WriteLine(exercises.EndUp("hi"));// -> "HI"

            //EveryNth
            Console.WriteLine(":::::::::EVERYNTH:::::::");
            Console.WriteLine(exercises.EveryNth("Miracle", 2));//-> "Mrce"
            Console.WriteLine(exercises.EveryNth("abcdefg", 2));// -> "aceg"
            Console.WriteLine(exercises.EveryNth("abcdefg", 3));// -> "adg"


            //**************************************************
            //************LOOPS**********************************
            //***************************************************
            //StringTimes
            Console.WriteLine(exercises.StringTimes("Hi", 2));//-> "HiHi"
            Console.WriteLine(exercises.StringTimes("Hi", 3));//)-> "HiHiHi"
            Console.WriteLine(exercises.StringTimes("Hi", 1));//-> "Hi" */
            //FrontTimes
            Console.WriteLine(exercises.FrontTimes("Chocolate", 2));//-> "ChoCho"
            Console.WriteLine(exercises.FrontTimes("Chocolate", 3));//-> "ChoChoCho"
            Console.WriteLine(exercises.FrontTimes("Abc", 3));//-> "AbcAbcAbc"
            //CountXX
            Console.WriteLine(exercises.CountXX("abcxx"));//-> 1
            Console.WriteLine(exercises.CountXX("xxx"));// -> 2
            Console.WriteLine(exercises.CountXX("xxxx"));// -> 3
            //4.DOUBLEx 
            Console.WriteLine("This IS DOUBLEX:::::::::::::");
            Console.WriteLine(exercises.DoubleX("axxbb"));//-> true
            Console.WriteLine(exercises.DoubleX("axaxxax"));// -> false
            Console.WriteLine(exercises.DoubleX("xxxxx"));// -> true 
            
            //5.EveryOther
            Console.WriteLine(":::::::EVERYOTHER:::::::::");
            Console.WriteLine(exercises.EveryOther("Hello"));//-> "Hlo"
            Console.WriteLine(exercises.EveryOther("Hi"));// -> "H"
            Console.WriteLine(exercises.EveryOther("Heeololeo"));// -> "Hello"

            //6.StringSplosion
            Console.WriteLine(":::::::::STINGSPLOSION:::::::::::");
            Console.WriteLine(exercises.StringSplosion("Code"));// -> "CCoCodCode"
            Console.WriteLine(exercises.StringSplosion("abc"));// -> "aababc"
             Console.WriteLine(exercises.StringSplosion("ab"));// -> "aab"

            //7.Countlast2
            Console.WriteLine("::::::::::::::CountLast2:::::::::::::::::::");
            Console.WriteLine(exercises.CountLast2("hixxhi"));// -> 1
            Console.WriteLine(exercises.CountLast2("xaxxaxaxx"));// -> 1
            Console.WriteLine(exercises.CountLast2("axxxaaxx"));// -> 2

            //8. Count9
            Console.WriteLine("::::::::COUNT9:::::::::::");
            int[] array = new int[3] {1,2,9};
            Console.WriteLine(exercises.Count9(array));// -> 1
            int [] array1 = new int[] {1,9,9};
            Console.WriteLine(exercises.Count9(array1));// -> 2
            int [] array2 = new int[] {1,9,9,3,9};
            Console.WriteLine(exercises.Count9(array2));// -> 3

            //9. ArrayFront9
            Console.WriteLine(":::::::::::::ARRAYFRONT9:::::::::::::::");
            int [] a = new int[] { 1, 2, 9, 3, 4 };
            Console.WriteLine(exercises.ArrayFront9(a));// -> true
            int[] a1 = new int[] {1, 2, 3, 4, 9};
            Console.WriteLine(exercises.ArrayFront9(a1));//) -> false
            int[] a2 = new int[] {1, 2, 3, 4, 5};
            Console.WriteLine(exercises.ArrayFront9(a2));// -> false

            //Array123
            Console.WriteLine(":::::::::::ARRAY123::::::::::");
            int[] b = new[] {1, 1, 2, 3, 1};
            Console.WriteLine(exercises.Array123(b));// -> true
            int[] b1 = new[] {1, 1, 2, 4, 1};
            Console.WriteLine(exercises.Array123(b1));// -> false
            int[] b2 = new[] {1, 1, 2, 1, 2, 3};
            Console.WriteLine(exercises.Array123(b2));// -> true

            //SubstringMatch
            Console.WriteLine(":::::SUBSTRINGMATCH:::::::::");
            Console.WriteLine(exercises.SubStringMatch("xxcaazz", "xxbaaz"));// -> 3
            Console.WriteLine(exercises.SubStringMatch("abc", "abc"));// -> 2
            Console.WriteLine(exercises.SubStringMatch("abc", "axc"));// -> 0

            //StringX 
            Console.WriteLine("::::::::::STRINGX::::::::::::::::");
            Console.WriteLine(exercises.StringX("xxHxix"));// -> "xHix"
            Console.WriteLine(exercises.StringX("abxxxcd"));// -> "abcd"
            Console.WriteLine(exercises.StringX("xabxxxcdx"));// -> "xabcdx"

            //AltPairs*********************************************************????????????????
            Console.WriteLine("::::::ALTPAIRS:::::::::::::::");
            Console.WriteLine(exercises.AltPairs("kitten"));// -> "kien"
            Console.WriteLine(exercises.AltPairs("Chocolate"));// -> "Chole"
            Console.WriteLine(exercises.AltPairs("CodingHorror"));// -> "Congrr"

            //DoNotYak
            Console.WriteLine(":::::::::::::::::DONOTYAK::::::::::::::::::");
            Console.WriteLine(exercises.DoNotYak("yakpak"));// -> "pak"
            Console.WriteLine(exercises.DoNotYak("pakyak"));// -> "pak"
            Console.WriteLine(exercises.DoNotYak("yak123ya"));// -> "123ya"


            //Array667
            Console.WriteLine(":::::ARRAY667:::::::::::::");
            int[] c = new[] {6, 6, 2};
            Console.WriteLine(exercises.Array667(c));// -> 1
            int[] c1 = new[] {6, 6, 2, 6};
            Console.WriteLine(exercises.Array667(c1));// -> 1
            int[] c2 = new[] {6, 7, 2, 6};
            Console.WriteLine(exercises.Array667(c2));// -> 1

            //NoTripples
            Console.WriteLine(":::::::::::::::::NOTRIPPLES:::::::::::");
            int[] d = new[] {1, 1, 2, 2, 1};
            Console.WriteLine(exercises.NoTriples(d));// -> true
            int[] d1 = new[] {1, 1, 2, 2, 2, 1};
            Console.WriteLine(exercises.NoTriples(d1));// -> false
            int[] d2 = new[] {1, 1, 1, 2, 2, 2, 1};
            Console.WriteLine(exercises.NoTriples(d2));// -> false

            //Pattern51
            Console.WriteLine(":::::::PATTERN51::::::::");
            int[] e = new[] {1, 2, 7, 1};
            Console.WriteLine(exercises.Pattern51(e));// -> true
            int[] e1 = new[] {1, 2, 8, 1};
            Console.WriteLine(exercises.Pattern51(e1));// -> false
            int[] e2 = new[] {0, 2, 7};
            Console.WriteLine(exercises.Pattern51(e2));// -> true

            



            //***************************************************************************
            //***********************Start LOGIC****************************************
            //*************************FINISHED********************************************
            //1. GreatParty
            Console.WriteLine(exercises.GreatParty(30, false));// → false
            Console.WriteLine(exercises.GreatParty(50, false));// → true
            Console.WriteLine(exercises.GreatParty(70, true));// → true
                                                              //2. CanHazTable
            Console.WriteLine(exercises.CanHazTable(5, 10));// → 2
            Console.WriteLine(exercises.CanHazTable(5, 2));// → 0
            Console.WriteLine(exercises.CanHazTable(5, 5));// → 1
            //3. PlayOutside
            Console.WriteLine(exercises.PlayOutside(70, false));// → true
            Console.WriteLine(exercises.PlayOutside(95, false));// → false
            Console.WriteLine(exercises.PlayOutside(95, true));// → true
            //4. CaughtSpeeding
            Console.WriteLine(exercises.CaughtSpeeding(60, false));// → 0
            Console.WriteLine(exercises.CaughtSpeeding(65, false));// → 1
            Console.WriteLine(exercises.CaughtSpeeding(65, true));// → 0
            //5. SkipSum
            Console.WriteLine(exercises.SkipSum(3, 4));// → 7
            Console.WriteLine(exercises.SkipSum(9, 4));// → 20
            Console.WriteLine(exercises.SkipSum(10, 11));// → 21
            //6.AlarmClock
            Console.WriteLine(exercises.AlarmClock(1, false));// → "7:00"
            Console.WriteLine(exercises.AlarmClock(5, false));// → "7:00"
            Console.WriteLine(exercises.AlarmClock(0, false));// → "10:00"
            //7. LoveSix
            Console.WriteLine(exercises.LoveSix(6, 4));// → true
            Console.WriteLine(exercises.LoveSix(4, 5));// → false
            Console.WriteLine(exercises.LoveSix(1, 5));// → true
            //8. InRange
            Console.WriteLine(exercises.InRange(5, false));// → true
            Console.WriteLine(exercises.InRange(11, false));// → false
            Console.WriteLine(exercises.InRange(11, true));// → true
            //9. SpecialEleven
            Console.WriteLine(exercises.SpecialEleven(22));// → true
            Console.WriteLine(exercises.SpecialEleven(23));// → true
            Console.WriteLine(exercises.SpecialEleven(24));// → false
            //10. Mod20
            Console.WriteLine(exercises.Mod20(20));// → false
            Console.WriteLine(exercises.Mod20(21));// → true
            Console.WriteLine(exercises.Mod20(22));// → true
            //11. Mod35
            Console.WriteLine(exercises.Mod35(3));// → true
            Console.WriteLine(exercises.Mod35(10));// → true
            Console.WriteLine(exercises.Mod35(15));// → false
            //12. AnswerCell
            Console.WriteLine(exercises.AnswerCell(false, false, false));// → true
            Console.WriteLine(exercises.AnswerCell(false, false, true));// → false
            Console.WriteLine(exercises.AnswerCell(true, false, false));// → false
            //13. TwoIsOne
            Console.WriteLine(exercises.TwoIsOne(1, 2, 3));// → true
            Console.WriteLine(exercises.TwoIsOne(3, 1, 2));// → true
            Console.WriteLine(exercises.TwoIsOne(3, 2, 2));// → false
            //14. AreInOrder
            Console.WriteLine(exercises.AreInOrder(1, 2, 4, false));// → true
            Console.WriteLine(exercises.AreInOrder(1, 2, 1, false));// → false
            Console.WriteLine(exercises.AreInOrder(1, 1, 2, true));// → true
            //15. InOrderEqual
            Console.WriteLine(exercises.InOrderEqual(2, 5, 11, false));// → true
            Console.WriteLine(exercises.InOrderEqual(5, 7, 6, false));// → false
            Console.WriteLine(exercises.InOrderEqual(5, 5, 7, true));// → true
            //16. LastDigit
            Console.WriteLine(exercises.LastDigit(23, 19, 13));// → true
            Console.WriteLine(exercises.LastDigit(23, 19, 12));// → false
            Console.WriteLine(exercises.LastDigit(23, 19, 3));// → true
            //17. RollDice
            Console.WriteLine(exercises.RollDice(2, 3, true));// → 5
            Console.WriteLine(exercises.RollDice(3, 3, true));// → 7
            Console.WriteLine(exercises.RollDice(3, 3, false));// → 6



            Console.ReadLine();




        }//end Main()
    }//end class Program
}//end namespace 

