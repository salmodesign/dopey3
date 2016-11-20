using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopeyWar
{
    public interface IScaleable
    {
        int PosX { get; set; }
        int PosY { get; set; }
        string Name { get; }
    }
}
