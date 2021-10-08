using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделирование_процесса_растворения_твердых_тел
{
    static class Searcher
    {
        private static Point[,] points;
        private static int size;

        /// <summary>
        /// Устанавливает массив точек, в котором будет производить поиск
        /// </summary>
        /// <param name="_points"></param>
        public static void SetMap(Point[,] _points)
        {
            points = _points;
            size = points.GetLength(0);
        }

        /// <summary>
        /// Ищет все свободные клетки на дистанции 2
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static List<Point> GetFreePoints(Point point)
        {
            List<Point> pointList = new List<Point>();
            int newX;
            int newY;
            for (int y = 0; y <= 2; y++)
            {
                for (int x = y - 2; x <= 2 - y; x++)
                {
                    newX = point.X + x;
                    newY = point.Y + y;
                    if (newX < 0 || newX >= size || newY < 0 || newY >= size) { continue; }//проверка на нахождение точки в области поля
                    if (points[newX, newY].IsRabbit || points[newX, newY].IsWolf) { continue; }//проверка на отсутствие других животных на поле
                    pointList.Add(points[newX,
                    newY]);
                }
            }
            for (int y = -1; y >= -2; y--)
            {
                for (int x = -2 - y; x <= y + 2; x++)
                {
                    newX = point.X + x;
                    newY = point.Y + y;
                    if (newX < 0 || newX >= size || newY < 0 || newY >= size) { continue; }//проверка на нахождение точки в области поля
                    if (points[newX, newY].IsRabbit || points[newX, newY].IsWolf) { continue; }//проверка на отсутствие других животных на поле
                    pointList.Add(points[newX, newY]);
                }
            }
            return pointList;
        }

        /// <summary>
        /// Ищет свободные клетки на дистанции 1
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static List<Point> GetFreePointsOne(Point point)
        {
            List<Point> pointList = new List<Point>();
            int newX;
            int newY;
            for (int y = 0; y <= 1; y++)
            {
                for (int x = y - 1; x <= 1 - y; x++)
                {
                    newX = point.X + x;
                    newY = point.Y + y;
                    if (newX < 0 || newX >= size || newY < 0 || newY >= size) { continue; }//проверка на нахождение точки в области поля
                    if (points[newX, newY].IsRabbit || points[newX, newY].IsWolf) { continue; }//проверка на отсутствие других животных на поле
                    pointList.Add(points[newX, newY]);
                }
            }
            for (int y = -1; y >= -1; y--)
            {
                for (int x = -1 - y; x <= y + 1; x++)
                {
                    newX = point.X + x;
                    newY = point.Y + y;
                    if (newX < 0 || newX >= size || newY < 0 || newY >= size) { continue; }//проверка на нахождение точки в области поля
                    if (points[newX, newY].IsRabbit || points[newX, newY].IsWolf) { continue; }//проверка на отсутствие других животных на поле
                    pointList.Add(points[newX, newY]);
                }
            }
            return pointList;
        }
    }
