namespace ChainOfResponsibility
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type an int to divide Max Int By");
            try
            {
                LineReader.ReadLine();
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("quit trying to divide By zero, you might break something");
            }

        }
    }
}