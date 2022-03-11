using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling_Simulator
{
	public class GamblingSimulator

	{
        const int final  STAKE_PER_DAY= 100;
        const int final  BET_PER_GAME = 1;
        const int final  WIN = 1;
        const int stake = 0;
        const int daysWonCount = 0;
        const int daysLostCount = 0;

        public static void winCheck()
        {
            Random random = new Random();
            int betReturns = random.Next(2);
            if (betReturns == WIN)
            {
                stake++;// incrementing
            }
            else
            {
                stake--;// decrementing
            }

        }

        public static void resignDayCheck()
        {
            int totalStake = 0;
            while (stake != 50 && stake != -50)
            {
                winCheck();
            }
            int STAKE_PER_DAY = 0;
            totalStake = stake + STAKE_PER_DAY;
           Console.WriteLine("Total stake for resign for a day is  " + totalStake);

        }


    }
}
    
}
