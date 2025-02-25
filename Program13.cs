using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotations
{
        public class LegacyAPI
        {

            [Obsolete("This method is obsolete. Use NewFeature() instead.")]
            public void OldFeature()
            {
                Console.WriteLine("This is the old feature.");
            }


            public void NewFeature()
            {
                Console.WriteLine("This is the new feature.");
            }
        }
        class Program2
        {
            static void Main()
            {
                LegacyAPI api = new LegacyAPI();


                api.OldFeature();
                api.NewFeature();
            }
        }
    }
