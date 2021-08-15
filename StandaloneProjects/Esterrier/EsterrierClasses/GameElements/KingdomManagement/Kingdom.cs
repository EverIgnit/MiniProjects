namespace Esterrier.GameElements.KingdomManagement;
using KingdomParameters;
class Kingdom
{
    public KingdomStateParameter Population { get; init; }
    public KingdomStateParameter Economy { get; init; }
    public KingdomStateParameter Military { get; init; }
    public KingdomStateParameter Religion { get; init; }
    public Kingdom(KingdomStateParameter population, KingdomStateParameter economy,
        KingdomStateParameter military, KingdomStateParameter religion)
    {
        Population = population;
        Economy = economy;
        Military = military;
        Religion = religion;
    }
}
