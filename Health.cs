

namespace MyGame{


    public interface IHealth
    {
        int health{get; set;}
        int maxHealth{get; set;}
        float CurrentHealthPercent();
        void RestoreHealth();
    }

    public class Health : IHealth
    {
        public int health {get; set; }
        public int maxHealth {get; set; }

        public Health(){
            health = 1;
            maxHealth = 10;
        }

        public float CurrentHealthPercent()
        {
            return (float)health/maxHealth * 100;
        }

        public virtual void RestoreHealth()
        {
            health = maxHealth;
        }
    }
}