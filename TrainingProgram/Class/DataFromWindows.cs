using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgram.Class
{
    class DataFromWindows
    {
        public double[] LowMan = new double[] { Double.MinValue, 3.765};
        public double[] LowMiddleMan = new double[] { 3.766, 5.265 };
        public double[] MiddleMan = new double[] { 5.266, 6.765 };
        public double[] HighMiddleMan = new double[] { 6.766, 8.265 };
        public double[] HighMan = new double[] { 8.266, Double.MaxValue};

        public double[] LowWoman = new double[] { Double.MinValue, 2.600 };
        public double[] LowMiddleWoman = new double[] { 2.610, 3.665 };
        public double[] MiddleWoman = new double[] { 3.666, 4.765 };
        public double[] HighMiddleWoman = new double[] { 4.766, 5.765 };
        public double[] HighWoman = new double[] { 5.766, Double.MaxValue};

    }
}
