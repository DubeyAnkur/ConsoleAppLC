using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLC
{
    class Integer_to_English_Words
    {
        bool th = false;
        bool ml = false;
        bool bl = false;
        bool tr = false;

        public string NumberToWords(int num)
        {
            string ret = "";
            int placeValue = 1;

            if (num == 0)
                return "Zero";

            while (num > 0)
            {
                string comp = "";
                if (num % 100 < 20 && placeValue % 3 == 1)
                {
                    int r = num % 100;
                    if (r != 0)
                        comp = DigitToStr(r);
                    
                    if (r != 0)
                        comp = comp + PlaceValue(placeValue);

                    num = num / 100;
                    placeValue = placeValue + 2;
                }
                else
                {
                    int r = num % 10;
                    if (placeValue % 3 == 2)
                        comp = TensToStr(r);
                    else
                        comp = DigitToStr(r);

                    if (placeValue != 3 && placeValue % 3 == 0 && r!=0)
                        comp = comp + PlaceValue(3);


                    if (r != 0)
                        comp = comp + PlaceValue(placeValue);

                    num = num / 10;
                    placeValue++;
                }

                //string P = PlaceValue(placeValue-1);
                ret = comp + ret;
            }
            return ret.Trim();
        }

        private string PlaceValue(int i)
        {
            switch (i)
            {
                case 3: return "Hundred "; 
                case 4:
                    {
                        th = true;
                        return "Thousand ";
                    }
                case 5:
                    {
                        if (!th)
                        {
                            th = true;
                            return "Thousand ";
                        }
                        else return "";
                    }
                case 6:
                    {
                        if (!th)
                        {
                            th = true;
                            return "Thousand ";
                        }
                        else return "";
                    }
                case 7: {
                        ml = true;
                        return "Million "; }
                case 8: 
                    {
                        if (!ml)
                        {
                            ml = true;
                            return "Million ";
                        }
                        else return "";
                    }
                case 9:
                    {
                        if (!ml)
                        {
                            ml = true;
                            return "Million ";
                        }
                        else return "";
                    }
                case 10: { bl = true;  return "Billion "; }
                case 11: 
                    {
                        if (!bl)
                        {
                            bl = true;
                            return "Billion ";
                        }
                        else return "";
                    }
                case 12: 
                    {
                        if (!bl)
                        {
                            bl = true;
                            return "Billion ";
                        }
                        else return "";
                    }
                case 13: return "Trillion "; 
            }
            return "";
        }

        private string DigitToStr(int i)
        {
            switch (i)
            {
                case 1: return "One ";
                case 2: return "Two ";
                case 3: return "Three ";
                case 4: return "Four ";
                case 5: return "Five ";
                case 6: return "Six ";
                case 7: return "Seven ";
                case 8: return "Eight ";
                case 9: return "Nine ";
                case 0: return "";
                case 10: return "Ten ";
                case 11: return "Eleven ";
                case 12: return "Twelve ";
                case 13: return "Thirteen ";
                case 14: return "Fourteen ";
                case 15: return "Fifteen ";
                case 16: return "Sixteen ";
                case 17: return "Seventeen ";
                case 18: return "Eighteen ";
                case 19: return "Nineteen ";
            }
            return "";
        }

        private string TensToStr(int i)
        {
            switch (i)
            {
                case 2: return "Twenty ";
                case 3: return "Thirty ";
                case 4: return "Fourty ";
                case 5: return "Fifty ";
                case 6: return "Sixty ";
                case 7: return "Seventy ";
                case 8: return "Eighty ";
                case 9: return "Ninety ";
                case 0: return "";
            }
            return "";
        }
    }
}
