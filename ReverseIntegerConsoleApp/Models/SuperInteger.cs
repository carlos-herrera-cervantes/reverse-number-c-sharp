namespace ReverseIntegerConsoleApp.Models
{
    public class SuperInteger
    {
        #region Snippet_SuperMethods

        /// <summary>Reverse an integer of 32 bits</summary>
        /// <param name="number">32 bit integer</param>
        /// <returns></returns>
        public static int Reverse(int number)
        {
            int reverse = 0;

            while (number != 0)
            {
                int pop = number % 10;
                number /= 10;

                if (reverse > int.MaxValue / 10 || (reverse == int.MaxValue / 10 && pop > 7)) return 0;
                if (reverse < int.MinValue / 10 || (reverse == int.MinValue / 10 && pop < -8)) return 0;

                reverse = reverse * 10 + pop;
            }

            return reverse;
        }

        #endregion
    }
}