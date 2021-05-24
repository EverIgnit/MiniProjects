using System.Windows.Forms;
namespace TextRPG.GameElements.KingdomParameters
{
    class MilitaryKSP : KingdomStateParameter
    {
        public MilitaryKSP(ProgressBar progressBar, PictureBox pictureBox) 
            : base(new("../../../Resources/militaryKSP"), pictureBox, progressBar)
        {

        }
    }
}
