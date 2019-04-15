using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgram.Class
{
    class Calculation
    {

        public double CalculationPhysicalCondition (int pressureUp,  int pressureDown, int age, int growth, int weight, int puls)
        {
            double ADsr = pressureDown + ((pressureUp - pressureDown)/3f);
            double CPC = (700 - (3 * puls) - (2.5 * ADsr) - (2.7 * age) + (0.28 * weight))/ (350 - (2.6 * age) + (0.21 * growth));
            CPC *= 10;
            return CPC;
        }

        public double CalculationPowerCondictopn (int pushUp, int pullUps, int squats, int press, double m100)
        {
            double CPC = (pushUp + pullUps + squats + press) / (1.5 * m100);
            return CPC;
        }

    }
}
