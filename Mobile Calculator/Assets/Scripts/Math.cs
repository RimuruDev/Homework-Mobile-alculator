using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RimuruDev.Math
{
    public static class Math
    {
        public static int Multiply(int x, int y) => x * y;
        public static int Addition(int x, int y) => x + y;
        public static int Division(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                Debug.LogWarning("На ноль делить можно, но иди нахуй.");

                return 0;
            }

            return x / y;
        }
        public static int Subtraction(int x, int y) => x - y;

        public static double Multiply(double x, double y) => x * y;
        public static double Addition(double x, double y) => x + y;
        public static double Division(double x, double y)
        {
            if (x == 0 || y == 0)
            {
                Debug.LogWarning("На ноль делить можно, но иди нахуй.");

                return 0;
            }

            return x / y;
        }
        public static double Subtraction(double x, double y) => x - y;

        public static decimal Multiply(decimal x, decimal y) => x * y;
        public static decimal Addition(decimal x, decimal y) => x + y;
        public static decimal Division(decimal x, decimal y)
        {
            if (x == 0 || y == 0)
            {
                Debug.LogWarning("На ноль делить можно, но иди нахуй.");

                return 0;
            }

            return x / y;
        }
        public static decimal Subtraction(decimal x, decimal y) => x - y;

        public static byte Multiply(byte x, byte y) => (byte)(x * y);
        public static byte Addition(byte x, byte y) => (byte)(x + y);
        public static byte Division(byte x, byte y)
        {
            if (x == 0 || y == 0)
            {
                Debug.LogWarning("На ноль делить можно, но иди нахуй.");

                return 0;
            }

            return (byte)(x / y);
        }
        public static byte Subtraction(byte x, byte y) => (byte)(x - y);

        public static short Multiply(short x, short y) => (short)(x * y);
        public static short Addition(short x, short y) => (short)(x + y);
        public static short Division(short x, short y)
        {
            if (x == 0 || y == 0)
            {
                Debug.LogWarning("На ноль делить можно, но иди нахуй.");

                return 0;
            }

            return (short)(x / y);
        }
        public static short Subtraction(short x, short y) => (short)(x - y);
    }
}