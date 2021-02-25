using System;
using UnityEngine;

namespace MyGame
{
    public class Player : IHealth
    {
        Health healthManager = new Health();
        public int health
        {
            get{
                return healthManager.health;
            }
            set{
                healthManager.health = value;
            }
        }
        public int maxHealth
        {
            get{
                return healthManager.maxHealth;
            }
            set{
                healthManager.maxHealth = value;
            }
        }        

                 

        public Player()
        {
            RestoreHealth();
        }

        public void RestoreHealth()
        {
            for(int i=health; i<= maxHealth; i++)
            {
                health = i;
                Debug.Log ("Health " + health);
            }
        }

        public float CurrentHealthPercent(){
            return healthManager.CurrentHealthPercent();
        }

    }
}
