namespace PlayerSingleton
{
    /// <summary>
    /// Здоровье игрока
    /// </summary>
    public class PlayerHealth : IHealth
    {
        private int health;
        private int lives;

        public PlayerHealth(int health, int lives)
        {
            this.health = health;
            this.lives = lives;
        }

        public int Health { get => health; set => health = value; }
        public int Lives { get => lives; set => lives = value; }

    }
}