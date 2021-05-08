using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Rayvox
{
    public partial class Rayvox : Form
    {
        public Rayvox()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }
        //=-=-=-=-=-=-=<ЗАГРУЗКА>=-=-=-=-=-=-=-=
        private void Rayvox_Load(object sender, EventArgs e)
        {
            Width = Settings.Width;
            Height = Settings.Height;
            Logic.Aders.Add(new Ader(200, 200));
            // TODO: Узнать, как избавиться от заглушки
            Logic.Mobs.Add(new List<Mob>(Logic.Aders));
        }
        //=-=-=-=-=-=-=</ЗАГРУЗКА>=-=-=-=-=-=-=-=
        //=-=-=-=-=-=-=<УПРАВЛЕНИЕ>=-=-=-=-=-=-=
        private void Rayvox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case ControlSettings.Player_Left:
                    Logic.Player.MoveLeft();
                    break;
                case ControlSettings.Player_Right:
                    Logic.Player.MoveRight();
                    break;
                case ControlSettings.Player_Down:
                    Logic.Player.MoveDown();
                    break;
                case ControlSettings.Player_Up:
                    Logic.Player.MoveUp();
                    break;
            }
            if (e.KeyCode == ControlSettings.Player_Shoot)
                    Logic.Player.Shoot();
            if (!Settings.MouseMode)
            {
                if (e.KeyCode == ControlSettings.Player2_Shoot)
                    Logic.Player2.Shoot();
                switch (e.KeyCode)
                {
                    case ControlSettings.Player2_Left:
                        Logic.Player2.MoveLeft();
                        break;
                    case ControlSettings.Player2_Right:
                        Logic.Player2.MoveRight();
                        break;
                    case ControlSettings.Player2_Down:
                        Logic.Player2.MoveDown();
                        break;
                    case ControlSettings.Player2_Up:
                        Logic.Player2.MoveUp();
                        break;
                }
            }
        }
        //=-=-=-=-=-=-=</УПРАВЛЕНИЕ>=-=-=-=-=-=-=
        //=-=-=-=-=-=-=<АНИМАЦИИЯ>=-=-=-=-=-=-=-=
        // Сама логика анимации
        static public void AnimateImage(Bitmap animatedImage, Character c)
        {
            if (c.CurrentlyAnimating)
                return;
            ImageAnimator.Animate(animatedImage, new EventHandler(OnFormChanged));
            c.CurrentlyAnimating = true;
        }
        // Для метода AnimateImage
        static void OnFormChanged(object o, EventArgs e)
        {
            ActiveForm.Invalidate();
        }
        //=-=-=-=-=-=-=</АНИМАЦИИЯ>=-=-=-=-=-=-=
        //=-=-=-=-=-=-=<ОТРИСОВКА>=-=-=-=-=-=-=-=
        // Главная функция отрисовки
        protected override void OnPaint(PaintEventArgs e)
        {
            Logic.Player.Draw(e);
            if(!Settings.MouseMode)
                Logic.Player2.Draw(e);
            DrawMobs(e);
            DrawBullets(e);
            base.OnPaint(e);
        }
        static void DrawMobs(PaintEventArgs e)
        {
            foreach(List<Mob> Mobs in Logic.Mobs)
                foreach(Mob Mob in Mobs)
                    Mob.Draw(e);
        }
        static void DrawBullets(PaintEventArgs e)
        {
            for (int i = 0; i < Logic.Bullets.Count; i++)
            {
                Logic.Bullets[i].Move();
                foreach (List<Mob> mobs in Logic.Mobs)
                    for (int j = 9; j < mobs.Count; j++)
                        if (Logic.Bullets[i].Touches(mobs[i]) == true)
                            if (!mobs[i].RecieveDmg(Logic.Bullets[i].ShooterDamage))
                                mobs.RemoveAt(j);
                Logic.Bullets[i].Draw(e);
                if (Logic.Bullets[i].X > Settings.Width || Logic.Bullets[i].X < 0 || Logic.Bullets[i].Y > Settings.Height || Logic.Bullets[i].Y < 0)
                    Logic.Bullets.RemoveAt(i);
            }
        }
        //=-=-=-=-=-=-=</ОТРИСОВКА>=-=-=-=-=-=-=
    }
}
/*
 * TODO:
 * Обработать одновременное нажатие кнопок
 */
