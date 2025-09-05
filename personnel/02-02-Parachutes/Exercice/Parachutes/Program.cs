using System.Security.Cryptography.X509Certificates;

namespace Parachutes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int planeXPos = 0;
            int parachutistsNb = 10;
            string parachutistsName;
            ConsoleKeyInfo keyPressed = Console.ReadKey(true);

            Console.WriteLine("Hello, World!");


            // Changement de la taille de la fenêtre.
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;

            Plane plane = new Plane(planeXPos);

            for (int i = 0; i < parachutistsNb; i++)
            {
                plane.Board(new Para());
            }


            while (true) {
                // Modifier la position de l'avion en code.
                plane.update();

                // afficher la nouvelle position de l'avion.
                Console.Clear();
                plane.draw();
            
                // temporiser
                Thread.Sleep(80);

                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(1);    
                            break;
                        case ConsoleKey.Spacebar:
                            
                            break;
        }
                }
            }
        }
    }
}
