using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Job_Sequencing
{
    public class ProfitComparer : IComparer<Job>
    {
        public int Compare([AllowNull] Job x, [AllowNull] Job y)
        {
            return x.Profit > y.Profit ? -1 : x.Profit == y.Profit ? 0 : 1;
        }
    }
}