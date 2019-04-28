using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgram.Class
{
    class Condition
    {

        private double[] LowMan = new double[] { Double.MinValue, 3.765 };
        private double[] LowMiddleMan = new double[] { 3.766, 5.265 };
        private double[] MiddleMan = new double[] { 5.266, 6.765 };
        private double[] HighMiddleMan = new double[] { 6.766, 8.265 };
        private double[] HighMan = new double[] { 8.266, Double.MaxValue };

        private double[] LowWoman = new double[] { Double.MinValue, 2.600 };
        private double[] LowMiddleWoman = new double[] { 2.610, 3.665 };
        private double[] MiddleWoman = new double[] { 3.666, 4.765 };
        private double[] HighMiddleWoman = new double[] { 4.766, 5.765 };
        private double[] HighWoman = new double[] { 5.766, Double.MaxValue };


        public string GetCondition (int lvl)
        {
            string condition = null;
            if (lvl == 1)
                condition = "Низкий";
            else if (lvl == 2)
                condition = "Ниже среднего";
            else if (lvl == 3)
                condition = "Средний";
            else if (lvl == 4)
                condition = "Выше среднего";
            else if (lvl == 5)
                condition = "Высокий";
            return condition;
        }

        public int GetLvl(string condition)
        {
            int lvl = 0;
            if (condition == "Низкий")
                lvl = 1;
            else if (condition == "Ниже среднего")
                lvl = 2;
            else if (condition == "Средний")
                lvl = 3;
            else if (condition == "Выше среднего")
                lvl = 4;
            else if (condition == "Высокий")
                lvl = 5;
            return lvl;
        }

        public string GetConditionMan(double ppParam, string gender)
        {
            string isResult = null;
            if (gender == "Мужской")
            {
                if (ppParam >= LowMan[0] && ppParam <= LowMan[1])
                    isResult = "Низкий";
                else if (ppParam >= LowMiddleMan[0] && ppParam <= LowMiddleMan[1])
                    isResult = "Ниже среднего";
                else if (ppParam >= MiddleMan[0] && ppParam <= MiddleMan[1])
                    isResult = "Средний";
                else if (ppParam >= HighMiddleMan[0] && ppParam <= HighMiddleMan[1])
                    isResult = "Выше среднего";
                else if (ppParam >= HighMan[0] && ppParam <= HighMan[1])
                    isResult = "Высокий";
            }
            else if(gender == "Женский")
            {
                if (ppParam >= LowWoman[0] && ppParam <= LowWoman[1])
                    isResult = "Низкий";
                else if (ppParam >= LowMiddleWoman[0] && ppParam <= LowMiddleWoman[1])
                    isResult = "Ниже среднего";
                else if (ppParam >= MiddleWoman[0] && ppParam <= MiddleWoman[1])
                    isResult = "Средний";
                else if (ppParam >= HighMiddleWoman[0] && ppParam <= HighMiddleWoman[1])
                    isResult = "Выше среднего";
                else if (ppParam >= HighWoman[0] && ppParam <= HighWoman[1])
                    isResult = "Высокий";
            }
            return isResult;
        }
    }
}
