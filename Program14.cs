using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation
{
    class Program3
    {
        static void Main()
        {
#pragma warning disable CS0618
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Hello");
            list.Add(DateTime.Now);
#pragma warning restore CS0618

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

}