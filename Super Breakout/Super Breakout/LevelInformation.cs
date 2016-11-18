using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Super_Breakout
{
    [Serializable]
    class LevelInformation
    {
        public string LevelName { get; set; }
        public int[,] BlockInfo { get; set; }
    }
}
