namespace Esterrier.GameElements.GameWorld
{
    using KingdomManagement;
    class GameWorldInfo
    {
        public Kingdom UserKingdom { get; set; }
        public GameWorldInfo(Kingdom userKingdom)
        {
            UserKingdom = userKingdom;
        }
    }
}
