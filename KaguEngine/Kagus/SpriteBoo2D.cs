using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using PrimitiveExpander;

namespace KaguEngine.Kagus
{
    public class SpriteBoo2D : BatchBoo
    {
        public Texture2D Texture2D = null;
        public Color Tint = Color.White;
        public float Alpha = 1f;

        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            
            PrimitiveRenderer.DrawCircleF(
                null,
                Tint * Alpha,
                Position,
                25f
            );
            
            if (Texture2D == null) return;
            spriteBatch.Draw(
                Texture2D,
                Position,
                Tint * Alpha
            );
        }
    }
}