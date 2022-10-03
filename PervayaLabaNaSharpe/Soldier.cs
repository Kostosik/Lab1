using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace PervayaLabaNaSharpe
{
    public class Soldier
    {
        protected internal string Name;//{ get { return Name; } set { Name = value; } }
        public int healthPoints;//{ get { return healthPoints; } set { healthPoints = value; } }
        protected internal int MaxHP;// { get { return MaxHP; } set { MaxHP = value; } }
        protected internal int HPRegeneration;// { get { return HPRegeneration; } set { HPRegeneration = value; } }
        protected internal bool lifeStatus;// { get { return lifeStatus; } set { lifeStatus = value; } }
        protected internal int _impactForce;// { get { return _impactForce; } set { _impactForce = value; } }

        public Soldier(string name = "Deafult Name", int maxHealth = 1, int healthRegeneration = 1, int impactForce = 1)
        {
            Name = name;
            MaxHP = maxHealth;
            HPRegeneration = healthRegeneration;
            lifeStatus = true;
            healthPoints = maxHealth;
            _impactForce = impactForce;

            if (name == "")
                throw new ArgumentException();
            if (MaxHP <= 0)
                throw new ArgumentException();
            if (HPRegeneration <= 0)
                throw new ArgumentException();
            if (_impactForce <= 0)
                throw new ArgumentException();
        }

        protected internal void takeDamage(int damage)
        {
            healthPoints -= damage;
            if (healthPoints <= 0)
                lifeStatus = false; //VMER
        }

        protected internal void takeHeal(int heal)
        {
            healthPoints += heal;
            if (healthPoints >= MaxHP) healthPoints = MaxHP;
        }

        public void punch(Soldier toPunch)
        {
            toPunch.takeDamage(_impactForce);
        }
}
}
