using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wiladeisFunqciebi
{
   public class MyFraction
    {

       private int numenator { get; set; }
       private int denominator { get; set; }

        public MyFraction(int numenator, int denominator)
        {
            this.numenator = numenator;
            this.denominator = denominator;
        }

        public static MyFraction operator *(MyFraction f1, MyFraction f2)
        {

            var x1 = f1.numenator * f2.numenator;
            var x2 = f1.denominator * f2.denominator;
            return new MyFraction(x1, x2);
        }

        public static implicit operator MyFraction(string input)
        {

           var inputs =  input.Split("|");
            int.Parse(inputs[0]);
            int.Parse(inputs[1]);
            return new MyFraction(int.Parse(inputs[0]),int.Parse(inputs[1]));
        }

        public override string ToString()
        {
            return $"{this.numenator}|{this.denominator}";
        }
    }

}
