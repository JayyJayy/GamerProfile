using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GamerProfileWebApplication
{
    public static class Constants
    {
        public enum Platform
        {
            [Description("Xbox")]
            xbl,
            [Description("PC")]
            pc,
            [Description("Playstation")]
            psn
        }

        public enum Region
        {
            us,
            eu,
            kr,
            cn,
            global
        }
    }
}
