using System;

namespace SafeInt
{
    class SafeInt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value :");

            var value = Console.ReadLine();

            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.ToSafeInt(value));
            Console.WriteLine(myClass.ToSafeInt(value, 1));

            Console.WriteLine(value.ToSafeInt());
        }
    }
    public class MyClass
    {
        public int ToSafeInt(string str)
        {

            int result;
            int.TryParse(str, out result);

            return result;
        }
        public int ToSafeInt(string str, int defaultValue)
        {

            int result;
            bool safelyConverted = int.TryParse(str, out result);

            if (safelyConverted)
                return result;
            else
                return defaultValue;
        }
    }

    public static class Myextension
    {
        public static int ToSafeInt(this string str)
        {
            int result;
            int.TryParse(str, out result);

            return result;
        }

    }
}
