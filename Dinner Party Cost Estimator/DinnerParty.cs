using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Dinner_Party_Cost_Estimator
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal Cost
        {
            get
            {
                decimal cost = calculateCostOfDecorations();
                cost += ((calculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                {
                    cost *= .95M;
                }
                return cost;
            }
        }
        
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecoration)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecoration;
        }

        private decimal calculateCostOfDecorations()
        {
            decimal costOfDec;
            if (FancyDecorations)
            {
                costOfDec = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDec = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfDec;
        }

        private decimal calculateCostOfBeveragesPerPerson()
        {
            decimal bevCost;
            if (HealthyOption)
            {
                bevCost = 5.00M;
            }
            else
            {
                bevCost = 20.00M;
            }
            return bevCost;
        }


    }
}
