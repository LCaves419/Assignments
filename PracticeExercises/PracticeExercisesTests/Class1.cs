using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using PracticeExercises;
// q's ---

namespace PracticeExercisesTests
{
    [TestFixture]
    //name should be same as the class my methods are in that I am testing. 
    public class Class1
    {
        private StringExercises stringexercises;

        [SetUp]
        public void BeforeEachTest()
        {
            //Arrange
            stringexercises = new StringExercises();
        }
        //******************STRINGS********************************************
        //1. SayHi Test
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void PassInNameReturnName(string name, string expextedResult)
        {
            //Act
            string hello = stringexercises.SayHi(name);

            //Assert
            Assert.AreEqual(expextedResult, hello);
        }
        //2.Abba Test
        [TestCase("Hi", "Bye", "HiByeByeHi")]
        [TestCase("Yo", "Alice", "YoAliceAliceYo")]
        [TestCase("What", "Up", "WhatUpUpWhat")]
        public void TwoCharactersFirstOnInsideTwice(string a, string b, string expectedResult)
        {
            //Act
            string str = stringexercises.Abba(a, b);
            //Assert
            Assert.AreEqual(expectedResult, str);
        }
        //3.MakeTags Test
        [TestCase("i", "Yay", "<i>Yay</i>")]
        public void PutTagsAroundContent(string a, string b, string expectedResult)
        {
            //Act
            string str = stringexercises.MakeTags(a, b);
            //Assert
            Assert.AreEqual(expectedResult, str);
        }
       
