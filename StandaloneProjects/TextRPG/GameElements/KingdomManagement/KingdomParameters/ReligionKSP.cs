using System.Windows.Forms;
namespace TextRPG.GameElements.KingdomManagement.KingdomParameters
{
    class ReligionKSP : KingdomStateParameter
    {
        /// <summary>
        /// TODO: заменить создание изображения через путь, на resourses.GetObject Смотри на Ecterrier.Designer.cs 32 строка и 201
        /// </summary>
        public ReligionKSP(ProgressBar progressBar, PictureBox pictureBox)
            : base(new("../../../Resources/kingdom/icons_KSP/religion"),pictureBox,progressBar)
        {

        }
    }
}
