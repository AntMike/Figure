using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FigureTest.Generators;
using FigureTest.Figures;
using UnityEngine.UI;

namespace FigureTest.Outputter
{
    public class Outputter : MonoBehaviour
    {
        [SerializeField]
        private Text _outputTxt;

        private void Start()
        {
            GenerateNewBtn();
        }

        public void GenerateNewBtn()
        {
            ClearOutputter();
            Generator.instance.GenerateFigures();
            List<Figure> _figures = Generator.instance.figuresBase;
            foreach (Figure _figure in _figures)
            {
                AddDataToOutputter(_figure.DrawFigure(_figure.figureTypeName, _figure.FigureArea(), _figure.UniqueFunction(), _figure.FigureColor));
            }
        }

        public void AddDataToOutputter(string _data)
        {
            _outputTxt.text += "\n" + _data;
        }

        public void ClearOutputter()
        {
            _outputTxt.text = "";
        }

    }
}