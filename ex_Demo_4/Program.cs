namespace ex_Demo_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcDemo4();
        }

        // =======================================================================
        // ----------------------- ExcDemo4 --------------------------------------
        // =======================================================================
        public static void ExcDemo4()
        {
            // Деление на нуль.

            int[] numer = { 4, 8, 16, 32, 64, 128 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
            for (int i = 0; i < numer.Length; i++)
                try
                {
                    Console.WriteLine(numer[i] + " / " + denom[i] + " равно " + numer[i] / denom[i]);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }
    }
}