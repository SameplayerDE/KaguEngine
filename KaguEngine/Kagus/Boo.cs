using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace KaguEngine.Kagus
{
    public class Boo
    {
        public List<Boo> Kagus = new List<Boo>();
        public Boo Parent = null;
        
        public void Add(Boo kagu)
        {
            kagu.Parent = this;
            Kagus.Add(kagu);
        }

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