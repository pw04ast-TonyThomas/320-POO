namespace Snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            for (int i = 0; i < 40; i++) {
                Console.Clear();
                Console.SetCursorPosition(i, 10);
                Console.Write("_@_ö");
                Thread.Sleep(100);
            }

            Console.ReadLine();
        }
    }
}
