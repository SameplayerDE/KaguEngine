using KaguEngine;
using KaguEngine.Kagus;

namespace Test.Entity
{
    public class Player : MoonBoo2D
    {
        public Player()
        {
            Add(
                new SpriteBoo2D
                {
                    Texture2D = Kagu.Texture2DManager.Get("player")
                }
            );
        }
    }
}