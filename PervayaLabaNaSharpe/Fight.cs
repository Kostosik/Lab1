using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PervayaLabaNaSharpe
{
    public class Fight : CharacterGroup
    {
        public Fight(uint maxHealers1, uint maxSoldiers1, uint maxHealers2, uint maxSoldiers2, int turnNum = 1)
        {
            _turnNum = turnNum;
            group1 = new CharacterGroup(maxHealers1, maxSoldiers1);
            group2 = new CharacterGroup(maxHealers2, maxSoldiers2);
        }

        private CharacterGroup group1;
        private CharacterGroup group2;
        private int _turnNum;
        public int turnNum
        {
            get { return _turnNum; }
            set { _turnNum = value; }
        }
        public int getWinner()
        {
            if (group1.getSoldierAliveCount() + group1.getHealerAliveCount() <= 0)
                return 2;
            if (group2.getSoldierAliveCount() + group2.getHealerAliveCount() <= 0)
                return 1;
            return 0;

        }
        public void regeneration(CharacterGroup group)
        {
            for (int i = 0; i < group.SoldierMaxCount + group.HealerMaxCount - 1; i++)
            {
                if (group.vectorMan[i].lifeStatus == true)
                {
                    Soldier toHeal = group.vectorMan[i];
                    toHeal.takeHeal(toHeal.HPRegeneration);
                }
            }
        }
        public void play(int typeCharacter, int typeAction,Soldier character,Soldier target)
        {
            if (_turnNum == 1)
            {
                if (typeCharacter == 1)
                {
                    character.punch(target);
                }
                else if (typeCharacter == 2)
                {

                    if (typeAction == 1)
                    {
                        character.punch(target);
                    }
                    else if (typeAction == 2)
                    {
                        Healer trg = character as Healer;
                        if (trg == null)
                        {
                            throw new ArgumentNullException();
                        }
                        trg.heal(target);
                    }
                    else
                    {
                        throw new System.ArgumentException("Wrong action type");
                    }
                }
                else
                {
                    throw new System.ArgumentException("Wrong character type");
                }
                _turnNum = 2;

                regeneration(group1);
                regeneration(group2);

                return;
            }
            else if (_turnNum == 2)
            {
                if (typeCharacter == 1)
                {
                    character.punch(target);
                }
                else if (typeCharacter == 2)
                {
                    if (typeAction == 1)
                    {
                        character.punch(target);
                    }
                    else if (typeAction == 2)
                    {
                        Healer trg = character as Healer;
                        if (trg == null)
                        {
                            throw new ArgumentNullException();
                        }
                        trg.heal(target);
                    }
                    else
                    {
                        throw new System.ArgumentException("Wrong action type");
                    }
                }
                else
                {
                    throw new System.ArgumentException("Wrong character type");
                }
                _turnNum = 1;

                regeneration(group1);
                regeneration(group2);

                return;
            }
            else
            {
                throw new System.ArgumentException("WRONG TURN NUM");
            }
        }
    }
}
