using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//https://www.youtube.com/watch?v=J-jNcUhi9xw&t=160s
namespace General
{
    static class ThreadSafe_MultiThreading
    {
        public static void Method()
        {
            Maths maths = new Maths();

            Thread t1 = new Thread(maths.Divide_ThreadSafe);
            Thread t2 = new Thread(maths.Divide_ThreadSafe);
            t1.Start();                //Child Thread calling Divide Method
            maths.Divide_ThreadSafe(); // Main thread calling Divide method


        }
    }

    public class Maths
    {
        public int num1;
        public int num2;

        Random ran = new Random();
       
        public void Divide_NonThreadSafe()
        {
            for (long i = 0; i < 1000000; i++)
            {
               num1 = ran.Next(1, 5);
               num2 = ran.Next(1, 5);

                int result = num1 / num2;   //num1 and num2 are set to value 1 to 5 by thread 1 but 
                                            //main thread set num2 to 0 before executing divide operation
                                            //so we can find divide by zero exception at some point     
                                            //so inorder to remove this errror we use lock
                num2 = 0;                
            }
        }

        //Used thread safe , so no divide by error exception will occur
        public void Divide_ThreadSafe()
        {
            lock (this)
            {
                for (long i = 0; i < 1000000; i++)
                {
                    num1 = ran.Next(1, 5);
                    num2 = ran.Next(1, 5);

                    int result = num1 / num2;

                    num2 = 0;
                }
            }

        }
    }
}
