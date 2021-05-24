using System.Windows.Forms;
namespace TextRPG.GameElements.KingdomParameters
{
    abstract class KingdomStateParameter
    {
        private readonly int _maxValue = 10;
        private int _value;
        public ProgressBar ProgressBar { get; init; }
        public PictureBox PictureBox { get; init; }
        ImageKSP ImageKSP { get; init; }
        /// <summary>
        /// TODO: Change BackgroundImage to Image
        /// </summary>
        public KingdomStateParameter(ImageKSP imageKSP, PictureBox pictureBox, ProgressBar progressBar)
        {
            PictureBox = pictureBox;
            ProgressBar = progressBar;
            ImageKSP = imageKSP;
            ProgressBar.Maximum = _maxValue;
            PictureBox.BackgroundImage = ImageKSP.CurrentImage;
            Value = 5;
        }
        public int Value 
        {
            get => _value; 
            set
            {
                _value = value < 0 ? 0 : value > _maxValue ? _maxValue : value;
                ImageKSP.Refresh(_value);
                ProgressBar.Value = _value;
            }
        }
    }
}
