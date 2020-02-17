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
    class Drone : GameObject
    {
        private Vector2 baseA;
        private Vector2 flowerA;
        private Vector2 flowerB;
        private Vector2 flowerC;
        //Når bien først spawner og venter på input fra spilleren.
        private bool isWaitingForInput = true;
        //Når bien har samlet Nectar og skal bevæge sig mod basen, ændrer sig afhængigt af hvilken blomst den var ved.
        private bool isMovingToBaseAFromFlowerA = false;
        private bool isMovingToBaseAFromFlowerB = false;
        private bool isMovingToBaseAFromFlowerC = false;
        //Når bien har fået input fra spilleren og får besked på at bevæge sig til en blomst for at hente Nectar.
        private bool isMovingToFlowerA = false;
        private bool isMovingToFlowerB = false;
        private bool isMovingToFlowerC = false;
        //Når bien er ved blomsten og samler Nectar.
        private bool isCollectingFlowerA = false;
        private bool isCollectingFlowerB = false;
        private bool isCollectingFlowerC = false;
        //Når bien er kommet til basen med Nectar og skal aflevere Nectar.
        private bool isOffloadingNectar = false;

        public Drone(Vector2 position)
        {
            baseA = new Vector2(0, 0);
            this.position = baseA;
        }
        public override void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("Bigut");
        }
        public override void Update(GameTime gameTime)
        {
            //Debug.WriteLine(position);
            throw new NotImplementedException();
        }
        private void Movement(GameTime gameTime)
        {
            velocity = Vector2.Zero;

            if(isMovingToBaseAFromFlowerA == true)
            {
                
            }
        }
    }
}
