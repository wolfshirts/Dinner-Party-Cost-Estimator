using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner_Party_Cost_Estimator
{
    class BirthdayParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public const decimal CostOfFoodPerPerson = 25M;
        public string CakeWriting { get; set; }
        
        public BirthdayParty(int numberOfPeople, bool fancyDecor, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecor;
            CakeWriting = cakeWriting;
        }

        private int ActualLength
        {
            get
            {
                if(CakeWriting.Length > MaxWritingLength())
                {
                    return MaxWritingLength();
                }
                else
                {
                    return CakeWriting.Length;
                }
            }
        }

        private int CakeSize()
        {
            if(NumberOfPeople <= 4)
            {
                return MaxWritingLength();
            }
            else
            {
                return CakeWriting.Length;
            }
        }

        private int MaxWritingLength()
        {
            if(CakeSize() == 8)
            {
                return 16;
            }
            else
            {
                return 40;
            }
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if(CakeWriting.Length > MaxWritingLength())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecor;
            if (FancyDecorations)
            {
                costOfDecor = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDecor = (NumberOfPeople * 7.50M) + 30M;
            }

            return costOfDecor;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40M + ActualLength * .25M;
                else
                    cakeCost = 75M + ActualLength * .25M;

                return totalCost + cakeCost;
            }
        }
    }
}
