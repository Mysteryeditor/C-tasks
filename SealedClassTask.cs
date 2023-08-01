using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{
    internal sealed class Password
    {
        public Password() {
            Console.WriteLine("This comes under the constructor of a sealed class");
        }

    }

    
    //sealed class Password2:Password
    //{
    //     //sealed void sealedMethod() {
    //    //}
    //}

    internal class SealedClassTask
    {
        static void Main(string[] args)
        {
            Password password = new Password();
            Console.ReadKey();

          

        }


    }

}
