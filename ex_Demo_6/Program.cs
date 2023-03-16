namespace ex_Demo_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcDemo6();
        }

        // =======================================================================
        // ----------------------- ExcDemo6 --------------------------------------
        // =======================================================================
        public static void ExcDemo6()
        {
            // Перехват всех исключений.
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
            for (int i = 0; i < numer.Length; i++)
                try
                {
                    Console.WriteLine(numer[i] + " / " + denom[i] + " равно " + numer[i] / denom[i]);
                }
                catch //(Exception ex) 
                {
                    Console.WriteLine("Произошло некоторое исключение.");// + ex.Message);
                }
        }
    }
}