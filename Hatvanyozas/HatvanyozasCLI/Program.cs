using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatvanyozasCLI
{
    public class PowerCalculator
    {
        public int CalculatePower(int basee, int exponent)
        {
            int szorzat=1;
            if(basee<0||exponent>0)
            {
                for(int i = 1; i<=exponent;i++)
                {
                    if (exponent < 0)
                    {
                        szorzat *= 1;
                    }
                    szorzat*=basee;
                }
            }
            return szorzat;
        }
        public static void Main(string[] args)
        {
            Console.Write("Add meg az első számot: ");
            int basee=int.Parse(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            int exponent = int.Parse(Console.ReadLine());
            var hatvany = new PowerCalculator();
            Console.WriteLine($"Az eredmény: {hatvany.CalculatePower(basee, exponent)}");
            Console.ReadKey();
        }
    }
}
