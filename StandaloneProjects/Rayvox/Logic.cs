using System;
using System.Collections.Generic;

namespace Rayvox
{
    public class Logic
    {
        static public Character Player = new Character(Settings.SX, Settings.SPoxY, Textures.Player_walk);
        static public Character Player2 = new Character(Settings.SX, Settings.SPoxY+100, Textures.Player_walk);
        static public List<Bullet> Bullets = new List<Bullet>();
        static public List<Ader> Aders = new List<Ader>();
        static public List<List<Mob>> Mobs = new List<List<Mob>>();
        // Новые координаты через полярную систему
        public static Tuple<int, int> NewCords(int x, int y, double deg, int speed)
        {
            return Tuple.Create(x + Convert.ToInt32(speed * Math.Cos(deg)), y + Convert.ToInt32(speed * Math.Sin(deg)));
        }
    }
}
