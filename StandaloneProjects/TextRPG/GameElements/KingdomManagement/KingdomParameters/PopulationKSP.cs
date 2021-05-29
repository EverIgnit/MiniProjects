using System.Windows.Forms;
namespace TextRPG.GameElements.KingdomManagement.KingdomParameters
{
    class PopulationKSP : KingdomStateParameter
    {
        public PopulationKSP(ProgressBar progressBar, PictureBox pictureBox)
            : base(new("../../../Resources/kingdom/icons_KSP/population"), pictureBox, progressBar) 
        {

        }
    }
}
