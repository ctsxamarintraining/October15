using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes
{
    public static class ExtensionMethods
    {
        public static bool IsEven(this int value)
        {
            return (value % 2 == 0);
        }

        public static bool IsPrime(this int value)
        {
            bool flag = true;
            for(int i=2;i<value/2;i++)
            {
                if(value % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        
    }
}