        //4.InsertWord
        [TestCase("<<>>", "Yay", "<<Yay>>")]
        [TestCase("<<>>", "WooHoo", "<<WooHoo>>")]
        [TestCase("[[]]", "word", "[[word]]")]
        public void InsertWordInsideContainer(string container, string word, string expectedResult)
        {
            //Act
            string result = stringexercises.InsertWord(container, word);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //5.MutipleEndings
        [TestCase("Hello", "lololo")]
        [TestCase("ab", "ababab")]
        [TestCase("Hi", "HiHiHi")]
        public void ReturnLastTwoCharsThreeTimes(string str, string expectedResult)
        {
            //Act
            string result = stringexercises.MultipleEndings(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //6.FirstHalf
        [TestCase("WooHoo", "Woo")]
        [TestCase("HelloThere", "Hello")]
        [TestCase("abcdef", "abc")]
        public void ReturnFirstHalfOfString(string str, string expectedResult)
        {
            //Act
            string result = stringexercises.FirstHalf(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //7.TrimOne
        [TestCase("Hello", "ell")]
        [TestCase("java", "av")]
        [TestCase("coding", "odin")]
        public void TrimFirstAndLastReturnMiddle(string word, string expectedResult)
        {
            //Act
            string result = stringexercises.TrimOne(word);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //8.LongInMiddle
        [TestCase("Hello", "hi", "hiHellohi")]
        [TestCase("hi", "Hello", "hiHellohi")]
        [TestCase("aaa", "b", "baaab")]
        public void PutLongStringInMiddleOfShortString(string longString, string shortString, string expectedResult)
        {
            //Act
            string result = stringexercises.LongInMiddle(longString, shortString);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //9.RotateLeft2
        [TestCase("Hello", "lloHe")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void CutFirstTwoCharsPutOnEnd(string str, string expectedResult)
        {
            //Act
            string result = stringexercises.Rotateleft2(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //10.RotateRight
        [TestCase("Hello", "loHel")]
        [TestCase("java", "vaja")]
        [TestCase("Hi", "Hi")]
        public void CutLastTwoCharsPutOnFront(string str, string expectedResult)
        {
            //Act
            string result = stringexercises.RotateRight2(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //11.TakeOne
        [TestCase("Hello", true, "H")]
        [TestCase("Hello", false, "o")]
        [TestCase("oh", true, "o")]
        public void ReturnFirstCharForTrueLastCharForFalse(string str, bool fromFront, string expectedResult)
        {
            //Act
            string result = stringexercises.TakeOne(str, fromFront);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //12.MiddleTwo
        [TestCase("string", "ri")]
        [TestCase("code","od")]
        [TestCase("practice","ct")]
        public void ReturnMiddleTwoChars(string str, string expectedResult)
        {
            //Act
            string result = stringexercises.MiddleTwo(str);
            //Assert
            Assert.AreEqual(result,expectedResult);
        }
        //EndsWithLY
        [TestCase ("oddly", true)]
        [TestCase("y",false)]
        [TestCase("oddy",false)]
        public void ReturnTrueIfStrEndsWithLy(string str, bool expectedResult)
        {
            //Act
            bool result = stringexercises.EndsWithLy(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //FrontAndBack
        [TestCase("Hello",2, "Helo")]
        [TestCase("Chocolate", 3, "Choate")]
        [TestCase("Chocolate", 1, "Ce")]
        public void TakeNCharFromFrontAndBack(string str, int n, string expectedResult)
        {
            //Act
            string result = stringexercises.FrontAndBack(str, n);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //15.TakeTwoFromPosition
        [TestCase("java",0,"ja")]
        [TestCase("java", 2, "va")]
        [TestCase("java", 3, "ja")]
        public void ReturnTwoCharsFromPositionN(string str, int n, string expectedResult)
        {
            //Act
            string result = stringexercises.TakeTwoFromPosition(str, n);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //HasBad
        [TestCase("badxx", true)]
        [TestCase("xbadxx",true)]
        [TestCase("xxbadxx",false)]
        public void ReturnTrueIfBadStartsInOneOrTwoindex(string str, bool expectedResult)
        {
            //Act
            bool result = stringexercises.HasBad(str);
            //Assert
            Assert.AreEqual(result, expectedResult);

        }
        //AtFirst
        [TestCase("hello","he")]
        [TestCase("hi", "hi")]
        [TestCase("h", "h@")]
        public void ReturnFirstTwoCharsIfOneUseAtSign(string str, string expectedResult)
        {
            //Act
            string result = stringexercises.AtFirst(str);
            //Assert
            Assert.AreEqual(result, expectedResult);

        }
        //LastChars
        [TestCase("last", "chars","ls")]
        [TestCase("yo", "mama","ya")]
        [TestCase("hi","", "h@")]
        public void ReturnFirstCharOfFirstStringLastCharOfLastString(string a,string b, string expectedResult)
        {
            //Act
            string result = stringexercises.LastChars(a,b);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //ConCat
        [TestCase("abc", "cat", "abcat")]
        [TestCase("dog", "cat", "dogcat")]
        [TestCase("abc", "", "abc")]
        public void ReturnStringsTogetherMinusSameLetter(string a, string b, string expectedResult)
        {
            //Act
            string result = stringexercises.ConCat(a, b);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //SwapLast
        //SwapLast("coding") -> "codign"
        //SwapLast("cat") -> "cta"
        //SwapLast("ab") -> "ba"
        [TestCase("coding","codign")]
        [TestCase("cat", "cta")]
        [TestCase("ab", "ba")]
        public void ReturnSwapLastTwoLetters(string a, string expectedResult)
        {
            //Act
            string result = stringexercises.SwapLast(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //FrontAgain
        [TestCase("edited", true)]
        [TestCase("edit", false)]
        [TestCase("ed", true)]
        public void ReturnTrueIfFirstTwoSameAsLastTwo(string a, bool expectedResult)
        {
            //Act
            bool result = stringexercises.FrontAgain(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //MinCat
        [TestCase("Hello","Hi","loHi")]
        [TestCase("Hello","java","ellojava")]
        [TestCase("java","Hello","javaello")]
        public void ReturnLongStringMinusShortSting(string a, string b, string expectedResult)
        {
            //Act
            string result = stringexercises.MinCat(a,b);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        
        //TweakFront
        [TestCase("Hello","llo")]
        [TestCase("away","aay")]
        [TestCase("abed", "abed")]
        public void ReturnStringLessFirstTwoUnlessAOrB(string a, string expectedResult)
        {
            //Act
            string result = stringexercises.TweakFront(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //StripX
        [TestCase("xHix", "Hi")]
        [TestCase("xHi", "Hi")]
        [TestCase("Hxix", "Hxi")]
        public void ReturnStringLessFirstAndLastX(string a, string expectedResult)
        {
            //Act
            string result = stringexercises.StripX(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        //***************************************************
        //**************START CONDITIONALS********************
        //****************************************************

        //1.AreWeInTrouble
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void BothKidsSmileOrDontSmileReturnTrue(bool aSmile, bool bSmile, bool expectedResult)
        {
            //Act
            bool result = stringexercises.AreWeInTrouble(aSmile, bSmile);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //2.CanSleepIn
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
        public void IfWeekendOrVacationReturnTrue(bool isWeekend, bool isVacation, bool expectedResult)
        {
            //Act
            bool result = stringexercises.CanSleepIn(isWeekend, isVacation);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //3.SumDouble
        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void ReturnSumIntegersIfIntegersSameReturnDoubleSum(int a, int b, int expectedResult)
        {
            //Act
            int result = stringexercises.SumDouble(a, b);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //4.Diff21
        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void ReturnAbsoluteValueAndDoubleIfIntGreaterThanTwentyOne(int a, int expectedResult)
        {
            //Act
            int result = stringexercises.Diff21(a);
            // Assert
            Assert.AreEqual(result, expectedResult);
        }
        //5.ParrotTrouble
        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        [TestCase(true, 21, true)]
        public void IsTalkingTrueBeforeSevenOrAfterTwentyReturnsTrue(bool isTalking, int hour, bool expectedResult)
        {
            //Act 
            bool result = stringexercises.ParrotTrouble(isTalking, hour);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //6.Makes10
        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        [TestCase(10, 9, true)]
        public void IntIsTenOrAddsToBeTenReturnTrue(int a, int b, bool expectedResult)
        {
            //Act
            bool result = stringexercises.Makes10(a, b);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //7.NearHundred
        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]
        [TestCase(205, true)]
        public void ReturnTrueIfIntWithinTenOfHundred(int a, bool expectedResult)
        {
            //Act
            bool result = stringexercises.NearHundred(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //8.PosNeg  
        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-4, -5, true, true)]
        [TestCase(4, -5, true, false)]
        public void ReturnTruePosNegAndTrueAndPosNegFalseOrTrue(int a, int b, bool negative, bool expectedResult)
        {
            //Act
            bool result = stringexercises.PosNeg(a, b, negative);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //9.NotString
        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]
        public void AddNotToFrontIfItsNotThere(string s, string expectedResult)
        {
            //Act
            string result = stringexercises.NotString(s);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //10. MissingChar
        [TestCase("kitten", 1,"ktten")]
        [TestCase("kitten",0,"itten" )]
        [TestCase("kitten", 4,"kittn")]
        public void ReturnStringLessTheN(string a,int num, string expectedResult)
        {
            //Act
            string result = stringexercises.MissingChar(a,num);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //11. Front3
        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at","atatat")]
        public void ReturnFirstThreeChars(string a, string expectedResult)
        {
            //Act
            string result = stringexercises.Front3(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //BackAround
        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        public void ReturnFirstCharOnFrontAndBack(string a, string expectedResult)
        {
            //Act
            string result = stringexercises.BackAround(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //Multiple3Or5
        [TestCase(3,true)]
        [TestCase(10, true)]
        [TestCase(8,false)]
        public void ReturnTrueMultipleOfThreeOrFive(int num, bool expectedResult)
        {
            //Act
            bool result = stringexercises.Multiple3Or5(num);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //StartHi("hi there") -> true
        //StartHi("hi") -> true
        //StartHi("high up") -> false
        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]
        public void ReturnTrueBeginsWithHi(string str, bool expectedResult)
        {
            //Act
            bool result = stringexercises.StartHi(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //IcyHot
        [TestCase(120,-1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2,120, false)]
        public void ReturnTrueOneGreaterThanOneTwentyAndOneLowerThanZero(int num1,int num2, bool expectedResult)
        {
            //Act
            bool result = stringexercises.IcyHot(num1,num2);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //Between10And20
        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]
        public void ReturnTrueIfGreaterThanTenLessThanTwenty(int num1, int num2, bool expectedResult)
        {
            //Act
            bool result = stringexercises.Between10And20(num1, num2);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        //HasTeen
        [TestCase(13, 20,10, true)]
        [TestCase(210, 19, 10, true)]
        [TestCase(20, 10, 12, false)]
        public void ReturnTrueIfGreaterThanThirteenAndLessThanNinteen(int num1, int num2, int num3, bool expectedResult)
        {
            //Act
            bool result = stringexercises.HasTeen(num1, num2, num3);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //SoAlone
        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]
        public void ReturnTrueIfGreaterThanThirteenAndLessThanNinteenButNotBoth(int num1, int num2, bool expectedResult)
        {
            //Act
            bool result = stringexercises.SoAlone(num1, num2);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //RemoveDel
        //RemoveDel("adelbc") -> "abc"
        //RemoveDel("adelHello") -> "aHello"
        //RemoveDel("adedbc") -> "adedbc"
        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]
        public void ReturnStringWithOutDel(string str, string expectedResult)
        {
            //Act
            string result = stringexercises.RemoveDel(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //IxStart
        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]
        public void ReturnTrueIfIxAtIndexOne(string str, bool expectedResult)
        {
            //Act
            bool result = stringexercises.IxStart(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        //StartOz
        [TestCase("ozymandias" , "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]
        public void ReturnZOrO(string str, string  expectedResult)
        {
            //Act
            string  result = stringexercises.StartOz(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //Max
        [TestCase(1,2,3,3)]
        [TestCase(1,3,2,3)]
        [TestCase(3,2,1,3)]
        public void ReturnHighestOfThree(int num1, int num2, int num3, int expectedResult)
        {
            //Act
            int result = stringexercises.Max(num1,num2, num3);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //Closer
        [TestCase(8, 13, 8)]
        [TestCase(13,8,8)]
        [TestCase(13,7,0)]
        public void ReturnClosestToTen(int num1, int num2,  int expectedResult)
        {
            //Act
            int result = stringexercises.Closer(num1, num2);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //EEEEEE
        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]
        public void ReturnTrueIfOneToThreeEs(string str, bool expectedResult)
        {
            //Act
            bool result = stringexercises.GotE(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }


        //EndUp
        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi","HI")]
        public void ReturnLastThreeUpperCase(string str, string  expectedResult)
        {
            //Act
            string result = stringexercises.EndUp(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        //EveryNth
        [TestCase("Miracle",2, "Mrce")]
        [TestCase("abcdefg",2, "aceg")]
        [TestCase("abcdefg",3, "adg")]
        public void ReturnNThChar(string str, int num, string expectedResult)
        {
            //Act
            string result = stringexercises.EveryNth(str,num);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //***********************************************************************
        //********************START LOOPS*************************************
        //******************************************************************
        //1. StringTimes
        [TestCase("Hi",2,"HiHi")]
        [TestCase("Hi",3,"HiHiHi")]
        [TestCase("Hi",1,"Hi")]
        public void RepeatStringXNumberOfTimes(string s, int num, string expectedResult)
        {
            //Act 
            string result = stringexercises.StringTimes(s, num);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        //2.FrontTimes
        [TestCase("Chocolate",2, "ChoCho")]
        [TestCase("Chocolate",3, "ChoChoCho")]
        [TestCase("Abc",3,"AbcAbcAbc")]
        public void RepeatFirstThreeCharXNumberOfTimes(string s, int num, string expectedResult)
        {
            //Act
            string result = stringexercises.FrontTimes(s, num);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //CountXX
        [TestCase ("abcxx", 1)]
        [TestCase ("xxx", 2)]
        [TestCase ("xxxx",3)]
        public void CountNumOfTimesXThenXOccurs(string s, int expectedResult)
        {
            //Act
            int result = stringexercises.CountXX(s);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //DoubleX
        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        public void IfXThenXOccursRreturnTrue(string s, bool expectedResult)
        {
            //Act
            bool result = stringexercises.DoubleX(s);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //EveryOther
        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo","Hello")]
        public void ReturnEverOtherChar(string s, string expectedResult)
        {
            //Act
            string result = stringexercises.EveryOther(s);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //StringSplosion
        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void ReturnStringPlusOnePlusTwoPlusThreePlusFour(string s, string expectedResult)
        {
            //Act
            string result = stringexercises.StringSplosion(s);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //CountLast2
        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx",1)]
        [TestCase("axxxaaxx", 2)]
        public void ReturnNumberOfLastTwo(string s, int expectedResult)
        {
            //Act
            int result = stringexercises.CountLast2(s);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        //Count9
        [TestCase(new int [] {1,2,9},1)]
        [TestCase(new int [] { 1,9,9},2)]
        [TestCase(new int [] { 1,9,9,3,9},3)]
        public void ReturnNumberOfNinesInArray(int[] a, int expectedResult)
        {
            //Act
            int result = stringexercises.Count9(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //ArrayFront9
        [TestCase(new int [] {1,2,9,3,4},true)]
        [TestCase(new int [] { 1,2,3,4,9},false)]
        [TestCase(new int [] {1,2,3,4,5},false)]
        public void ReturnTrueIfOneOfFirstFourAreNine(int[] a, bool expectedResult)
        {
            //Act
            bool result = stringexercises.ArrayFront9(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        //Array123
       
        [TestCase(new int [] { 1,1,2,3,1}, true)]
        [TestCase(new int [] {1,1,2,4,1}, false)]
        [TestCase(new int [] {1,1,2,1,2,3}, true)]
        public void ReturnTrueIfOneTwoThreeSequenceExisits(int[] a, bool expectedResult)
        {
            //Act
            bool result = stringexercises.Array123(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //SubStringMatch
        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc",0)]
        public void ReturnNumOfLenghtTwoSubStings(string str,string str2, int expectedResult)
        {
            //Act
            int result = stringexercises.SubStringMatch(str, str2);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        //StringX
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xxHxix", "xHix")]
        [TestCase("xabxxxcdx", "xabcdx")]
        public void ReturnStringWithNoXsExceptOnEnds(string str, string expectedResult)
        {
            //Act
            string result = stringexercises.StringX(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        //AltPairs
        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]
        public void ReturnAltTwoChar(string str, string expectedResult)
        {
            //Act
            string result = stringexercises.AltPairs(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //DoNotYak
        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        public void ReturnStringWithNoYak(string str, string expectedResult)
        {
            //Act
            string result = stringexercises.DoNotYak(str);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        //Array667
        [TestCase(new int [] {6,6,2},1)]
        [TestCase(new int [] {6,6,2,6},1)]
        [TestCase(new int [] {6,7,2,6},1)]
        public void ReturnNumerOfTimesSixSixOrSixSeven(int[] a, int expectedResult)
        {
            //Act
            int result = stringexercises.Array667(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        //NoTripples
        [TestCase(new int [] {1,1,2,2,1},true)]
        [TestCase(new int [] {1,1,2,2,2,1},false)]
        [TestCase(new int [] {1,1,1,2,2,2,1},false)]
        public void ReturnTrueifNoTripples(int[] a, bool expectedResult)
        {
            //Act
            bool result = stringexercises.NoTriples(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //17. Pattern51
        [TestCase(new int[] { 1, 2, 7, 1}, true)]
        [TestCase(new int [] { 1, 2, 8, 1}, false)]
        [TestCase(new int [] { 2, 7, 1}, true)]
        public void ReturnTrueifPatternTwoSevenOne(int[] a, bool expectedResult)
        {
            //Act
            bool result = stringexercises.Pattern51(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        //***********************************************************************
        //*****************Start Logic***************************************
        //********************************************************************
        //1. GreatParty

        //2. CanHazTable
        [TestCase(5, 10, 2)]
        [TestCase(2, 5, 0)]
        [TestCase(5, 5, 1)]
        public void CompareOnScaleReturnOneTwoOrZero(int a, int b, int expectedresult)
        {
            //Act
            int result = stringexercises.CanHazTable(a, b);
            //Assert
            Assert.AreEqual(result, expectedresult);
        }
        //3. PlayOutSide
        [TestCase(70,false,true)]
        [TestCase(95,false,false)]
        [TestCase(95,true,true)]
        public void TempOfSixtyToNinetyOrSixtyToHundredReturnTrue(int temp, bool isSummer, bool expectedResult)
        {
            //Act
            bool result = stringexercises.PlayOutside(temp, isSummer);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //4. CaughtSpeeding
        [TestCase(60,false, 0)]
        [TestCase(65,false,1)]
        [TestCase(65,true,0)]
        public void TrueIsLessThanSixtyFiveIsZeroSixtySixToeightyFiveIsOneOverEightySixIsTwo(int speed, bool isBirthday,
            int expectedResult)
        {
            //Act
            int result = stringexercises.CaughtSpeeding(speed, isBirthday);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //5. SkipSum
        [TestCase(3,4,7)]
        [TestCase(9,4,20)]
        [TestCase(10,11,21)]
        public void SumNumsSkipSumOfTenToNinteen(int num, int num2, int expectedResult)
        {
            //Act
            int result = stringexercises.SkipSum(num, num2);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //6. AlarmClock
        [TestCase(1,false,"7:00")]
        [TestCase(5,false,"7:00")]
        [TestCase(0,false,"10:00")]
        public void WeekdaySevenWeekendTenVacationTenAndOff(int day, bool vacation, string expectedResult)
        {
            //Act 
            string result = stringexercises.AlarmClock(day, vacation);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //7. LoveSix
        [TestCase(6,4,true)]
        [TestCase(4,5,false)]
        [TestCase(1,5,true)]
        public void ReturnTrueIfSixSumSixOrDifferenceSix(int a, int b, bool expectedResult)
        {
            //Act
            bool result = stringexercises.LoveSix(a, b);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //8. InRange
        [TestCase(5,false,true)]
        [TestCase(11,false,false)]
        [TestCase(11,true,true)]
        public void ReturnTrueOneToTenAndLessThanOneAndGreaterThanTen(int a, bool outsideMode, bool expectedResult)
        {
            //Act
            bool result = stringexercises.InRange(a, outsideMode);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //9. SpecialEleven
        [TestCase(22,true)]
        [TestCase(23,true)]
        [TestCase(24, false)]
        public void MutilpeOfElevenAndMutipleOfElevenPlusOneReturnTrue(int n, bool expectedResult)
        {
            //Act
            bool result = stringexercises.SpecialEleven(n);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //10. Mod20
        [TestCase(20,false)]
        [TestCase(21,true)]
        [TestCase(22,true)]
        public void TrueIfOneOrTwoMorethanMutipleOfTwenty(int a, bool expectedResult)
        {
            //Act
            bool result = stringexercises.Mod20(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //11. Mod35
        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(15, false)]
        public void ReturnTrueMutipleOfFiveOrThreeNotBoth(int a, bool expectedResult)
        {
            //Act
            bool result = stringexercises.Mod35(a);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //12. AnswerCell
        [TestCase(false, false, false,true)]
        [TestCase(false, false, true, false)]
        [TestCase(true, false, false, false)]
        public void ReturnTrueIfNotMornOrIsMornAndIsMomFalseIfAsleep(bool isMorning, bool isMom, bool isAsleep,
            bool expectedResult)
        {
            //Act
            bool result = stringexercises.AnswerCell(isMorning, isMom, isAsleep);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //13. TwoIsOne
        [TestCase(1, 2, 3, true)]
        [TestCase(3, 1, 2, true)]
        [TestCase(3, 2, 2, false)]
        public void ReturnTrueIfTwoCanEqualOne(int a, int b, int c, bool expectedResult)
        {
            //Act
            bool result = stringexercises.TwoIsOne(a, b, c);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //14. AreInOrder
        [TestCase(1, 2, 4, false, true)]
        [TestCase(1, 2, 1, false, false)]
        [TestCase(1, 1, 2, true, true)]
        public void NotBOkReturnTrueIfBGreaterThanAAndCGreaterThanBOrCGreaterThanB(int a, int b, int c, bool bOk,
            bool expectedResult)
        {
            //Act
            bool result = stringexercises.AreInOrder(a, b, c, bOk);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //15. InOrderEqual
        [TestCase(2, 5, 11, false, true)]
        [TestCase(5, 7, 6, false, false)]
        [TestCase(5, 5, 7, true, true)]
        public void TrueNotEqualOkAndBGreaterThanAAndBGreaterThanC(int a, int b, int c, bool equalOk,
            bool expectedResult)
        {
            //Act
            bool result = stringexercises.InOrderEqual(a, b, c, equalOk);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //16. LastDigit
        [TestCase(23,19,13,true)]
        [TestCase(23,19,12, false)]
        [TestCase(23,19,3, true)]
        public void TrueIfSecondDigitMatches(int a, int b, int c, bool expectedResult)
        {
            //Act
            bool result = stringexercises.LastDigit(a, b, c);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        //17. RollDice
        [TestCase(2,3,true,5)]
        [TestCase(3,3,true,7)]
        [TestCase(3,3,false,6)]
        public void ReturnSumNoDoublesCantBeSameNumAddOneReturnSum(int a, int b, bool noDoubles, int expectedResult)
        {
            //Act
            int result = stringexercises.RollDice(a, b, noDoubles);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }



    }
}
