namespace ex_Demo_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcDemo10();
        }

        // =======================================================================
        // ----------------------- ExcDemo10 -------------------------------------
        // =======================================================================
        public static void UseFinally(int what)
        {
            // Использование блока finally.
            int t;
            int[] nums = new int[2];
            Console.WriteLine("Получаем " + what);
            try
            {
                switch (what)
                {
                    case 0:
                        t = 10 / what; // Генерируем ошибку деления на нуль.
                        break;
                    case 1:
                        nums[4] = 4; // Генерируем ошибку индексирования массива.
                        break;
                    case 2:
                        throw new StackOverflowException(); // Генерируем ошибку переполнения стека.
                    case 3:
                        return; // Возврат из try-блока.
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                Console.WriteLine("По окончании try-блока.");
            }
        }
        public static void ExcDemo10()
        {
            for (int i = 0; i < 4; i++)
            {
                UseFinally(i);
                Console.WriteLine();
            }
        }
    }
}

//В блоке finally обычно размещаются действия,
//которые необходимо гарантировано выполнить, вне зависимости
//от того произошла исключительная ситуация 
//в блоке try или нет, то есть блок finally выполняется 
//всегда, независимо от возникновения исключения 