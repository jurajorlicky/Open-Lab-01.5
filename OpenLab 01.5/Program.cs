using System;

namespace OpenLab_01._5
{
    class Program
    {
        public static Boolean Reverse(bool boolean)
        {
            return !boolean;
        }
        static void Main(string[] args)
        {
            bool boolean = false;
            bool boolean_reversed = Reverse(boolean);
            Console.WriteLine(boolean_reversed);
            Console.ReadLine();
        }
    }
}


