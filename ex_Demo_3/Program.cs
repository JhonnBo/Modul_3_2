namespace ex_Demo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcDemo3();
        }

        // =======================================================================
        // ----------------------- ExcDemo3 --------------------------------------
        // =======================================================================
        public static void GenException()
        {
            int[] nums = new int[4];
            Console.WriteLine("Перед генерированием исключения.");
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
            }
            Console.WriteLine("Этот текст не будет отображаться.");
        }

        public static void ExcDemo3()
        {
            /*  Исключение может сгенерировать один метод, а
                перехватить — другой. */
            try
            {
                GenException();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Stack trace: " + ex.StackTrace);
            }
            Console.WriteLine("После catch-инструкции.");
        }
    }
}