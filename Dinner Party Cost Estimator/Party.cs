using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner_Party_Cost_Estimator
{
    class Party
    {
        public const decimal CostOfFoodPerPerson = 25M;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                if (NumberOfPeople > 12)
                    totalCost += 100;
                return totalCost;
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
    }
}
