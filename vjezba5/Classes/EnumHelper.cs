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
        }

        public enum Hladenje
        {
            Jednozonsko,
            Dvozonsko,
            Cetverozonsko
        };

        public enum Kocnice
        {
            Bubanj,
            Diskovi
        };

        public enum MjenjacTip
        {
            Sequential,
            Tiptronic,
            Manual,
            Automatic,
            DualClutch
        };

    }
}
