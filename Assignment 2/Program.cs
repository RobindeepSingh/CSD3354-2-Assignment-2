using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        
        public class DelegateExercises
        {
            //Name : Robindeep Singh (C0723381)
            //Name : Gurkirat Singh  (C)731779)
            public delegate void MyDelegate();

            void Method1()
            {
                Console.WriteLine("Method1");
                Console.ReadLine();
            }
            public void Method2()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }
        }


    }
}
