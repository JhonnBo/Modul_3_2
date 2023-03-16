namespace CheckedDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckedDemo();
        }

        // =======================================================================
        // ----------------------- CheckedDemo -----------------------------------
        // =======================================================================

        static void CheckedDemo()
        {
            byte a, b;
            byte result;

            a = 127;
            b = 127;

            try
            {
                result = unchecked((byte)(a * b));
                Console.WriteLine("Непроверенный на переполнение результат: " + result);

                result = checked((byte)(a * b));
                Console.WriteLine("Проверенный на переполнение результат: " + result);
            }
            catch (OverflowException exc)
            {
                Console.WriteLine(exc);
            }

            try
            {
                unchecked
                {
                    a = 127;
                    b = 127;
                    result = (byte)(a * b);
                    Console.WriteLine("Непроверенный на переполнение результат: " + result);

                    a = 125;
                    b = 5;
                    result = (byte)(a * b);
                    Console.WriteLine("Непроверенный на переполнение результат: " + result);
                }

                checked
                {
                    a = 2;
                    b = 7;
                    result = (byte)(a * b);
                    Console.WriteLine("Проверенный на переполнение результат: " + result);

                    a = 127;
                    b = 127;
                    result = (byte)(a * b);
                    Console.WriteLine("Проверенный на переполнение результат: " + result);
                }
            }
            catch (OverflowException exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}