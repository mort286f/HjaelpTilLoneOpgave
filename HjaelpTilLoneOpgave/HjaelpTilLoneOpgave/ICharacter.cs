using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjaelpTilLoneOpgave
{
    //This interface holds all methods every character has. Including self-healing
    interface ICharacter
    {
        string Die();
        string Fight();
        string Heal();
    }
}
