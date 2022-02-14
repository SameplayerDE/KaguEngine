using Microsoft.Xna.Framework;

namespace KaguEngine
{
    public static class KaguTime
    {
        public static float DeltaTimeF;
        public static double DeltaTimeD;

        public static void Update(GameTime gameTime)
        {
            DeltaTimeF = (float)gameTime.ElapsedGameTime.TotalSeconds;
            DeltaTimeD = gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}