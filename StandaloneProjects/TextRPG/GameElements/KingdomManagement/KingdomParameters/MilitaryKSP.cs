using System.Windows.Forms;
namespace TextRPG.GameElements.KingdomManagement.KingdomParameters
{
    class MilitaryKSP : KingdomStateParameter
    {
        public MilitaryKSP(ProgressBar progressBar, PictureBox pictureBox) 
            : base(new("../../../Resources/kingdom/icons_KSP/military"), pictureBox, progressBar)
        {

        }
    }
}
