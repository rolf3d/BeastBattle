using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        private int ialt;
        private int tildeltskade  = 0;
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            

        NumberGenerator theNumberGenerator = new NumberGenerator();
            BattleLog theLog = new BattleLog();

            Hero theHero = new Hero(theNumberGenerator, theLog);
            Beast theBeast = new Beast(theNumberGenerator, theLog);


            // Now battle...How do we do that (Hint: You need a loop)
            // YOUR JOB: Insert code here to make theHero and theBeast battle

            //theNumberGenerator.GetRandomNumberInInterval(0, 100);
            while (theHero.IsDead() == false || theBeast.IsDead() == false)
            {

                Console.WriteLine("Skaden på helten: " + theHero.DealDamage());
                //ialt = theHero.DealDamage() - theBeast.DealDamage();
                //Console.WriteLine("Ialt : " + ialt);
                    
                theHero.ReceiveDamage(10);
                theBeast.ReceiveDamage(10);

            }
            if (theHero.IsDead() == true)
            {
                Console.WriteLine("Helten er død nu: ");
                Console.WriteLine(theHero.IsDead());
            }

            theLog.PrintEntireBattleLog();

            //Console.WriteLine("{0}", theNumberGenerator.GetRandomNumberInInterval(0, 100));
            

            
            // The LAST line of code should be ABOVE this line
        }
    }
}
