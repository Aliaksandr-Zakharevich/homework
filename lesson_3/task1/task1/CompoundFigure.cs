using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class CompoundFigure : Figure
    {
        Figure[] figures;
        public CompoundFigure(params Figure[] figures)
        {
            this.figures = figures;
        }
        public override double Perimetr()
        {
            double pFigures = 0;
            foreach (Figure i in figures)
            {
                pFigures += i.Perimetr();
            }
            return pFigures;
        }

        public override double Square()
        {
            double sFigures = 0;
            foreach(Figure i in figures)
            {
                sFigures += i.Square();
            }
            return sFigures;
        }
    }
}
