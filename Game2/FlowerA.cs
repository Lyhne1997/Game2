using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class FlowerA : GameObject
    {
        public Vector2 position = new Vector2(650, 350);
        public FlowerA(Vector2 position)
        {
            position = new Vector2(650, 350);
            this.position = new Vector2(650, 350);
        }
        public override void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("FlowerA");
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
