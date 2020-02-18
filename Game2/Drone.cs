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

        private Vector2 direction;
        protected float rotation;
        private Vector2 distance;

        private int moveting = 0;


        public Drone(Vector2 position)
        {
            this.position = position;
            flowerA.X = 650;
            flowerA.Y = 350;
            baseA.X = 0;
            baseA.Y = 0;
            
            speed = 5f;
            /*isMovingToFlowerA = true;
            if(this.position == new Vector2(0,0))
            {
                isMovingToFlowerA = true;
                isMovingToBaseAFromFlowerA = false;
            }
            if(this.position == new Vector2(222, 222))
            {
                isMovingToBaseAFromFlowerA = true;
                isMovingToFlowerA = false;
            }*/
        }
        public override void LoadContent(ContentManager content)
        {
            sprite = content.Load<Texture2D>("Bigut");
        }
        public override void Update(GameTime gameTime)
        {
            //Debug.WriteLine(position);
            //Move(gameTime);
            //DroneMove(gameTime);
            //position = this.position;
            //dronePosition = this.position;
            DroneManagement(gameTime);

        }
        private void DroneManagement(GameTime gameTime)
        {
            if(isMovingToFlowerA == true && isMovingToBaseAFromFlowerA == false)
                {
                    distance.X = flowerA.X - this.position.X;
                    distance.Y = flowerA.Y - this.position.Y;
                }
            if (isMovingToBaseAFromFlowerA == true && isMovingToFlowerA == false)
                {
                    distance.X = baseA.X - this.position.X;
                    distance.Y = baseA.Y - this.position.Y;
                }

                rotation = (float)Math.Atan2(distance.X, -distance.Y);
                direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(90) - rotation), -(float)Math.Sin(MathHelper.ToRadians(90) - rotation));
                float positiveDistanceX = distance.X;
                float positiveDistanceY = distance.Y;

             if (distance.X == baseA.X && distance.Y == baseA.Y)
                {
                    positiveDistanceX *= -1;
                    positiveDistanceY *= -1;
                }

             if (distance.X == baseA.X && distance.Y == baseA.Y)
                {
                    positiveDistanceX *= -1;
                    positiveDistanceY *= -1;
                }

             if (this.position == baseA)
                {
                    isMovingToBaseAFromFlowerA = false;
                    isMovingToFlowerA = true;
                }
             if (this.position == flowerA)
                {
                    isMovingToFlowerA = false;
                    isMovingToBaseAFromFlowerA = true;
                }

                position += direction * this.speed;
                
                
            //}
        }
        /*private void Move(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            position += ((velocity * speed) * deltaTime);
        }*/
        /*private Vector2 dronePosition;
        private Vector2 distance;
        // Direction of the enemy
        private Vector2 direction;
        // Rotation of player and enemy
        protected float rotation;
        private void DroneMove(GameTime gameTime)
        {
            // Calculates the distance from the player and the enemy
            distance.X = Player.PlayerPosition.X - this.dronePosition.X;
            distance.Y = Player.PlayerPosition.Y - this.dronePosition.Y;

            // Enemys only hunts you if your in a certain range
            if (isCollectingFlowerA == true)
            {
                rotation = (float)Math.Atan2(distance.X, -distance.Y);
                direction = new Vector2((float)Math.Cos(MathHelper.ToRadians(90) - rotation), -(float)Math.Sin(MathHelper.ToRadians(90) - rotation));

                float positiveDistanceX = distance.X;
                float positiveDistanceY = distance.Y;
                if (distance.X < 0)
                {
                    positiveDistanceX *= -1;

                }
                if (distance.Y < 0)
                    positiveDistanceY *= -1;

                if (positiveDistanceX > 50 || positiveDistanceY > 50)
                    position += direction * this.speed;
            }
        }*/
    }
}
