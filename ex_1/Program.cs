namespace ex_Demo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcDemo1();
        }
        // =======================================================================
        // ----------------------- ExcDemo1 --------------------------------------
        // =======================================================================
        public static void ExcDemo1()
        {
            // Предоставим возможность обработать ошибку
            // С#-системе динамического управления

            int[] nums = new int[4];
            Console.WriteLine("Перед генерированием исключения.");
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums [ {0} ] : {1}", i, nums[i]);
            }
        }
    }
}

