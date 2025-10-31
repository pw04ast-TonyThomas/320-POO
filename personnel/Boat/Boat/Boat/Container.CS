using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    public class Container : IContainer
    {
        public int Id { get; }

        public float Weight { get; }

        public bool IsRefrigerated { get; }

        public List<string> Merchandise { get; }

        public string Color { get; }

        public Container(int id, float weight, bool isRefrigerated, List<string> merchandise, string color)
        {
            this.Id = id;
            this.Weight = weight;
            this.IsRefrigerated = isRefrigerated;
            this.Merchandise = merchandise;
            this.Color = color;
        }

        public void AddMerchandise(string item)
        {
            Merchandise.Add(item);
        }

        public void ViewContent()
        {
            foreach (var merch in Merchandise)
            {
                Console.WriteLine(merch);
            }
        }
    }

}