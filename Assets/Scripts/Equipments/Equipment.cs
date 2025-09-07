using System.Collections.Generic;

namespace PlayerSingleton
{
    /// <summary>
    /// Реализация экипировки
    /// </summary>
    public class Equipment : IEquipment
    {
        private readonly Dictionary<string, Item> itemsDictionary = new Dictionary<string, Item>();

        public void AddItem(Item item) => itemsDictionary.Add(item.Name, item);

        public Item GetItem(string key)
        {
            itemsDictionary.TryGetValue(key, out Item item);
            return item;
        }
    }
}