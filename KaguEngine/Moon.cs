using KaguEngine.Kagus;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KaguEngine
{
    public class Moon : Boo
    {
        public void Update(GameTime gameTime)
        {
            UpdateKagus(gameTime);
        }
        
        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            DrawKagus(spriteBatch, gameTime);
        }
    }
}