using System.Security.Cryptography.X509Certificates;

namespace Snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int life = 50;
            int height = 10;
            string body = "_@_ö";

            /*
            Console.ForegroundColor = ConsoleColor.Blue;

            for (int i = 0; i < 40; i++) {
                Console.Clear();
                Console.SetCursorPosition(i, 10);
                Console.Write("_@_ö");
                Thread.Sleep(100);
            }

            Console.ReadLine();
            */

            Console.Write("The snail's lifespan: ");
            life = Convert.ToInt32(Console.ReadLine());
            Console.Write("The snail's starting point height: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("The snail's body: ");
            body = Console.ReadLine();

            Snail snail = new Snail(life, height, body);
            snail.start(snail._life,snail._height, snail._body);

            Console.ReadLine();
        }
    }

    public class Snail
    {
        public int _life;
        public int _height;
        public string _body;

        public Snail()
        {
            this._life = 50;
            this._height = 10;
            this._body = "_@_ö";
        }

        public Snail(int life, int height, string body)
        {
            this._life = life;
            this._height = height;
            this._body = body;
        }

        public void start(int life, int height, string body) 
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            for (int i = 0; i < life; i++)
            {
                Console.Clear();
                Console.SetCursorPosition(i, height);
                Console.Write(body);
                Thread.Sleep(100);
            }
            Console.Clear();
            Console.SetCursorPosition(life-1, height);
            for (int i = 0; i < body.Length; i++)
            {
                Console.Write("_");
            }
        }
    }
}
