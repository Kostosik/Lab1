//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PervayaLabaNaSharpe
//{
//    public class Fight : CharacterGroup
//    {
//        public Fight(int maxHealers1, int maxSoldiers1, int maxHealers2, int maxSoldiers2, int turnNum = 1)
//        {
//            this._turnNum = turnNum;
//            this.group1 = new CharacterGroup(maxHealers1, maxSoldiers1);
//            this.group2 = new CharacterGroup(maxHealers2, maxSoldiers2);
//        }

//        private CharacterGroup group1 { get { return group1; } set { group1 = value; } }
//        private CharacterGroup group2 { get { return group2; } set { group2 = value; } }
//        private int _turnNum { get { return _turnNum; } set { _turnNum = value; } }
//        public int getWinner()
//        {
//            if (group1.getSoldierAliveCount() + group1.getHealerAliveCount() <= 0)
//                return 2;
//            if (group2.getSoldierAliveCount() + group2.getHealerAliveCount() <= 0)
//                return 1;
//            return 0;

//        }
//        public void regeneration(CharacterGroup group)
//        {
//            for (uint i = 0; i < group.SoldierMaxCount() + group.HealerMaxCount() - 1; i++)
//            {
//                if ((*group.vectorMan[i]).getLifeStatus() == true)
//                {
//                    (*group.vectorMan[i].get()).healing(((Soldier)(*group.vectorMan[i])).getRegenerationPerTurn());
//                }
//            }
//        }
//        public void play(int typeCharacter, int typeAction, ref Soldier character, ref Soldier target)
//        {
//            if (_turnNum == 1)
//            {
//                if (typeCharacter == 1)
//                {
//                    character.punch(ref target);
//                }
//                else if (typeCharacter == 2)
//                {

//                    if (typeAction == 1)
//                    {
//                        character.punch(ref target);
//                    }
//                    else if (typeAction == 2)
//                    {
//                        Healer trg = *character.get() as Healer;
//                        if (trg == null)
//                        {
//                            throw std::bad_cast();
//                        }
//                        trg.heal(target);
//                    }
//                    else
//                    {
//                        throw new System.ArgumentException("Wrong action type");
//                    }
//                }
//                else
//                {
//                    throw new System.ArgumentException("Wrong character type");
//                }
//                _turnNum = 2;

//                regeneration(group1);
//                regeneration(group2);

//                return;
//            }
//            else if (_turnNum == 2)
//            {
//                if (typeCharacter == 1)
//                {
//                    (*character.get()).punch(target);
//                }
//                else if (typeCharacter == 2)
//                {
//                    if (typeAction == 1)
//                    {
//                        (*character.get()).punch(target);
//                    }
//                    else if (typeAction == 2)
//                    {
//                        Healer trg = *character.get() as Healer;
//                        if (trg == null)
//                        {
//                            throw std::bad_cast();
//                        }
//                        trg.heal(target);
//                    }
//                    else
//                    {
//                        throw new System.ArgumentException("Wrong action type");
//                    }
//                }
//                else
//                {
//                    throw new System.ArgumentException("Wrong character type");
//                }
//                _turnNum = 1;

//                regeneration(group1);
//                regeneration(group2);

//                return;
//            }
//            else
//            {
//                throw new System.ArgumentException("WRONG TURN NUM");
//            }
//        }
//    }
//}
