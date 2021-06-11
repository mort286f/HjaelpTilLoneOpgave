using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjaelpTilLoneOpgave
{
    //The Knight class which has ICharacter and IKnight because it is both a Knight and a normal character
    class Knight : ICharacter, IKnight
    {
        public string Bash()
        {
            return "I'm slashing someone";
        }

        public string Cleave()
        {
            return "I'm cleaving someone";
        }

        public string Die()
        {
            return "I'm dying";
        }

        public string Fight()
        {
            return "I'm fighting";
        }

        public string Heal()
        {
            return "I'm healing";
        }

        public string RaiseShield()
        {
            return "I'm raising my shield";
        }

        public string ShieldGlare()
        {
            return "I'm throwing Shield Glare";
        }

        public string Slash()
        {
            return "I'm slashing someone";
        }
    }
}
