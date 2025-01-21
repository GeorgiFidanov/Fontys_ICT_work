using System;
using System.Collections.Generic;

namespace Lottery
{
    public class Lottery
    {
        private int maxValue;
        private int numberOfWantedNumbers;
        private List<int> drawnNumbers;
        Random random = new Random();

        public Lottery(int maxValue, int numberOfWantedNumbers)
        {
            if (numberOfWantedNumbers > maxValue)
            {            
                throw new ArgumentException("Number of wanted numbers cannot be greater than the max value.");
            }

            this.maxValue = maxValue;
            this.numberOfWantedNumbers = numberOfWantedNumbers;
            drawnNumbers = new List<int>();
        }


        public void resetDrawnNumbers()
        {
            drawnNumbers.Clear();
        }

        public bool isLotteryFinished()
        {
            if (drawnNumbers.Count == numberOfWantedNumbers)
            {
                return true;
            }
            return false;
        }

        private int DrawUniqueNumber()
        {
            int number;
            do
            {
                number = random.Next(1, maxValue + 1);
            } while (drawnNumbers.Contains(number));

            if (!isLotteryFinished())
            {
                drawnNumbers.Add(number);
                return number;
            }
            return -1;
        }

        public List<int> DrawAllNumbers()
        {
            while (!isLotteryFinished())
            {
                DrawUniqueNumber();
            }
            return drawnNumbers;
        }

        public int DrawNextNumber()
        {
            if (!isLotteryFinished())
            {
                return DrawUniqueNumber();
            }
            return -1;
        }

        public void Reset()
        {
            drawnNumbers.Clear();
        }
    }
}