using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FigureTest.Figures
{
    public class Triangle : Figure
    {
        public float sideA;
        public float sideB;

        public Triangle(float _sideA, float _sideB, Color _color)
        {
            sideA =Mathf.Abs(_sideA);
            sideB = Mathf.Abs(_sideB);
            FigureColor = _color;
        }

        public override float FigureArea()
        {
            float _semiperimeter = (sideA + sideB + UniqueFunction()) /2;
            return Mathf.Sqrt(_semiperimeter * (_semiperimeter - sideA) * (_semiperimeter - sideB) * (_semiperimeter - UniqueFunction()));
        }

        public override float UniqueFunction()
        {
            return Mathf.Sqrt(sideA * sideA + sideB * sideB);
        }
    }
}
