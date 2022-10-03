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
        protected string _name;//{ get { return Name; } set { Name = value; } }
        protected int _healthPoints;//{ get { return healthPoints; } set { healthPoints = value; } }
        protected int _maxHP;// { get { return MaxHP; } set { MaxHP = value; } }
        protected int _HPRegeneration;// { get { return HPRegeneration; } set { HPRegeneration = value; } }
        protected bool _lifeStatus;// { get { return lifeStatus; } set { lifeStatus = value; } }
        protected int _impactForce;// { get { return _impactForce; } set { _impactForce = value; } }

        public string name
        {
            get { return _name; }        
            set { _name = value; }  
        }
        public int healthPoints
        {
            get { return _healthPoints;}
            set { _healthPoints = value; }
        }
        public int maxHP
        {
            get { return _maxHP;}
            set {_maxHP = value;}
        }
        public int HPRegeneration
        {
            get { return _HPRegeneration;}
            set { _HPRegeneration = value; }
        }
        public bool lifeStatus
        {
            get { return _lifeStatus;}
            set { _lifeStatus = value;}
            
        }
        public int impactForce
        {
            get { return _impactForce; }
            set { _impactForce = value; }
        }
        public Soldier(string name = "Default Name", int maxHealth = 1, int healthRegeneration = 1, int impactForce = 1)
        {
            _name = name;
            _maxHP = maxHealth;
            _HPRegeneration = healthRegeneration;
            _lifeStatus = true;
            _healthPoints = maxHealth;
            _impactForce = impactForce;

            if (_name == "")
                throw new ArgumentException();
            if (_maxHP <= 0)
                throw new ArgumentException();
            if (_HPRegeneration <= 0)
                throw new ArgumentException();
            if (_impactForce <= 0)
                throw new ArgumentException();
        }

        protected internal void takeDamage(int damage)
        {
            _healthPoints -= damage;
            if (_healthPoints <= 0)
                _lifeStatus = false; //VMER
        }

        protected internal void takeHeal(int heal)
        {
            _healthPoints += heal;
            if (_healthPoints >= _maxHP) 
                _healthPoints = _maxHP;
        }

        public void punch(Soldier toPunch)
        {
            toPunch.takeDamage(_impactForce);
        }
}
}
