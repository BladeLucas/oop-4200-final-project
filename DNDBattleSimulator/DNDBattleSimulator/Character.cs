using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDBattleSimulator
{
    class Character
    {
        private bool npc;
        private string name;

        // Character is an NPC property
        public bool NPC
        {
            get
            {
                return npc;
            }
            set
            {
                npc = value;
            }
        }

        // Read-only name property
        public string Name
        {
            get
            {
                return name;
            }
        }

        // Constructor
        public Character(string name, bool npc)
        {
            this.name = name;
            this.npc = npc;
        }
    }
}
