using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FigureTest.Figures
{
    public class Circle : Figure
    {
        public float radius;

        public Circle(float _radius, Color _color)
        {
            radius = Mathf.Abs(_radius);
            FigureColor = _color;
        }

        public override float FigureArea()
        {
            return Mathf.PI * radius * radius;
        }

        public override float UniqueFunction()
        {
            return 2 * Mathf.PI * radius;
        }
    }
}
