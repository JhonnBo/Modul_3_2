namespace ex_Demo_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcDemo5();
        }

        // =======================================================================
        // ----------------------- ExcDemo5 --------------------------------------
        // =======================================================================
        public static void ExcDemo5()
        {
            // Использование нескольких catch-инструкций

            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
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
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }
    }
}