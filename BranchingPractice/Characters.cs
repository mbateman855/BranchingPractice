using System;
using System.Collections.Generic;
using System.Text;

namespace BranchingPractice
{
    class Characters
    {
        public int Strength { get; set; }
        public int Vitality { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public bool HasMustache { get; set; }

        public Characters(int strength, int vitality, int intelligence, int dexterity, bool hasMustache)
        {
            Strength = strength;
            Vitality = vitality;
            Intelligence = intelligence;
            Dexterity = dexterity;
            HasMustache = hasMustache;
        }
    }
}
