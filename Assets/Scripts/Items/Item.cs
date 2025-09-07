namespace PlayerSingleton
{
    /// <summary>
    /// Предмет экипировки
    /// </summary>
    public abstract class Item
    {
        protected string name;
        protected int count;

        public Item(string name, int count)
        {
            this.name = name;
            this.count = count;
        }

        /// <summary>
        /// Имя экипировки
        /// </summary>
        public string Name => name;
        /// <summary>
        /// Колличество экипировки
        /// </summary>
        public int Count { get => count; set => count = value; }
    }
}