using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Program
    
        {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger(100, "tiger");
            Lion lion = new Lion(200, "lion");

            tiger.Show();
            lion.Show();
        }
    
}
}
