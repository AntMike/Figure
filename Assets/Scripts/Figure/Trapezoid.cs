using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FigureTest.Figures
{ 
    public class Trapezoid : Figure
    {

        public float sideA;
        public float sideB;
        public float hight;

        public Trapezoid(float _sideA, float _sideB, float _height, Color _color)
        {
            sideA = Mathf.Abs(_sideA);
            sideB = Mathf.Abs(_sideB);
            hight = Mathf.Abs(_height);
            FigureColor = _color;
        }


        public override float FigureArea()
        {
            return ((sideA+sideB)*hight/2 );
        }

        public override float UniqueFunction()
        {
            return FigureArea() / hight;
        }
    }
}
