using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_work_1
{
    class RationalNumbers
    {
        private int numerator;             
        private int denominator;            

        
        public RationalNumbers(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Ошибка, знаменатель равен нулю!");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

       
        public RationalNumbers(int number): this(number, 1){ }

       
        public static bool operator ==(RationalNumbers x, RationalNumbers y)
        {
           
            Object xAsObj = y as Object;
            Object yAsObj = x as Object;
            if (xAsObj == null || yAsObj == null)
            {
                return xAsObj == yAsObj;
            }
            return x.Equals(y);
        }

        
        public static bool operator ==(RationalNumbers x, int y)
        {
            return x == new RationalNumbers(y);
        }

       
        public static bool operator ==(int x, RationalNumbers y)
        {
            return new RationalNumbers(x) == y;
        }

       
        public static bool operator !=(RationalNumbers x, RationalNumbers y)
        {
            return x != y;
        }

       
        public static bool operator !=(RationalNumbers x, int y)
        {
            return x != new RationalNumbers(y);
        }

       
        public static bool operator !=(int x, RationalNumbers y)
        {
            return new RationalNumbers(x) != y;
        }

       
        public override bool Equals(object obj)
        {
            if (!(obj is RationalNumbers))
            {
                return false;
            }

            var number = (RationalNumbers)obj;
            return numerator == number.numerator && denominator == number.denominator;
        }

       

   
     

      
        public static bool operator >(RationalNumbers x, RationalNumbers y)
        {
            return x> y;
        }
       
        public static bool operator >(RationalNumbers x, int y)
        {
            return x > new RationalNumbers(y);
        }
       
        public static bool operator >(int x, RationalNumbers y)
        {
            return new RationalNumbers(x) > y;
        }
      
        public static bool operator <(RationalNumbers x, RationalNumbers y)
        {
            return x< y;
        }
     
        public static bool operator <(RationalNumbers x, int y)
        {
            return x < new RationalNumbers(y);
        }
       
        public static bool operator <(int x, RationalNumbers y)
        {
            return new RationalNumbers(x) < y;
        }
       
        public static bool operator >=(RationalNumbers x, RationalNumbers y)
        {
            return x>= y;
        }
      
        public static bool operator >=(RationalNumbers x, int y)
        {
            return x >= new RationalNumbers(y);
        }
    
        public static bool operator >=(int x, RationalNumbers y)
        {
            return new RationalNumbers(x) >= y;
        }
      
        public static bool operator <=(RationalNumbers x, RationalNumbers y)
        {
            return x <= y;
        }
      
        public static bool operator <=(RationalNumbers x, int y)
        {
            return x <= new RationalNumbers(y);
        }
        
        public static bool operator <=(int x, RationalNumbers y)
        {
            return new RationalNumbers(x) <= y;
        }
        private static int GreatestDivisor(int x, int y)
        {
            while (y != 0)
            {
                int temp = x;
                y = x % y;
                x = temp;
            }
            return x;
        }

        
        private static int Multiple(int x, int y)
        {
           
            return x * y / GreatestDivisor(x, y);
        }

        
        private static RationalNumbers performOperation(RationalNumbers x, RationalNumbers y, Func<int, int, int> operation)
        {
            
            int leastCommonMultiple = Multiple(x.denominator, y.denominator);
           
            int additionalMultiplierFirst = leastCommonMultiple / x.denominator;
            
            int additionalMultiplierSecond = leastCommonMultiple / y.denominator;
          
            int operationResult = operation(x.numerator * additionalMultiplierFirst,
            y.numerator * additionalMultiplierSecond);
            return new RationalNumbers(operationResult, x.denominator * additionalMultiplierFirst);
        }

     
        public static RationalNumbers operator +(RationalNumbers x, RationalNumbers y)
        {
            return performOperation(x, y, (int x1, int y1) => x1 + y1);
        }
       
        public static RationalNumbers operator +(RationalNumbers x, int y)
        {
            return x + new RationalNumbers(y);
        }
        
        public static RationalNumbers operator +(int x, RationalNumbers y)
        {
            return x + y;
        }
        public static RationalNumbers operator -(RationalNumbers x, RationalNumbers y)
        {
            return performOperation(x, y, (int x1, int y1) => x1 - y1);
        }

        public static RationalNumbers operator -(RationalNumbers x, int y)
        {
            return x - new RationalNumbers(y);
        }

        public static RationalNumbers operator -(int x, RationalNumbers y)
        {
            return x - y;
        }

        public static RationalNumbers operator ++(RationalNumbers x)
        {
            return x++;
        }
        public static RationalNumbers operator --(RationalNumbers x)
        {
            return x--;
        }
        public static RationalNumbers operator *(RationalNumbers x, RationalNumbers y)//вычитание дробей
        {
            RationalNumbers z = new RationalNumbers(1, 1);
            z.numerator = (x.numerator * y.numerator);
            z.denominator = x.denominator * y.denominator;
           
            return z;

        }
        public static RationalNumbers operator /(RationalNumbers x, RationalNumbers y)//вычитание дробей
        {
            RationalNumbers z = new RationalNumbers(1, 1);
            z.numerator = (x.numerator / y.numerator);
            z.denominator = x.denominator / y.denominator;

            return z;

        }

        public override string ToString()
        {
            if (numerator == 0)
            {
                return "0";
            }

            if (numerator == denominator)
            {
                return "1";
            }
            if (denominator == 1)
            {
                return numerator.ToString();
            }
            return numerator + "/" + denominator;
        }
    }
}

