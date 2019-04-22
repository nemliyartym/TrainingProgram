using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgram.Class
{
    class Condition
    {
        DataFromWindows dataFromWindows = new DataFromWindows();

        public string GetConditionMan(double Phc)
        {
            string isResult = null;
            if (Phc >= dataFromWindows.LowMan[0] && Phc <= dataFromWindows.LowMan[1])
                isResult = "Низкий";
            else if (Phc >= dataFromWindows.LowMiddleMan[0] && Phc <= dataFromWindows.LowMiddleMan[1])
                isResult = "Ниже среднего";
            else if (Phc >= dataFromWindows.MiddleMan[0] && Phc <= dataFromWindows.MiddleMan[1])
                isResult = "Средний";
            else if (Phc >= dataFromWindows.HighMiddleMan[0] && Phc <= dataFromWindows.HighMiddleMan[1])
                isResult = "Выше среднего";
            else if (Phc >= dataFromWindows.HighMan[0] && Phc <= dataFromWindows.HighMan[1])
                isResult = "Высокий";
            return isResult;
        }

        public string GetConditionWoman(double Phc)
        {
            string isResult = null;
            if (Phc >= dataFromWindows.LowWoman[0] && Phc <= dataFromWindows.LowWoman[1])
                isResult = "Низкий";
            else if (Phc >= dataFromWindows.LowMiddleWoman[0] && Phc <= dataFromWindows.LowMiddleWoman[1])
                isResult = "Ниже среднего";
            else if (Phc >= dataFromWindows.MiddleWoman[0] && Phc <= dataFromWindows.MiddleWoman[1])
                isResult = "Средний";
            else if (Phc >= dataFromWindows.HighMiddleWoman[0] && Phc <= dataFromWindows.HighMiddleWoman[1])
                isResult = "Выше среднего";
            else if (Phc >= dataFromWindows.HighWoman[0] && Phc <= dataFromWindows.HighWoman[1])
                isResult = "Высокий";
            return isResult;
        }
    }
}
