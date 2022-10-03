using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PervayaLabaNaSharpe
{
    public class CharacterGroup
    {
        public CharacterGroup(uint healerMaxCount = 1, uint soldierMaxCount = 1, int characterTurn = 0)
        {
            _healerMaxCount = healerMaxCount;
            _soldierMaxCount = soldierMaxCount;
            _characterTurn = characterTurn;
            _soldierCount = soldierMaxCount;
            _healerCount = healerMaxCount;
            vectorMan = new List<Soldier>((int)(soldierMaxCount+ healerMaxCount));

        }

        private uint _healerMaxCount;
        private uint _soldierMaxCount;
        private uint _soldierCount;
        private uint _healerCount;
        private int _characterTurn;
        public List<Soldier> vectorMan;

        public uint HealerMaxCount
        {
            get { return _healerMaxCount; }
            set { _healerMaxCount = value; }
        }
        public uint SoldierMaxCount
        {
            get { return _soldierMaxCount; }
            set { _soldierMaxCount = value; }
        }
        public uint soldierCount
        {
            get { return _soldierCount; }
            set
            {
                _soldierCount = value;
            }
        }
        public uint healerCount
        {
            get { return _healerCount; }
            set { _healerCount = value; }
        }
        public int CharacterTurn
        {
            get { return _characterTurn; }
            set
            {
                _characterTurn = value;
            }
        }

        public void addMan(Soldier toAdd)
        {
            if (toAdd == null)
            {
                throw new ArgumentNullException("Null soldier");
            }
            vectorMan.Add(toAdd);
        }
        public uint getSoldierAliveCount()
        {
            uint defaultCount = 0;
            for (int i = 0; i < _soldierMaxCount; i++)
            {
                if ((vectorMan[i] is Soldier) && (vectorMan[i].lifeStatus==true))
                    defaultCount++;
            }
            return defaultCount;
        }
        public uint getHealerAliveCount()
        {
            uint healerCount = 0;
            for (int i = (int)_soldierMaxCount; i < _healerMaxCount + _soldierMaxCount; i++)
            {
                if ((vectorMan[i] is Healer) && (vectorMan[i].lifeStatus == true))
                    healerCount++;
            }
            return healerCount;
        }

        public void createMan(string name, int maxHealth, int impactForce, int regenerationPerTurn, int healForce = 0)
        {
            if (healForce != 0)
            {
                Soldier toAdd = new Healer(name, maxHealth, impactForce, regenerationPerTurn, healForce);
                vectorMan.Add(toAdd);
            }
            else
            {
                Soldier toAdd = new Soldier(name, maxHealth, impactForce, regenerationPerTurn);
                vectorMan.Add(toAdd);
            }
        }
        public uint getSoldierInArrayCount()
        {
            uint counter = 0;
            for (int i = 0; i < _soldierCount; i++)
            {
                if (vectorMan[i] != null)
                    counter++;
            }
            return counter;
        }
        public uint getHealerInArrayCount()
        {
            uint counter = 0;
            for (int i = (int)_soldierCount; i < soldierCount + healerCount; i++)
            {
                if (vectorMan[i] != null)
                    counter++;
            }
            return counter;
        }
    }
}