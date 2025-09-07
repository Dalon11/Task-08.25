namespace PlayerSingleton
{
    /// <summary>
    /// Интерфейс игрока
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Никнейм игрока
        /// </summary>
        public string Nickname { get; }
        /// <summary>
        /// Жизни игрока
        /// </summary>
        public IHealth PlayerHeal { get; set; }
        /// <summary>
        /// Экипировка игрока
        /// </summary>
        public IEquipment PlayerEquipment { get; set; }
        /// <summary>
        /// Навыки игрока
        /// </summary>
        public ISkills PlayerSkills { get; set; }
    }
}