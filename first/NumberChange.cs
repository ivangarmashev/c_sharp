using System;

namespace first
{
    public class NumberChange
    {
        public int x;

        public int FindMax(int arg1, int arg2)
        {
            int result;
            if (arg1 > arg2)
            {
                result = arg1;
            }
            else if (arg2 > arg1)
            {
                result = arg2;
            }
            else
            {
                result = 0;
            }
            this.x = 100;
            return result;
        }
    }
}
