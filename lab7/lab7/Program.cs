using System;
using System.Text.RegularExpressions;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "drob : 123.342";
            string s = "numerator: 9 / 7de23nominator: 8/ fdsa:4";
            Drob d3 = new Drob(s);
            Drob d4 = new Drob(s1, '.');
            Drob d5 = new Drob(s);
            Console.WriteLine($"{d3.n}->{d3.M}");
            Console.WriteLine($"{d4.n}->{d4.M}");
            Console.WriteLine(d4.n/Convert.ToDouble(d4.M));   
            // d3 = Drob.GetFromStr(s);
            /*Drob d1 = new Drob();
            Drob d2 = new Drob();
            Drob sol = new Drob();
          
            d1.n = 2;
            d1.M = 3;
            d1.Output(3);
            d2.n = 1;
            d2.M = 4;
            sol = d1 + d2;
            
            Console.WriteLine($"{d1.n}->{d1.M}");
            d1.Reduction();
            Console.WriteLine($"{d1.n}->{d1.M}");
            
            
            Console.WriteLine(d1.CompareTo(d2));
            int resOfComp = d1.CompareTo(d2);
            if (resOfComp == 0)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                if (resOfComp == 1)
                {
                    Console.WriteLine("The first is bigger");
                }
                else
                {
                    Console.WriteLine("The second is bigger");
                }
            }
            */


            //string[] names = s.Split("/");
            //ArrayList data = new ArrayList();

            /*if (match.Success)
            {
                Console.WriteLine("Number found: " + match.Value.Split(":")[1]);
                if (i == 0)
                {
                    this.n = Convert.ToInt32(match.Value.Split(":")[1]);
                }
                else
                {
                    this._m =  Convert.ToInt32(match.Value.Split(":")[1]);
                }
            }*/
            //}
            
  
        }
    }
}
/**
- [ ]  Реализовать метод для получения объекта класса по строковому представлению из разных форматов (по желанию использовать для этого регулярные выражения).

- [ ] и порядкового сравнения. 
- [ ] Перекрыть явные или неявные операторы преобразования к типам целых и действительных чисел.

 */