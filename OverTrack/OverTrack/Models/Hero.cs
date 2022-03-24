using Xamarin.Forms;

namespace OverTrack.Models
{
    public class Hero
    {
        // Character Images
        public ImageSource Artwork { get; set; }
        public ImageSource Sprite { get; set; }
        public ImageSource Cute { get; set; }
        public ImageSource Portrait { get; set; }

        // Character Bio 
        public string Name { get; set; }
        public string RealName { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public ImageSource NationalityFlag { get; set; }
        public string Occupation { get; set; }
        public string Base { get; set; }
        public string Affiliations { get; set; }
        public string Relations { get; set; }
        public string Voice { get; set; }
        public string Cosmetics { get; set; }
        public string Quotes { get; set; }
        public string Role { get; set; }
        public int Health { get; set; }
    }
}
