using UnityEngine;
using Zenject;

namespace PlayerSingleton
{
    public class Main : MonoBehaviour
    {
        [Inject] private readonly IPlayer player;

        private void Start()
        {
            ChangeHeal(-2);
            ChangeAmmo("��������", +2);
        }

        private void ChangeHeal(int count)
        {
            IHealth heal = player.PlayerHeal;
            heal.Health += count;
            Debug.Log("�������� ������: " + heal.Health);
        }

        private void ChangeAmmo(string name, int count)
        {
            IEquipment equipment = player.PlayerEquipment;
            Item gun = equipment.GetItem(name);
            gun.Count += count;
            Debug.Log($"����������� �������� {gun.Name}: {gun.Count}");
        }
    }
}