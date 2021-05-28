using System.Windows.Forms;
namespace TextRPG.GameElements.Kingdom.KingdomParameters
{
    class EconomyKSP : KingdomStateParameter
    {
        public EconomyKSP(ProgressBar progressBar, PictureBox pictureBox)
            : base(new("../../../Resources/economyKSP"),pictureBox,progressBar)
        {

        }
    }
}
