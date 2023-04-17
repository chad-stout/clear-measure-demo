using ClearMeasureDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearMeasureDemo.Library
{
    public interface IRickyBobby
    {
        IEnumerable<string> Execute(int upperBound);
    }
}
