using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentAccessModifier
{
    class Product
    {
        public int productId = 10;
        private string productName = "abc";

        public void test()
        {
            int a = 10;
            Console.WriteLine(productName);
        }
        protected void test1()
        {
            test();
            Console.WriteLine();
        }
    }
   
}
