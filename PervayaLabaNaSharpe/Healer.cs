using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PervayaLabaNaSharpe
{
    public class Healer : Soldier
    {
        private int _healForce { get { return _healForce; } set { _healForce = value; } }
        Healer(string Name, int maxHealth, int impactForce, int healthRegeneration, int healForce)
        :base (Name, maxHealth, healthRegeneration, impactForce)
        {
            _healForce = healForce;
        }
        
        public void heal(Soldier toHeal)
        {
            toHeal.takeHeal(_healForce);
        }
}
}
