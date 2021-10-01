using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4ModelLib.model
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ShirtNumber { get; set; }

        public FootballPlayer()
        {

        }
        public FootballPlayer(int id, string name, double price, int shirtNumber)
        {
            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtNumber;
        }

        public override string ToString()
        {
            return $"Id: {Id}, \n Name: {Name}, \n Price: {Price}, \n Shirt Number {ShirtNumber}";
        }
    }
}
