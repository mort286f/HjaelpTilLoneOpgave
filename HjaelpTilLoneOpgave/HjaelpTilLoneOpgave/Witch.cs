using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjaelpTilLoneOpgave
{
    //The Witch class which has ICharacter and IWitch because it is both a Witch and a normal character
    class Witch : ICharacter, IWitch
    {
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
            return "I'm raising my shield!";
        }

        public string ShieldGlare()
        {
            return "I'm throwing Shield Glare";
        }

        public string Teleport(int x, int y)
        {
            return $"I'm teleporting to {x} and {y}";
        }
    }
}
