namespace PlayerSingleton
{
    /// <summary>
    /// Оружие
    /// </summary>
    public class Weapon : Item
    {
        public Weapon(string name, int count = 1) : base(name, count)
        {
        }
    }
}