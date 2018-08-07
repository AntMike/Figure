using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FigureTest.Figures
{
    public abstract class Figure : MonoBehaviour
    {
        public FigureType figureTypeName;
        private List<string> figureUnique = new List<string>() { "side length", "hypotenuse", "middle line", "radius" };
        private FigureColor _figureColor;

        public FigureColor FigureColor
        {
            get { return _figureColor; }
            set { _figureColor = value; }
        }

        /// <summary>
        /// Return the line with all info about figure
        /// </summary>
        public virtual string DrawFigure(FigureType _type, float _area, float _unique, FigureColor _color)
        {
            var line = "Figure: " + _type.ToString() + ", area: " + System.Math.Round(_area, 2) + " sq. units, " + figureUnique[(int)_type] + ": "
                + System.Math.Round(_unique, 2)  +" units, color: " + _color.ToString();
            return line;
        }

        /// <summary>
        /// Calculate area of figure
        /// </summary>
        /// <returns>Return the figure area</returns>
        public abstract float FigureArea();

        /// <summary>
        /// Makeing unique function for figure
        /// </summary>
        /// <returns></returns>
        public abstract float UniqueFunction();

    }

    public enum FigureType
    {
        Square,
        Triangle,
        Circle,
        Trapezoid,
        Count
    }
    public enum FigureColor
    {
        Red,
        Green,
        Blue,
        Black,
        White,
        Orange,
        Yellow,
        Count
    }
}