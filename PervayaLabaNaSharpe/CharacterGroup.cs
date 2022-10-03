//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Numerics;

//namespace PervayaLabaNaSharpe
//{
//    public class CharacterGroup
//    {
//        public CharacterGroup(uint healerMaxCount = 1, uint soldierMaxCount = 1, int characterTurn = 0)
//        {
//            this._healerMaxCount = healerMaxCount;
//            this._soldierMaxCount = soldierMaxCount;
//            this._characterTurn = characterTurn;
//            this.soldierCount = soldierMaxCount;
//            this.healerCount = healerMaxCount;
//        }

//        private uint _healerMaxCount { get { return _healerMaxCount; } set { _healerMaxCount = value; } }
//        private uint _soldierMaxCount { get { return _soldierMaxCount; } set { _soldierMaxCount = value; } }
//        private uint soldierCount { get; set; }
//        private uint healerCount { get; set; }
//        private int _characterTurn { get; set; }

//        public List<Soldier> vectorMan = new List<Soldier>();
//        public void addMan(Soldier toAdd)
//        {
//            if (toAdd == null)
//            {
//                throw std::bad_weak_ptr();
//            }
//            vectorMan.Add(std::move(toAdd));
//        }
//        public uint getSoldierAliveCount()
//        {
//            uint defaultCount = 0;
//            for (int i = 0; i < _soldierMaxCount; i++)
//            {
//                if ((*vectorMan[i].get()).getLifeStatus() == true)
//                    defaultCount++;
//            }
//            return defaultCount;
//        }
//        public uint getHealerAliveCount()
//        {
//            uint healerCount = 0;
//            for (uint i = _soldierMaxCount; i < _healerMaxCount + _soldierMaxCount; i++)
//            {
//                if ((*vectorMan[i].get()).getLifeStatus() == true)
//                    healerCount++;
//            }
//            return healerCount;
//        }

//        public void createMan(string name, int maxHealth, int impactForce, int regenerationPerTurn, int healForce = 0)
//        {
//            if (healForce != 0)
//            {
//                Soldier toAdd = new Healer(name, maxHealth, impactForce, regenerationPerTurn, healForce);
//                vectorMan.Add(std::move(toAdd));
//            }
//            else
//            {
//                Soldier toAdd = new Soldier(name, maxHealth, impactForce, regenerationPerTurn);
//                vectorMan.Add(std::move(toAdd));
//            }
//        }
//        public uint getSoldierInArrayCount()
//        {
//            uint counter = 0;
//            for (int i = 0; i < soldierCount; i++)
//            {
//                if (vectorMan[i] != null)
//                    counter++;
//            }
//            return counter;
//        }
//        public uint getHealerInArrayCount()
//        {
//            uint counter = 0;
//            for (uint i = soldierCount; i < soldierCount + healerCount; i++)
//            {
//                if (vectorMan[i] != null)
//                    counter++;
//            }
//            return counter;
//        }
//    }
//}