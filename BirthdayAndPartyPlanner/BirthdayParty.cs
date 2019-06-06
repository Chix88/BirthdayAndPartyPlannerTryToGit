namespace BirthdayAndPartyPlanner
{
    class BirthdayParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecoration { get; set; }

        private const int CostOfFoodPerPerson = 25;

        private decimal cost { get; set; }

        public string CakeWriting;

        public bool IsCakeWritingTooLong
        {

            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }

        private int actualLenght
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                {
                    return MaxWritingLength();
                }
                else
                    return CakeWriting.Length;
            }
        }

        private int CakeSize()   //depands of the number of person
        {
            if (NumberOfPeople <= 4)
                return 8; //size 8 inch
            else
                return 16; // size 16 inch
        }
        private int MaxWritingLength() // depands oof the size of the cake
        {
            if (CakeSize() == 8)
                return 16;   // number of  letters that the cake can hold is 16
            else
                return 40;   // number of  letters that the cake can hold is 40
        }

        private decimal CalculateCostOfDecoration()
        {
            if (FancyDecoration)
            {
                return ((15m * NumberOfPeople) + 50m);
            }
            else
                return ((7.5m * NumberOfPeople) + 30m);
        }
        public BirthdayParty(int numberOfPeople, bool fancyDecoration, string cakeWriting)
        {
            this.NumberOfPeople = numberOfPeople;
            this.FancyDecoration = fancyDecoration;
            this.CakeWriting = cakeWriting;
        }

        public decimal Cost()
        {
            // 25 * nombre de personne
            // decoration 7.5/15 par personne + 30/50 de free total
            // tarte 40/75
            // ecriture sur latarte  0.25 * nombre de lettre

            decimal cakeprice;
            if (CakeSize() == 8)
                cakeprice = 40m + (actualLenght * 0.25m);
            else
                cakeprice = 75 + (actualLenght * 0.25m);



            return (25 * NumberOfPeople) + CalculateCostOfDecoration() + cakeprice;
            //250 +75 +75 +30
        }
    }
}

