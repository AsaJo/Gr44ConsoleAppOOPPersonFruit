using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr44ConsoleAppOOPPersonFruit.Model
{
    public class Fruit
    {
        private int FruitId;
        private string FruitName;
        public FruitColor fruitColor;

        public Fruit(int fruitId, string fruitName, FruitColor color, bool sweet)
        {
            FruitId = fruitId;
            FruitName = fruitName;
            fruitColor = color;
            Sweet = sweet;
        }
        public int fruitId
        {
            get { return FruitId; }
            set { FruitId = value; }
        }

        public string fruitName
        {
            get { return FruitName; }
            set { FruitName = value; }
        }
        public bool sweet { get; set; }

        // fruit taste?
        // fruit soft/hard
        private bool Sweet = true;

        public string TasteOfFruit()
        {
            if (Sweet == true)
            {
                //Console.WriteLine("I love this taste....It´s sooo sweet");
                return "I love this taste....It´s sooo sweet";
            }
            else
                //Console.WriteLine("Urrrc this was awful");
                return "Urrrc this was awful";

        }
    }

    public enum FruitColor
    {
        Green,
        Yellow,
        Blue,
        Orange,
        Red
    }
}

