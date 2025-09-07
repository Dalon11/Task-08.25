namespace PlayerSingleton
{
    /// <summary>
    /// Интерфейс для экипировки
    /// </summary>
    public interface IEquipment
    {
        /// <summary>
        /// Добавить экипировку
        /// </summary>
        public void AddItem(Item item);
        /// <summary>
        /// Получить экипировку
        /// </summary>
        public Item GetItem(string key);
    }
}