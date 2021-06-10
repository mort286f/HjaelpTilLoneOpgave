using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjaelpTilLoneOpgave
{
    interface IWizard
    {
        string Teleport(int x, int y);
        string ThrowFrostNova();
        string ThrowMagicMissile();
    }
}
