using System;
using System.Collections.Generic;

namespace Test
{
    public static class SomeClass
    {
        public void SomeGarbageMethod(int x, int y, String text)
        {
            if (x == 0)
            {
                // Do something crazy
                System.Console.WriteLine("x is zero");

                var i = 0;
                while (i < 1000)
                {
                    if (y > 200 && i > 200 && i < 400)
                    {
                        // Something weird...

                        System.Console.WriteLine("A somewhat complex conditional seems to be true");
                    }

                    i++;
                }

                System.Console.WriteLine(text);
            }
        }
    }
}
