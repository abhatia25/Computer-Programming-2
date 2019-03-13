using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatClass
{
    class Cat
    {
        //Field name
        private string name;
        //Field color
        private string color;
        //Field texture
        private string texture;

        public string Name
        {
            // Getter of the property "Name"
            get
            {
                return this.name;
            }
            // Setter of the property "Name"
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            // Getter of the property "Color"
            get
            {
                return this.color;
            }
            // Setter of the property "Color"
            set
            {
                this.color = value;
            }
        }

        public string Texture
        {
            //Gettter of the property "Texture"
            get
            {
                return this.texture;
            }
            set
            {
                this.color = value;
            }
        }
        // Default constructor
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
            this.texture = "soft";
        }

        // Constructor with parameters
        public Cat(string name, string color, string texture)
        {
            this.name = name;
            this.color = color;
            this.texture = texture;
        }

        // Method SayMiau
        public void SayMiau()
        {
            Console.WriteLine("{1} Cat {0} said: Miauuuuuu!", name, texture);
        }
    }
}