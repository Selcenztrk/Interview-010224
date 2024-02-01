using System.ComponentModel.DataAnnotations;

namespace Sestek3
{
    internal class Program
    {
        class RationalNumber
        {
            int numerator;
            int denominator;

            public RationalNumber() { }
            public RationalNumber(int numerator, int denominator)
            {
                int value = GCD(numerator, denominator);
                this.numerator = numerator / value;
                this.denominator = denominator / value;
            }
            public override string ToString()
            {
                return this.numerator + "/" + this.denominator;
            }

            static int GCD(int num1, int num2)
            {
                int Remainder;

                while (num2 != 0)
                {
                    Remainder = num1 % num2;
                    num1 = num2;
                    num2 = Remainder;
                }
                return num1;
            }

            static RationalNumber Simplification(RationalNumber num, int value)
            {
                num.numerator = num.numerator / value;
                num.denominator = num.denominator / value;
                return num;
            }

            public static RationalNumber Add(RationalNumber num1, RationalNumber num2)
            {
                return new RationalNumber((num1.numerator * num2.denominator) + (num2.numerator * num1.denominator), (num1.denominator * num2.denominator));
            }

            public static RationalNumber Substract(RationalNumber num1, RationalNumber num2)
            {
                return new RationalNumber((num1.numerator * num2.denominator) - (num2.numerator * num1.denominator), num1.denominator * num2.denominator);
            }

            public static RationalNumber Multiply(RationalNumber num1, RationalNumber num2)
            {
                RationalNumber result = new RationalNumber(num1.numerator * num2.numerator, num1.denominator * num2.denominator);
                return Simplification(result, GCD(result.numerator, result.denominator));
            }

            public static RationalNumber Divide(RationalNumber num1, RationalNumber num2)
            {
                RationalNumber result = new RationalNumber((num1.numerator * num2.denominator), (num1.denominator * num2.numerator));
                return Simplification(result, GCD(result.numerator, result.denominator));
            }

            public static RationalNumber operator +(RationalNumber num1, RationalNumber num2)
            {
                return new RationalNumber((num1.numerator * num2.denominator) + (num2.numerator * num1.denominator), (num1.denominator * num2.denominator));
            }

            public static RationalNumber operator -(RationalNumber num1, RationalNumber num2)
            {
                return new RationalNumber((num1.numerator * num2.denominator) - (num2.numerator * num1.denominator), num1.denominator * num2.denominator);
            }

            public static RationalNumber operator *(RationalNumber num1, RationalNumber num2)
            {
                RationalNumber result = new RationalNumber(num1.numerator * num2.numerator, num1.denominator * num2.denominator);
                return Simplification(result, GCD(result.numerator, result.denominator));
            }
            public static RationalNumber operator /(RationalNumber num1, RationalNumber num2)
            {
                RationalNumber result = new RationalNumber((num1.numerator * num2.denominator), (num1.denominator * num2.numerator));
                return Simplification(result, GCD(result.numerator, result.denominator));
            }

        }

        static void Main(string[] args)
        {
            RationalNumber num1 = new RationalNumber(4, 3);
            RationalNumber num2 = new RationalNumber(6, 2);

            //var numAdd = RationalNumber.Add(num1, num2);
            //var numSubs = RationalNumber.Substract(num1, num2);
            //var numMulti = RationalNumber.Multiply(num1, num2);
            //var numDiv = RationalNumber.Divide(num1, num2);

            //Console.WriteLine("Add Result:" + numAdd);
            //Console.WriteLine("Sub Result:" + numSubs);
            //Console.WriteLine("Multiply Result:" + numMulti);
            //Console.WriteLine("Divide Result:" + numDiv);
         
            var addition = num1 + num2;
            var subtractition = num1 - num2;
            var multi = num1 * num2;
            var divide = num1 / num2;

            Console.WriteLine(addition);
            Console.WriteLine(subtractition);
            Console.WriteLine(multi);
            Console.WriteLine(divide);

            //  var num4 = num1 + 8
            Console.ReadKey();
        }
    }
}