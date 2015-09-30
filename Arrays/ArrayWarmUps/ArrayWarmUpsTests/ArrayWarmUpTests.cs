using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayWarmUps;
using NUnit;
using NUnit.Framework;
using NUnit.Framework.Constraints;


namespace ArrayWarmUpsTests
{
    [TestFixture]
    public class ArrayWarmUpTests
    {
        private ArrayExercises arrayEx;

        [SetUp]
        public void BeforeEachTest()
        {
            //Arrange
            arrayEx = new ArrayExercises();
        }

        //1.FirstLast6

        [TestCase(new int[] { 1, 2, 6 }, true)]
        [TestCase(new int[] { 6, 1, 2, 3 }, true)]
        [TestCase(new[] { 13, 6, 1, 2, 3 }, false)]
        public void ReturnTrueIfSixFirstOrLast(int[] a, bool expextedResult)
        {
            //Act
            bool result = arrayEx.FirstLast6(a);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }

        //2.SameFirstLast

        [TestCase(new int[] { 1, 2, 3 }, false)]
        [TestCase(new int[] { 1, 2, 3, 1 }, true)]
        [TestCase(new[] { 1, 2, 1 }, true)]
        public void ReturnTrueIfFirstAndLastAreSame(int[] a, bool expextedResult)
        {
            //Act
            bool result = arrayEx.SameFirstLast(a);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }

        //3. MakePi
        //MakePi(3) -> {3, 1, 4}
        [TestCase(3, new int[] { 3, 1, 4 })]
        [TestCase(4, new int[] { 3, 1, 4, 1 })]

        public void ReturnPI(int a, int[] expextedResult)
        {
            //Act
            int[] result = arrayEx.MakePi(a);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }

        //4.CommonEnd
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3 }, true)]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 7, 3, 2 }, false)]
        [TestCase(new[] { 1, 2, 1 }, new int[] { 1, 3 }, true)]
        public void ReturnTrueIfLastAreSame(int[] a, int[] b, bool expextedResult)
        {
            //Act
            bool result = arrayEx.CommonEnd(a, b);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }

        //5.Sum
        [TestCase(new int[] { 1, 2, 3 }, 6)]
        [TestCase(new int[] { 5, 11, 2 }, 18)]
        [TestCase(new[] { 7, 0, 0, }, 7)]
        public void ReturnIntOfSum(int[] a, int expextedResult)
        {
            //Act
            int result = arrayEx.Sum(a);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }

        //6.RotateLeft
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 2, 3, 1 })]
        [TestCase(new int[] { 5, 11, 9 }, new int[] { 11, 9, 5 })]
        [TestCase(new[] { 7, 0, 0, }, new int[] { 0, 0, 7 })]
        public void ReturnArrayRotatedLeft(int[] a, int[] expextedResult)
        {
            //Act
            int[] result = arrayEx.RotateLeft(a);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }

        //7. Reverse

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 4, 5, 6 }, new int[] { 6, 5, 4 })]

        public void ReturnArrayReversed(int[] a, int[] expextedResult)
        {
            //Act
            int[] result = arrayEx.Reverse(a);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }


        //8. HigherWins
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 3, 3 })]
        [TestCase(new int[] { 11, 5, 9 }, new int[] { 11, 11, 11 })]
        [TestCase(new int[] { 2, 11, 3 }, new int[] { 3, 3, 3 })]

        public void ReturnArrayOfHighestNumber(int[] a, int[] expextedResult)
        {
            //Act
            int[] result = arrayEx.HigherWins(a);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }

        //9, GetMiddle
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, }, new int[] { 2, 5 })]
        [TestCase(new int[] { 7, 7, 7 }, new int[] { 3, 8, 8 }, new int[] { 7, 8 })]
        [TestCase(new int[] { 5, 2, 9 }, new int[] { 1, 4, 5 }, new int[] { 2, 4 })]

        public void ReturnArrayOfTwoMiddleElements(int[] a, int[] b, int[] expextedResult)
        {
            //Act
            int[] result = arrayEx.GetMiddle(a, b);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }

        //10.HasEven
        [TestCase(new int[] { 2, 5 }, true)]
        [TestCase(new int[] { 4, 3 }, true)]
        [TestCase(new int[] { 7, 5 }, false)]

        public void ReturnTrueIfEvenNumExists(int[] a, bool expextedResult)
        {
            //Act
            bool result = arrayEx.HasEven(a);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }

        //11.KeepLast
        [TestCase(new int[] { 4, 5, 6 }, new int[] { 0, 0, 0, 0, 0, 6 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 0, 0, 0, 2 })]
        [TestCase(new int[] { 3 }, new int[] { 0, 3 })]

        public void ReturnArrayDoubleSizeWithLastNum(int[] a, int[] expextedResult)
        {
            //Act
            int[] result = arrayEx.KeepLast(a);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }

        //Double23
        [TestCase(new int[] { 2, 2, 3 }, true)]
        [TestCase(new int[] { 3, 4, 5, 3 }, true)]
        [TestCase(new int[] { 2, 3, 2, 2 }, false)]

        public void ReturnTrueIfAppearsTwice(int[] a, bool expextedResult)
        {
            //Act
            bool result = arrayEx.Double23(a);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }

        //Fix23
        [TestCase(new int[] { 1, 2, 3 }, new int [] {1, 2, 0})]
        [TestCase(new int[] { 2, 3, 5 }, new int[] { 2, 0, 5 })]
        [TestCase(new int[] { 1, 2, 1 }, new int[] { 1, 2, 1 })]

        public void ReturnArrayWithZeroNotThree(int[] a, int [] expextedResult)
        {
            //Act
            int [] result = arrayEx.Fix23(a);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }
        //Unlucky1
        [TestCase(new int[] { 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 2, 1, 3, 4, 5 }, true)]
        [TestCase(new int[] { 1, 1, 1 }, false)]

        public void ReturnIfUnlucky(int[] a, bool expextedResult)
        {
            //Act
         bool result = arrayEx.Unlucky1(a);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }

        //Make2
        [TestCase(new int[] {4, 5 }, new int [] {1, 2, 3}, new int [] {4,5})]
        [TestCase(new int[] { 4}, new int[] { 1, 2, 3 }, new int[] { 4, 1 })]
        [TestCase(new int[] {  }, new int[] { 1, 2 }, new int[] { 1, 2 })]

        public void ReturnArrayOfTwo(int[] a, int [] b, int [] expextedResult)
        {
            //Act
            int[] result = arrayEx.Make2(a,b);

            //Assert
            Assert.AreEqual(expextedResult, result);
        }





    }
}
