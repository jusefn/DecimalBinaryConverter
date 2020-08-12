using System;
namespace DecimalBinaryConverter
{
    public static class ConvClass
    {

        /// <summary>
        /// Takes an integer and converts it into a binary as a string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Binary(int input)
        {
            
            string lol = Convert.ToString(input, 2);
            return lol;
        }
    }
}
