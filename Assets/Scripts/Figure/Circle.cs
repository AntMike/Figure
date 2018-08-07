using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FigureTest.Figures
{
    public class Circle : Figure
    {
        public float radius;

        /// <summary>
        /// Take radius and color of circle
        /// </summary>
        public Circle(float _radius, FigureColor _color)
        {
            radius = Mathf.Abs(_radius);
            figureTypeName = FigureType.Circle;
            FigureColor = _color;
        }

        public override float FigureArea()
        {
            return Mathf.PI * radius * radius;
        }

        /// <summary>
        /// Returns circle radius
        /// </summary>
        public override float UniqueFunction()
        {
            return radius;
        }
    }
}
