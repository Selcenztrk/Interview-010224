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
                this.numerator = numerator/value;
                this.denominator = denominator/value;

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

            public static RationalNumber Add(RationalNumber num1, RationalNumber num2) {
               RationalNumber result = new RationalNumber();
                result.numerator = (num1.numerator*num2.denominator) + (num2.numerator*num1.denominator);
                result.denominator = num1.denominator * num2.denominator;
                return result;
            }

            public override string ToString()
            {
                return this.numerator + "/" + this.denominator;
            }

           public static RationalNumber Divide(RationalNumber num1, RationalNumber num2) {

                RationalNumber result = new RationalNumber();
                result.numerator = num1.numerator * num2.denominator;
                result.denominator = num1.denominator * num2.numerator;

                int value = GCD(result.numerator, result.denominator);

                result.numerator = result.numerator / value;
                result.denominator = result.denominator / value;
                return result;
            }
            public static RationalNumber Multiply(RationalNumber num1, RationalNumber num2) {

                RationalNumber result = new RationalNumber();
                result.numerator = num1.numerator*num2.numerator;
                result.denominator = num1.denominator*num2.denominator;

                int value = GCD(result.numerator, result.denominator);

                result.numerator = result.numerator/value;
                result.denominator = result.denominator/value;  
                return result;
            }
            int Substract() { return 0;}

        }
        static void Main(string[] args)
        {
           RationalNumber num1 = new RationalNumber(4,3);
           RationalNumber num2 = new RationalNumber(6,2);

            var num3 = RationalNumber.Add(num1, num2);


            Console.WriteLine("Result:" + num3);

            // var addition = num1 + num2;
          //  var num4 = num1 + 8

      

            

            
        }
    }
}