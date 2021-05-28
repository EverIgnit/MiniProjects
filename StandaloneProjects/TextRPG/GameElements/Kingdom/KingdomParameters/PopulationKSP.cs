using System.Windows.Forms;
namespace TextRPG.GameElements.Kingdom.KingdomParameters
{
    class PopulationKSP : KingdomStateParameter
    {
        public PopulationKSP(ProgressBar progressBar, PictureBox pictureBox)
            : base(new("../../../Resources/populationKSP"), pictureBox, progressBar) 
        {

        }
    }
}
