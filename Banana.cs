using System;
using System.Collections.Generic;
using System.Text;

namespace _24._06._2020
{
    class Banana : Fruit
    {
        public bool _hasBlackSpots;
        public bool _isGreen;
        public float _size;

        public override bool isThisMyFavorite()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{_hasBlackSpots} , {_isGreen}, {_size} " base.ToString();
        }
    }
}
