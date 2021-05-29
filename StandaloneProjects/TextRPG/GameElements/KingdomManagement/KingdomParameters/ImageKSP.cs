using System;
using System.Linq;
using System.IO;
using System.Drawing;

namespace TextRPG.GameElements.KingdomManagement.KingdomParameters
{
    class ImageKSP
    {
        public Image CurrentImage { get; set; }
        Image[] ImagesByState { get; init; }
        public ImageKSP(Image[] imagesByState)
        {
            /*if (imagesByState.Length != 10)
                throw new ArgumentException("A bitmap array should contain 10 elements");*/
            ImagesByState = imagesByState;
            CurrentImage = ImagesByState[0];
        }
        public ImageKSP(string directoryWithImagesName) 
            : this(new DirectoryInfo(
                directoryWithImagesName)
                  .GetFiles()
                  .Select(fileName => Image.FromFile(fileName.FullName))
                  .ToArray())
        {
            //Directory.GetFiles(directoryWithImagesName);
        }
        /// <summary>
        /// TODO: Change logic
        /// </summary>
        public void Refresh(int kspValue)
        {
            CurrentImage = ImagesByState[0];
        }
    }
}
