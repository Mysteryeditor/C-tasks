using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks1
{

    public partial class Task1
    {

        public partial void hashTableTask()
        {
            Hashtable userData = new Hashtable();
            userData.Add(1, "Srikanth");
            userData.Add(2, "Darshan");
            foreach (DictionaryEntry value in userData)
            {
                Console.WriteLine("Key:" + value.Key + "Value:" + value.Value);

            }
        }


    }

}
