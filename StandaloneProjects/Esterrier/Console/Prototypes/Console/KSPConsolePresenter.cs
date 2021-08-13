namespace Esterrier.Presenters.Console.Prototypes.Console
{
    using GameElements.KingdomManagement.KingdomParameters;
    public class KSPConsolePresenter :
        PresenterPrototypes.KSPPresenterPrototype
    {
        private System.Text.StringBuilder DisplayStr { get; }
        public KSPConsolePresenter(KingdomStateParameter ksp, System.Text.StringBuilder displayStr)
        : base(ksp) => DisplayStr = displayStr;
        public override void DisplayKSPVal()
            => DisplayStr.AppendLine(KSP.Value.ToString());
    }
}
