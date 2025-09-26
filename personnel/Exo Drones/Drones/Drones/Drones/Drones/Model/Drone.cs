using Drones.Helpers;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone
    {
     

        private int charge = 1000;                     // La charge actuelle de la batterie
        private string _name;                          // Un nom
        public string Name { get { return _name; } set { _name = value; }}
        private int _x;                                // Position en X depuis la gauche de l'espace aérien
        public int X { get { return _x; } set { _x = value; }}           
        private int _y;                                // Position en Y depuis le haut de l'espace aérien
        public int Y { get { return _y; } set { _y = value; }}


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            X += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            Y += RandomHelper.random.Next(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            charge--;                                  // Il a dépensé de l'énergie
        }
    }
}
