using System.Windows.Forms;
namespace TextRPG.GameElements.KingdomManagement.KingdomParameters
{
    class EconomyKSP : KingdomStateParameter
    {
        public EconomyKSP(ProgressBar progressBar, PictureBox pictureBox)
            : base(new("../../../Resources/kingdom/icons_KSP/economy"),pictureBox,progressBar)
        {

        }
    }
}
