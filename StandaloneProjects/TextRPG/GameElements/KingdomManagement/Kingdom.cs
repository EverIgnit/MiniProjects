namespace TextRPG.GameElements.KingdomManagement
{
    using KingdomParameters;
    class Kingdom
    {
        public PopulationKSP Population { get; set; }
        public EconomyKSP Economy { get; set; }
        public MilitaryKSP Military { get; set; }
        public ReligionKSP Religion { get; set; }
        public Kingdom()
        {

        }
    }
}
