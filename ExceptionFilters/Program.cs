namespace ExceptionFilters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExceptionFilters();
        }

        // =======================================================================
        // ----------------------- ExceptionFilters ------------------------------
        // =======================================================================
        static void ExceptionFilters()
        {
            // Фильтры исключений позволяют обрабатывать исключения в зависимости от определенных условий.

            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
            for (int i = 0; i < numer.Length; i++)
                try
                {
                    Console.WriteLine(numer[i] + " / " + denom[i] + " равно " + numer[i] / denom[i]);
                    throw new Exception("Исключение при работе метода!");
                }
                catch (Exception ex) when (denom[i] == 0)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex) when (i >= denom.Length)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }
    }
}