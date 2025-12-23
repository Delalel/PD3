using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstr
{
    class MetalCalculator
    {
        public static double CalculateFencePerSection(double width, double length)
        {
            return 4 * length + 2 * width;
        }

        public static double CalculateTotalFenceLength(double width, double length, int sectionsCount)
        {
            if (sectionsCount <= 0) throw new ArgumentException("Количество секций должно быть положительным.");
            return CalculateFencePerSection(width, length) * sectionsCount;
        }

        public static double CalculateGatePerUnit(double width, double length)
        {
            double diagonal = Math.Sqrt(width * width + length * length);
            double crossbar = width / 2; // перекладина от центра до правого края
            return 2 * length + 2 * width + diagonal + crossbar;
        }

        public static double CalculateTotalGateLength(double width, double length, int gateCount = 2)
        {
            return CalculateGatePerUnit(width, length) * gateCount;
        }

        public static double CalculateTableFrameLength(double width, double length)
        {
            return 2 * (width + length);
        }


    }
}
