using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KaguEngine.Kagus
{
    public class Boo
    {
        public List<Boo> Kagus = new List<Boo>();

        protected void UpdateKagus(GameTime gameTime)
        {
            foreach (var kagu in Kagus)
            {
                kagu.UpdateKagus(gameTime);
                if (kagu is UpdateBoo updateKagu)
                {
                    updateKagu.Update(gameTime);
                }
            }
        }
        
        protected void DrawKagus(SpriteBatch spriteBatch, GameTime gameTime)
        {
            foreach (var kagu in Kagus)
            {
                kagu.DrawKagus(spriteBatch, gameTime);
                if (kagu is BatchBoo batchKagu)
                {
                    batchKagu.Draw(spriteBatch, gameTime);
                }
            }
        }
        
    }
}