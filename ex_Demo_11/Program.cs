namespace ex_Demo_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DispatchException();
        }

        // =======================================================================
        // --------------- DispatchException ----- отсылка исключений ------------
        // =======================================================================
        public static void DispatchException()
        {
            try
            {
                TestClass.Method1();
            }
            catch (DivideByZeroException ex) // здесь только перехватится исключение деления на нуль из класса
            {
                Console.WriteLine($"Catch в DispatchException : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally в DispatchException");
            }
            Console.WriteLine("Конец метода DispatchException");
        }
    }
    class TestClass
    {
        public static void Method1()
        {
            try
            {
                Method2();
            }
            catch (IndexOutOfRangeException ex) // перехватывается не то исключение
                                                // поэтому оно подымается дальше выше
            {
                Console.WriteLine($"Catch в Method1 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Блок finally в Method1");
            }
            Console.WriteLine("Конец метода Method1"); //не выполнится
        }
        static void Method2()
        {
            try
            {
                int x = 8;
                int y = x / 0;
            }
            finally // нет кэтч, т. е. нет перехвата исключения
            {
                Console.WriteLine("Блок finally в Method2");
            }
            Console.WriteLine("Конец метода Method2"); //не выполнится
        }
    }
}