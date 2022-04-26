using System;

namespace CookiesTask
{

    class Program
    {

        static void Main(string[] args)
        {
            Cookie nom = new Cookie(50, "Round", "IndianRed");
            Cookie yum = new Cookie(25, "Star", "LightCoral");
            Cookie tasty = new Cookie(30, "Man", "Salmon");
            Cookie hefty = new Cookie(150, "Square", "DarkSalmon");
        }

    }

    public class Cookie
    {
        private int weight { get; set; } //prop
        private string shape { get; set; } //prop
        private string cookieColour { get; set; } //prop

        public Cookie(int weight, string shape, string colour)
        {
            this.weight = weight;
            this.shape = shape;
            this.cookieColour = colour;
        }




        public class Colour
        {
            private int red;
            private int green;
            private int blue;
            public Colour(int red, int green, int blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
            }
        }

        public void colourName(string name)
        {
            if (name == "IndianRed")
            {
                Colour IndianRed = new Colour(205, 92, 92);
            }
            else if (name == "LightCoral")
            {
                Colour LightCoral = new Colour(240, 128, 128);
            }
            else if (name == "Salmon")
            {
                Colour Salmon = new Colour(250, 128, 114);
            }
            else if (name == "DarkSalmon")
            {
                Colour DarkSalmon = new Colour(233, 150, 122);
            }
        }

    }

}