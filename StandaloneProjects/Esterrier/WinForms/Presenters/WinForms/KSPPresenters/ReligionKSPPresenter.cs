namespace Esterrier.Presenters.WinForms.KSPPresenters
{
    using System.Windows.Forms;
    using GameElements.KingdomManagement.KingdomParameters;
    public class ReligionKSPPresenter : KSPPresenter
    {
        // TODO: Указать путь
        private static string ImgPath { get; } = null;
        public ReligionKSPPresenter(PictureBox picBox, ProgressBar progBar, KingdomStateParameter ksp)
            : base(picBox, progBar, ksp, ImgPath) { }
    }
}
