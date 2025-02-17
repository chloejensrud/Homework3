// Written By Chloe Jensrud
// 2/16/25

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFletchersArrows
{
    public class Arrow
    {
        public enum Arrowhead { Steel, Wood, Obsidian }
        public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }

        private Arrowhead _arrowhead { get; set; }
        private Fletching _fletching { get; set; }
        private float _length { get; set; }

        public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
        {
            _arrowhead = arrowhead;
            _fletching = fletching;
            _length = length;
        }



        public float GetCost()
        {
            float arrowheadCost = _arrowhead switch
            {
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                Arrowhead.Obsidian => 5,
                _ => 0
            };

            float fletchingCost = _fletching switch
            {
                Fletching.Plastic => 10,
                Fletching.TurkeyFeathers => 5,
                Fletching.GooseFeathers => 3,
                _ => 0
            };

            float shaftCost = 0.05f * _length;

            return arrowheadCost + fletchingCost + shaftCost;
        }
    }
}
