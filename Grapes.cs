using System;
using System.Collections.Generic;
using System.Text;

namespace _24._06._2020
{
    class Grapes : Fruit
    {
        public string _color;
        public float _grapeSize;

        public override bool isThisMyFavorite()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{_color}, {_grapeSize} " base.ToString();
        }
    }
}
