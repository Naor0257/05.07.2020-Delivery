using System;
using System.Collections.Generic;
using System.Text;

namespace _24._06._2020
{
    abstract class Fruit : FruitSalad
    {
        public string _name;
        public int _calories;

        public abstract bool isThisMyFavorite();
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
