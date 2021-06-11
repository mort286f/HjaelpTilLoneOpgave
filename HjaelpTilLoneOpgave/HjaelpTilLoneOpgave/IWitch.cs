using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjaelpTilLoneOpgave
{
    //This interface holds all methods for the Witch character
    interface IWitch
    {
        string RaiseShield();
        string ShieldGlare();
        string Teleport(int x, int y);
    }
}
