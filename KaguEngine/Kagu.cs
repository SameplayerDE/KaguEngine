using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KaguEngine
{
    public static class Kagu
    {

        public static KaguDataManager<string, Texture2D> Texture2DManager;

        public static void Init()
        {
            Texture2DManager = new KaguDataManager<string, Texture2D>();
        }
        
        public static void Update(GameTime gameTime)
        {
            KaguTime.Update(gameTime);
        }
    }
}