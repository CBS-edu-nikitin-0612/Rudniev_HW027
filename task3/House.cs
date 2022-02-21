using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    struct Roof
    {
        private int height;  // m
        private string material;

        public int Height { get => height; set => height = value; }
        public string Material { get => material; set => material = value; }

        public Roof(int height, string material)
        {
            this.height = height;
            this.material = material;
        }
    }
    class House : ICloneable
    {
        public Roof roof;
        private int numberOfRooms;

        public int NumberOfRooms { get => numberOfRooms; set => numberOfRooms = value; }

        public House() : this(8, new Roof(4, "wood")) { }
        public House(int numberOfRooms) : this(numberOfRooms, new Roof(4, "wood")) { }
        public House(int numberOfRooms, Roof roof)
        {
            this.roof = roof;
            this.numberOfRooms = numberOfRooms;
        }

        public override string ToString()
        {
            return $"{nameof(House)}: number of rooms = {numberOfRooms}, roof height = {roof.Height}, roof material = {roof.Material}.";
        }

        public object Clone()
        {
            return new House(this.numberOfRooms, this.roof);
        }
        public object DeepClone()
        {
            return new House(this.numberOfRooms, new Roof(this.roof.Height, this.roof.Material));
        }
        
    }
}
