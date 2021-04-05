using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    public class Reverse_Integer
    {
        public int Reverse(int x)
        {
            int ret = 0;
            int temp = x;

            try
            {
                checked
                {
                    while (temp != 0)
                    {
                        int r = temp % 10;
                        ret = ret * 10 + r;

                        temp = temp / 10;
                    }
                }
            }
            catch (Exception ex)
            {
                ret = 0;
            }

            return ret;
        }
    }
}
