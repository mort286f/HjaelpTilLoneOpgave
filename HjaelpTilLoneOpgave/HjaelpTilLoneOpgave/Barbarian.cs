using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjaelpTilLoneOpgave
{
    //The barbarian class which has ICharacter and IBarbarian because it is both a barbarian and a normal character
    class Barbarian : ICharacter, IBarbarian
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
        public string Bash()
        {
            return "I'm bashing someone";
        }

        public string Cleave()
        {
            return "I'm cleaving someone";
        }


        public string Slash()
        {
            return "I'm slashing someone";
        }
    }
}
