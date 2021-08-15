namespace Esterrier.PresenterPrototypes;
using GameElements.KingdomManagement.KingdomParameters;
public abstract class KSPPresenterPrototype
{
    public KSPPresenterPrototype(KingdomStateParameter ksp)
        => KSP = ksp;
    protected KingdomStateParameter KSP { get; init; }
    public abstract void DisplayKSPVal();
}
