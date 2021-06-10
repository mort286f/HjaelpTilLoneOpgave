using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjaelpTilLoneOpgave
{
    class Wizard : ICharacter, IWizard
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

        public string Teleport(int x, int y)
        {
            return $"I'm teleporting to {x} and {y}";
        }

        public string ThrowFrostNova()
        {
            return "I'm throwing my Frost Nova!";
        }

        public string ThrowMagicMissile()
        {
            return "I'm throwing my Magic Missile!";
        }
    }
}
