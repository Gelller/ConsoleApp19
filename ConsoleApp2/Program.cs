using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            TestClass testClass = new TestClass(3, 5);
            TestClass testClass2 = new TestClass(4, 7);

            var newNumber = testClass + testClass2;
            var newNumber2 = testClass - testClass2;
            var newNumber3 = testClass * testClass2;
            var newNumber4 = testClass / testClass2;
            var newNumber5 = testClass == testClass2;
            var newNumber6 = testClass != testClass2;
            var newNumber7 = testClass > testClass2;
            var newNumber8 = testClass < testClass2;
            var newNumber9 = testClass >= testClass2;
            var newNumber10 = testClass <= testClass2;

            var newNumber11 = testClass++;
            var newNumber12 = testClass2--;

            float newFloat = (float)newNumber;
            int newInt=(int)newNumber;
            string newString = newNumber.ToString();

            Console.ReadLine();
        }
    }

    public class TestClass
    {
        private int _numerator;
        private int _denominator;

        public int Numerator
        {
            get 
            { 
                return _numerator; 
            }
            set
            {
                _numerator = value;
            }
        }

        public int Denominator
        {
            get 
            { 
                return _denominator; 
            }
            set
            {
                _denominator = value;
            }
        }

        public TestClass(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;

            ReduceToLowestTerms();
        }

        private void ReduceToLowestTerms()
        {
            int greatestCommonDivisor = TestClass.GetGCD(_numerator, _denominator);
            _numerator /= greatestCommonDivisor;
            _denominator /= greatestCommonDivisor;
        }

        private static int GetGCD(int term1, int term2)
        {
            if (term2 == 0)
                return term1;
            else
                return GetGCD(term2, term1 % term2);
        }

        public static TestClass operator +(TestClass numberOne, TestClass numberTwo)
        {
            return new TestClass((numberOne.Numerator * numberTwo.Denominator)
                + (numberTwo.Numerator * numberOne.Denominator), numberOne.Denominator * numberTwo.Denominator);

        }

        public static TestClass operator -(TestClass numberOne, TestClass numberTwo)
        {
            return new TestClass((numberOne.Numerator * numberTwo.Denominator)
                - (numberTwo.Numerator * numberOne.Denominator), numberOne.Denominator * numberTwo.Denominator);
        }

        public static TestClass operator *(TestClass numberOne, TestClass numberTwo)
        {
            return new TestClass(numberOne.Numerator * numberTwo.Numerator, numberOne.Denominator * numberTwo.Denominator);
        }

        public static TestClass operator /(TestClass numberOne, TestClass numberTwo)
        {
            return new TestClass(numberOne.Numerator * numberTwo.Denominator, numberOne.Denominator * numberTwo.Numerator);
        }

        public static TestClass operator ++(TestClass numberOne)
        {
            return new TestClass(numberOne.Numerator++, numberOne.Denominator++);
        }

        public static TestClass operator --(TestClass numberOne)
        {
            return new TestClass(numberOne.Numerator--, numberOne.Denominator--);
        }

        public static bool operator ==(TestClass numberOne, TestClass numberTwo)
        {    
            if (NotNull(numberOne, numberTwo))
            {
                throw new ArgumentException("The denominator or numerator must be non-zero.");
            }

            if ((numberOne - numberTwo).Numerator == 0)
            {
                return true;
            }
            else 
               return false;       
          
        }

        public static bool operator !=(TestClass numberOne, TestClass numberTwo)
        {
            if (NotNull(numberOne, numberTwo))
            {
                throw new ArgumentException("The denominator or numerator must be non-zero.");
            }

            if ((numberOne - numberTwo).Numerator != 0)
            {
                return true;
            }
            else
                return false;
        }

        private static bool NotNull(TestClass numberOne, TestClass numberTwo)
        {
            bool numberOneNull = ReferenceEquals(numberOne.Numerator, null);
            bool numberTwoNull = ReferenceEquals(numberTwo.Denominator, null);

            if (numberOneNull != numberTwoNull && numberOneNull == true)
            {
                return true;
            }
            else
                return false;

        }

        public static bool operator >(TestClass numberOne, TestClass numberTwo)
        {
            if (NotNull(numberOne, numberTwo))
            {
                throw new ArgumentException("The denominator or numerator must be non-zero.");
            }
            if ((numberOne - numberTwo).Numerator > 0)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator <(TestClass numberOne, TestClass numberTwo)
        {
            if (NotNull(numberOne, numberTwo))
            {
                throw new ArgumentException("The denominator or numerator must be non-zero.");
            }
            if ((numberOne - numberTwo).Numerator < 0)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator >=(TestClass numberOne, TestClass numberTwo)
        {
            if (NotNull(numberOne, numberTwo))
            {
                throw new ArgumentException("The denominator or numerator must be non-zero.");
            }
            if (!(numberOne < numberTwo))
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator <=(TestClass numberOne, TestClass numberTwo)
        {
            if (NotNull(numberOne, numberTwo))
            {
                throw new ArgumentException("The denominator or numerator must be non-zero.");
            }
            if (!(numberOne > numberTwo))
            {
                return true;
            }
            else
                return false;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", Numerator, Denominator);
        }

        public static implicit operator float(TestClass numberOne)
        {
            return (float)numberOne.Numerator / (float)numberOne.Denominator;
        }

        public static implicit operator int(TestClass numberOne)
        {
            return numberOne.Numerator / numberOne.Denominator;
        }
    }
}
