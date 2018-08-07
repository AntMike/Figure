using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FigureTest.Figures;

namespace FigureTest.Generators
{
    public class Generator : MonoBehaviour
    {
        public static Generator instance;
        public List<Figure> figuresBase;

        private void Awake()
        {
            if(instance == null)
            {
                instance = this;
            }
        }

        public void GenerateFigures()
        {
            int _rnd = Random.Range(5, 10);
            figuresBase = new List<Figure>();
            for (int i = 0; i < _rnd; i++)
            {
                figuresBase.Add(CreateFigure());
            }
        }

        public Figure CreateFigure()
        {
            int _type = Random.Range(0, (int)FigureType.Count);
            Figure _newFigure = null;
            switch (_type)
            {
                case 0:
                    _newFigure = new Square(Random.Range(1, 10), (FigureColor)Random.Range(0, (int)FigureColor.Count));
                    break;
                case 1:
                    _newFigure = new Triangle(Random.Range(1, 10), Random.Range(1, 10), (FigureColor)Random.Range(0, (int)FigureColor.Count));
                    break;
                case 2:
                    _newFigure = new Circle(Random.Range(1, 10), (FigureColor)Random.Range(0, (int)FigureColor.Count));
                    break;
                case 3:
                    _newFigure = new Trapezoid(Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10), (FigureColor)Random.Range(0, (int)FigureColor.Count));
                    break;
            }
            return _newFigure;
        }
    }
}
