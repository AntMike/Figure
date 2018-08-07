using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FigureTest.Figures
{
    public class Square : Figure
    {

        public float sides;

        public Square(float _sides, FigureColor _color)
        {
            sides = Mathf.Abs(_sides);
            figureTypeName = FigureType.Square;
            FigureColor = _color;
        }

        public override float FigureArea()
        {
            return sides*sides;
        }

        public override float UniqueFunction()
        {
            return sides;
        }
    }
}
