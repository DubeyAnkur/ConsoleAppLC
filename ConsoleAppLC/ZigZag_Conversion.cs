using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleAppLC
{
    public class ZigZag_Conversion
    {
        public string Convert(string s, int numRows)
        {
            string ret = "";

            string[] memory = new string[numRows];

            int direction = 1;
            int row = 0;
            foreach (char c in s)
            {
                if (row > numRows - 1)
                    row = 0;

                memory[row] = memory[row] + c;
                row = row + direction;

                if (row == 0)
                    direction = 1;
                if (row == numRows-1)
                    direction = -1;

            }

            foreach (string str in memory)
            {
                ret = ret + str;
            }

            return ret;
        }
    }
}
