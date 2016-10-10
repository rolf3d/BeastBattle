using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            NumberGenerator theNumberGenerator = new NumberGenerator();
            BattleLog theLog = new BattleLog();

            Hero theHero = new Hero(theNumberGenerator, theLog);
            Beast theBeast = new Beast(theNumberGenerator, theLog);


            // Now battle...How do we do that (Hint: You need a loop)

            while (!theHero.IsDead() && !theBeast.IsDead())
            {
                // Let hero deal damage to beast:
                theBeast.ReceiveDamage(theHero.DealDamage());

                // Let beast deal damage to hero (if it is not dead...)
                if (!theBeast.IsDead())
                {
                    theHero.ReceiveDamage(theBeast.DealDamage());
                }
            }

            theLog.PrintEntireBattleLog();

            // The LAST line of code should be ABOVE this line
        }
    }
}
