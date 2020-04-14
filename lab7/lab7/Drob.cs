using System;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Collections;

namespace lab7
{
  

    public class Drob:IComparable
    {
        public int n ;
        private int _m ;

        public Drob()
        {
        }

        public Drob(string s)
        {
            string[] names = s.Split("/");
            //ArrayList data = new ArrayList();
            Regex regex = new Regex(": [0-9]+");
            for (int i = 0; i < 2; i++)
            {
                Match match = regex.Match(names[i]);
                if (match.Success)
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
                }else
                {
                    Console.WriteLine("Invalid data!");   
                }
            }
        }

        public Drob(string s, char ch)
        {
            Regex regex = new Regex(": [0-9]+[,.][0-9]+");
            Match match = regex.Match(s);
            if (match.Success)
            {
             string temp = match.Value.Split(":")[1];
             int lenFromDot = temp.Split(".")[1].Length;
             double a = Convert.ToDouble(match.Value.Split(":")[1]);
             Console.WriteLine("Number found: " + a);
                
                    //Console.WriteLine("Number found: " + Convert.ToDouble(Convert.ToInt32(a)));
                    //Console.WriteLine("Number found: " + (a-Convert.ToInt32(a)));

                
                //Console.WriteLine("Number found: " + Convert.ToDouble(match.Value.Split(":")[1]));
                
                this.n = Convert.ToInt32(Convert.ToDouble(match.Value.Split(":")[1])*Convert.ToInt32(Math.Pow(10,lenFromDot)));
                this._m = Convert.ToInt32(Math.Pow(10,lenFromDot));
               
                
            }
            else
            {
             Console.WriteLine("Invalid data!");   
             return;
            }

        }

        public int M
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error  m ");
                    return;
                }
                else
                {
                    _m = value;
                }
            }
            get { return _m; }
        }
        
        public int gcd(int x, int y)
        {
            while (y != 0)
            {
                int tmp = x % y;
                x = y;
                y = tmp;
            }

            return x;
        }

        public static implicit operator double(Drob d) => (double)d.n/(double)d._m;
        public static implicit operator decimal(Drob d) => (decimal)d.n/(decimal)d._m;
       // public override string ToString() => $"{d.n/(decimal)d._m}";

        
        public static Drob operator +(Drob d1, Drob d2)
        {
            Drob res = new Drob();
            res.n = (d1.n*d2._m)+(d1._m*d2.n);
            res.M = (d1._m * d2._m);
            return res;
        }
        
        public static Drob operator -(Drob d1, Drob d2)
        {
            Drob res = new Drob();
            res.n = (d1.n*d2._m)-(d1._m*d2.n);
            res.M = (d1._m * d2._m);
            return res;
        }
        
        public static Drob operator *(Drob d1, Drob d2)
        {
            Drob res = new Drob();
            res.n = (d1.n*d2.n);
            res.M = (d1._m * d2._m);
            return res;
        }
        
        public static Drob operator /(Drob d1, Drob d2)
        {
            Drob res = new Drob();
            res.n = (d1.n*d2._m);
            res.M = (d1._m * d2.n);
            return res;
        }

        public static bool operator ==(Drob d1, Drob d2)
        {
            if (d1.n == d2.n && d1._m == d2._m)
            {
                return true;
            }

            return false;
            // else
            //{
            ///reduct
            //}
        }
        
        public static bool operator !=(Drob d1, Drob d2)
        {
            if (d1.n == d2.n && d1._m == d2._m)
            {
                return true;
            }
            else
            {
                d1.Reduction();
                d2.Reduction();
            }

            return false;
        }

        public void Reduction()
        {
            
            int gcd = this.gcd(this._m, this.n);
            if (gcd != 0)
            {
                this.n /= gcd;
                this._m /= gcd;
            }
        }
        
        
        public void Output(int command) {
            Console.WriteLine("1)num/den   2)reduced  3)with dot ");
            switch (command)
            {
                case 1 :
                    Console.WriteLine($"numerator: {this.n} / denominator: {this._m}");
                    break;
                case 2 :
                    this.Reduction();
                    Console.WriteLine($"numerator: {this.n} / denominator: {this._m}");
                    break;
                case 3 :
                    decimal c = this.n;
                    decimal d = this._m;
                    Console.WriteLine($"drob: {(decimal)this.n/this._m}");
                    break;
            }
        }

        public bool CompareByOrder(Drob b)
        {
            bool flag = false;
            if (this.n == b.n)
            {
                if (this._m == b._m)
                {
                    flag = true;
                }
            }

            return flag;
        }

        public int CompareTo(object obj)

        {
            Drob other = (Drob)obj;
            int res = (this.n * other._m) - (other.n * this._m);
            if (res>0) return 1;
            if (res<0) return -1;
            return 0;
        }

        public static Drob GetFromStr(string s)
        {
            Drob res = new Drob();
            string[] names = s.Split("/");
            //ArrayList data = new ArrayList();
            Regex regex = new Regex(": [0-9]+");
            for (int i = 0; i < 2; i++)
            {
                Match match = regex.Match(names[i]);
                if (match.Success)
                {
                    Console.WriteLine("Number found: " + match.Value);
                    if (i == 0)
                    {
                        res.n = int.Parse(match.Value);
                    }
                    else
                    {
                        res._m = int.Parse(match.Value);
                    }
                }
            }
            return res;
        }

    
        
    }
}