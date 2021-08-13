namespace Esterrier.Presenters.WinForms.KSPPresenters{
    using GameElements.KingdomManagement.KingdomParameters;
    using System.Windows.Forms;
    public abstract class KSPPresenter : PresenterPrototypes.KSPPresenterPrototype {
        private ProgressBar ProgBar { get; init; }
        private PictureBox PicBox { get; init; }
        public KSPPresenter(PictureBox picBox, ProgressBar progBar, KingdomStateParameter ksp, System.Drawing.Image image)
            : base(ksp)
        {
            ProgBar = progBar;
            ProgBar.Maximum = KSP.MaxValue;
            PicBox = picBox;
            PicBox.Image = image;
        }
        public KSPPresenter(PictureBox picBox, ProgressBar progBar, KingdomStateParameter ksp, string imgPath)
            :this(picBox, progBar, ksp, System.Drawing.Image.FromFile(imgPath)) { }
        public sealed override void DisplayKSPVal()
            => ProgBar.Value = KSP.Value;
    }
}