using UnityEngine;

namespace PlayerSingleton
{
    /// <summary>
    /// Класс игрока
    /// </summary>
    public sealed class Player : IPlayer
    {
        private string nickname;
        private IHealth heal;
        private IEquipment equipment;
        private ISkills skills;

        public string Nickname => nickname;
        public IHealth PlayerHeal { get => heal; set => heal = value; }
        public IEquipment PlayerEquipment { get => equipment; set => equipment = value; }
        public ISkills PlayerSkills { get => skills; set => skills = value; }

        private Player(string nickname, IHealth heal, IEquipment equipment, ISkills skills)
        {
            this.nickname = nickname;
            this.heal = heal;
            this.equipment = equipment;
            this.skills = skills;

            Debug.Log("Никнейм игрока: " + nickname);
            Debug.Log("Здоровье игрока: " + heal.Health); 

        }
    }
}