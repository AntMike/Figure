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

        /// <summary>
        /// Take lower and higher sides, height and color
        /// </summary>
        public Trapezoid(float _sideA, float _sideB, float _height, FigureColor _color)
        {
            sideA = Mathf.Abs(_sideA);
            sideB = Mathf.Abs(_sideB);
            hight = Mathf.Abs(_height);
            figureTypeName = FigureType.Trapezoid;
            FigureColor = _color;
        }

        //formule sides pluses and multiplies to height and then divide to 2
        public override float FigureArea()
        {
            return ((sideA+sideB)*hight/2 );
        }

        /// <summary>
        /// Return middle line
        /// </summary>
        public override float UniqueFunction()
        {
            return FigureArea() / hight;
        }
    }
}
