using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделирование_процесса_растворения_твердых_тел
{
    
    class BASE
    {
        public Point[,] points { get; private set; }
        List<Substance> ListOfAnimals;
        public int size;
        public int SolidNumber;
        public Random random;
        public BASE(int size, int solidCount, int solutionCount)
        {
            this.size = size;
            int x = 0;
            int y = 0;
            points = new Point[size, size];
            for (x = 0; x < size; x++)
            {
                for (y = 0; y < size; y++)
                {
                    points[x, y] = new Point(x, y);
                }
            }
            Searcher.SetMap(points);//искать,установить поле
            random = new Random();
            ShareOfGrass = size * size * PercentageOfGrassOnTheField / 100; //доля твердого
            BoxNumber = 0;
            Planting();
            ListOfAnimals = new List<Substance>(solidCount + solutionCount);
        }
    }
}



