using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaMirror
{
    class ChartOperation
    {
        /// <summary>
        /// Destructively applies this operation to the chart and returns it.
        /// </summary>
        /// <param name="chart">The chart to apply the operation to</param>
        /// <returns>The chart passed in</returns>
        public virtual CMap apply(CMap chart)
        {
            return chart;
        }
    }
}
