using System;
using TextRPG.GameElements.KingdomManagement.KingdomParameters;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRPG
{
    public partial class Esterrier : Form
    {
        private GameElements.GameWorld.GameWorldInfo GameWorld { get; init; } 
        public Esterrier()
        {
            InitializeComponent();
            GameWorld = new(new(new(populationProgressBar, populationPictureBox),
                new(economyProgressBar,economyPictureBox),
                new(militaryProgressBar,militaryPictureBox),
                new(religionProgressBar,religionPicturBox)));
        }

        private void Current_events_LB_MouseEnter(object sender, EventArgs e)
        {
            current_events_LB.Text =  new Random().Next().ToString();
            current_events_LB.BackColor = Color.Black;
        }
        private void Current_events_LB_MouseLeave(object sender, EventArgs e)
        {
            current_events_LB.BackColor = Color.FromArgb(128, Color.Black);
        }
    }
}
