namespace PlayerSingleton
{
    /// <summary>
    /// Интерфейс для здоровья
    /// </summary>
    public interface IHealth
    {
        /// <summary>
        /// Здоровье
        /// </summary>
        public int Health { get; set; }
        /// <summary>
        /// Жизни
        /// </summary>
        public int Lives { get; set; }
    }
}