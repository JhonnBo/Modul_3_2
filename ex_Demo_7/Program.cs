namespace ex_Demo_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcDemo7();
        }

        // =======================================================================
        // ----------------------- ExcDemo7 --------------------------------------
        // =======================================================================
        public static void ExcDemo7()
        {
            // Использование вложенного try-блока
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
            try
            {
                for (int i = 0; i < numer.Length; i++)
                {
                    try
                    {
                        Console.WriteLine(numer[i] + " / " + denom[i] + " равно " + numer[i] / denom[i]);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    //catch (IndexOutOfRangeException ex)
                    //{
                    //    Console.WriteLine(ex.Message);
                    //}
                }
            }
            catch (IndexOutOfRangeException ex) // возврата в цикл уже не будет!!!
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}