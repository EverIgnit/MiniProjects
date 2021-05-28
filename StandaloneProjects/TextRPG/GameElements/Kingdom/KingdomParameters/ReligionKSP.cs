using System.Windows.Forms;
namespace TextRPG.GameElements.Kingdom.KingdomParameters
{
    class ReligionKSP : KingdomStateParameter
    {
        public ReligionKSP(ProgressBar progressBar, PictureBox pictureBox)
            : base(new("../../../Resources/religionKSP"),pictureBox,progressBar)
        {

        }
    }
}
