using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Dinner_Party_Cost_Estimator
{
    class DinnerParty:Party
    {
        
        public bool HealthyOption { get; set; }
        public override decimal Cost
        {
            get
            {
                decimal cost = base.Cost;
                cost += (calculateCostOfBeveragesPerPerson() * NumberOfPeople);
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
