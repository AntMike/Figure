using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FigureTest.Figures
{
    public class Triangle : Figure
    {
        public float sideA;
        public float sideB;

        /// <summary>
        /// Take aruments of catets and color of the triangle
        /// </summary>
        public Triangle(float _sideA, float _sideB, FigureColor _color)
        {
            sideA =Mathf.Abs(_sideA);
            sideB = Mathf.Abs(_sideB);
            figureTypeName = FigureType.Triangle;
            FigureColor = _color;
        }

        //formula with semiperimetr to calculate area
        public override float FigureArea()
        {
            float _semiperimeter = (sideA + sideB + UniqueFunction()) /2;
            return Mathf.Sqrt(_semiperimeter * (_semiperimeter - sideA) * (_semiperimeter - sideB) * (_semiperimeter - UniqueFunction()));
        }

        /// <summary>
        /// Find hypotenuse
        /// </summary>
        public override float UniqueFunction()
        {
            return Mathf.Sqrt(sideA * sideA + sideB * sideB);
        }
    }
}
