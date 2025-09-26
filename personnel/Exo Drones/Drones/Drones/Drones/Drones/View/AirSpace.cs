using Drones.Helpers;
using Drones.Properties;

namespace Drones
{
    // La classe AirSpace représente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fenêtre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class AirSpace : Form
    {
        public const int WIDTH = 1200;        // Dimensions of the airspace
        public const int HEIGHT = 600;

        private static int nbOfDrones;

        // La flotte est l'ensemble des drones qui évoluent dans notre espace aérien
        private List<Drone> fleet;
        private List<Building> buildings;

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;

        // Initialisation de l'espace aérien avec un certain nombre de drones
        public AirSpace(List<Drone> fleet, List<Building> buildings)
        {
            if (fleet.Count > 1000) throw new Exception("Pas Content!"); // si plus de 10 drones, lancer une exception.
            InitializeComponent();
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            this.fleet = fleet;
            this.buildings = buildings;
        }

        // Affichage de la situation actuelle
        private void Render()
        {
            airspace.Graphics.DrawImage(Resources.Background, -100, -100,1920/1.4f,1080/1.4f);

            // draw Buildings
            foreach (Building batiment in buildings)
            {
                if (batiment.GetType() == typeof(Factory))
                {
                    Factory factory = (Factory)batiment;
                    factory.Render(airspace);
                } 
                else if (batiment.GetType() == typeof(Store))
                {
                    Store store = (Store)batiment;
                    store.Render(airspace); 
                }
                else batiment.Render(airspace);
            }

            // draw drones
            foreach (Drone drone in fleet)
            {
                drone.Render(airspace);
            }
            airspace.Render();
        }

        // Calcul du nouvel état après que 'interval' millisecondes se sont écoulées
        private void Update(int interval)
        {
            foreach (Drone drone in fleet)
            {
                drone.Update(interval);
            }
        }

        // Méthode appelée à chaque frame
        private void NewFrame(object sender, EventArgs e)
        {
            this.Update(ticker.Interval);
            this.Render();
        }

        private void AirSpace_Load(object sender, EventArgs e)
        {

        }
    }
}