namespace BirthdayAndPartyPlanner
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecoration { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool fancyDecoration, bool healthyOption)
        {
            this.NumberOfPeople = numberOfPeople;
            this.FancyDecoration = fancyDecoration;
            this.HealthyOption = healthyOption;

        }

        private decimal CalculateCosteOfDecoration()
        {
            if (FancyDecoration)
            {
                return (50m + (15m * NumberOfPeople));
            }
            else
            {
                return (30m + (7.5m * NumberOfPeople));
            }
        }

        private decimal CalculateCostOfBevaragePerPerson()
        {
            if (HealthyOption)
            {
                return 5m;
            }
            else
                return 20m;
        }
        public decimal Cost
        {
            get
            {
                var cost = 0m;
                cost = CalculateCosteOfDecoration();
                cost += ((CalculateCostOfBevaragePerPerson() + 25m) * NumberOfPeople);
                return cost;

            }
        }


    }
}
