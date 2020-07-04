using System;
using System.Collections.Generic;
using System.Text;

namespace _24._06._2020
{
    class Peach : Fruit
    {
        public string _peachColor;
        public bool _hadSeedInside;

        public override bool isThisMyFavorite()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{_peachColor}, {_hadSeedInside}, " base.ToString();
        }
    }
}
