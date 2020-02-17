using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public abstract class GameObject
    {
        protected Texture2D sprite;

        protected Texture2D[] sprites;

        protected Vector2 position;

        protected Vector2 origin;

        private float timeElapsed;

        private int currentIndex;

        protected Vector2 velocity;

        protected float speed;

        protected int fps;

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position, null, Color.White, 0, origin, 1, SpriteEffects.None, 1);
        }
        public abstract void LoadContent(ContentManager content);

        public abstract void Update(GameTime gameTime);
    }
}
