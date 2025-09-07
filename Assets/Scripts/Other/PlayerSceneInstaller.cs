using Zenject;

namespace PlayerSingleton
{

    public class PlayerSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            ConstructPlayer();
            ConstructHealth();
            ConstructEquipment();
            ConstructSkills();
        }

        private void ConstructPlayer() => Container.Bind<IPlayer>().To<Player>().AsSingle().WithArguments("John");

        private void ConstructHealth()
        {
            PlayerHealth playerHealth = new PlayerHealth(100, 3);
            BindInstance(playerHealth);
        }

        private void ConstructEquipment()
        {
            Equipment playerEquipment = new Equipment();
            playerEquipment.AddItem(new Weapon("��������", 50));
            playerEquipment.AddItem(new Parachute("�������"));
            playerEquipment.AddItem(new RocketPack("�������� �����", 3));
            BindInstance(playerEquipment);
        }

        private void ConstructSkills()
        {
            PlayerSkills playerSkills = new PlayerSkills(new string[] { "Skill1", "Skill2", "Skill3" });
            BindInstance(playerSkills);
        }

        private void BindInstance<T>(T instance) => Container.BindInterfacesTo<T>().FromInstance(instance).AsSingle();
    }
}