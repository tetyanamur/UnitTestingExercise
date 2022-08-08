using System;

namespace UnitTestingExercise.Tests
{
    internal class UnitTestMethods
    {
        public UnitTestMethods()
        {
        }

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int one, int two)
        {
            return one / two;
        }

        internal object ReturnName()
        {
            return "TM";
        }
    }
}