using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vjezba5
{
    abstract class EnumHelper
    {
        public enum Gorivo
        {
            Dizel,
            Benzin
        };

        enum Hladenje
        {
            Jednozonsko,
            Dvozonsko,
            Cetverozonsko
        };

        enum Kocnice
        {
            Bubanj,
            Diskovi
        };

        enum MjenjacTip
        {
            Sequential,
            Tiptronic,
            Manual,
            Automatic,
            DualClutch
        };

    }
}
