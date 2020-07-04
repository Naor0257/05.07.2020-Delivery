using System;
using System.Collections.Generic;
using System.Text;

namespace _24._06._2020
{
    class Apple : Fruit
    {
        public string _color;
        public bool _pinkLady;

        public override bool isThisMyFavorite()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{_color}, {_pinkLady} " base.ToString();
        }
    }
}
