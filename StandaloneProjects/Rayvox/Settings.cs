namespace Rayvox
{
    class Settings
    {
        //=-=-=-=-=-=-=<ИГРА>=-=-=-=-=-=-=
        public static int Width = 1024;
        public static int Height = 640;
        public static bool MouseMode = false;
        //=-=-=-=-=-=-=</ИГРА>=-=-=-=-=-=-=
        //=-=-=-=-=-=-=<ИГРОК>=-=-=-=-=-=-=
        public static byte PlayerSize = 60;
        public static byte PlayerSpeed = 10;
        // Позиция спавна
        public const short SX = 20;
        public const short SPoxY = 20;
        //=-=-=-=-=-=-=</ИГРОК>=-=-=-=-=-=-=
        //=-=-=-=-=-=-=<ПУЛЯ>=-=-=-=-=-=-=-=
        // Параметры пули
        public const byte BulletSize = 10;
        public const ushort BulletSpeed = 50;
        //=-=-=-=-=-=-=</ПУЛЯ>=-=-=-=-=-=-=-=
        //=-=-=-=-=-=-=<МОБЫ>=-=-=-=-=-=-=-=
        public const byte MobSize = 45;
        //=-=-=-=-=-=-=</МОБЫ>=-=-=-=-=-=-=-=
    }
}
