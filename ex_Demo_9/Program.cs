namespace ex_Demo_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcDemo9();
        }

        // =======================================================================
        // ----------------------- ExcDemo9 --------------------------------------
        // =======================================================================
        public static void ReGenException()
        {
            // Повторное генерирование исключения
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512, 1024 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };
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
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw; // Генерируем исключение повторно
                }
            }
        }

        public static void ExcDemo9()
        {
            try
            {
                ReGenException();
            }
            catch (IndexOutOfRangeException ex)
            {
                // Перехватываем повторно сгенерированное исключение
                Console.WriteLine(ex.Message);
            }
        }
    }
}

//Но существует также и другая форма использования оператора throw,
//когда после данного оператора не указывается объект исключения.
//В подобном виде оператор throw может использоваться только в блоке catch.

//Однако поскольку в этом блоке используется оператор throw,
//то исключение будет передано дальше внешнему блоку catch,
//который получит то же самое исключение и выведет то же самое сообщение на консоль.

