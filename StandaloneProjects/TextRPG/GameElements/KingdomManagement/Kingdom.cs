namespace TextRPG.GameElements.KingdomManagement
{
    using KingdomParameters;
    class Kingdom
    {
        public PopulationKSP Population { get; init; }
        public EconomyKSP Economy { get; init; }
        public MilitaryKSP Military { get; init; }
        public ReligionKSP Religion { get; init; }
        public Kingdom(PopulationKSP population, EconomyKSP economy, MilitaryKSP military, ReligionKSP religion)
        {
            Population = population;
            Economy = economy;
            Military = military;
            Religion = religion;
        }
    }
}
