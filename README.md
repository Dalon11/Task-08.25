# Task-08.25
 
Тестовое задание для разработчика C#
Задача: переделка кода проекта на синглтонах в Dependency Injection.

Условия выполнения задания:

1. Предоставить код проекта, который использует синглтоны.
2. Переделать код проекта так, чтобы он использовал Dependency Injection вместо синглтонов.
3. Объяснить, как будет работать новый код после переделки.
4. Продемонстрировать работу нового кода на примере использования его в другом коде.

Пример тестового задания:

Предоставлен код проекта с использованием синглтона, отвечающего за инициализацию игрока в компьютерной игре. 
У игрока есть следующие атрибуты: здоровье, количество жизней, никнейм, таблица навыков. 
Также у игрока есть экипировка: винтовка с патронами, парашют, ракетный ранец с произвольным количеством зарядов.

    class Program
    {
        static void Main(string[] args)
        {
            Player player = Player.Instance; // Получаем экземпляр класса Player

            // Инициализируем игрока
            player.Health = 100;
            player.Lives = 3;
            player.Nickname = "John";
            player.Skills = new string[] { "Skill1", "Skill2", "Skill3" };
            player.Equipment = new Equipment();

            Console.WriteLine("Здоровье игрока: " + player.Health);
            Console.WriteLine("Никнейм игрока: " + player.Nickname);

            Equipment equipment = player.Equipment;
            equipment.AddItem(new Weapon("Винтовка", 50));
            equipment.AddItem(new Parachute());
            equipment.AddItem(new RocketPack(3)); // Ракетный ранец с 3 зарядами

            Console.ReadKey();
        }
    }

    // Класс игрока
    public class Player
    {
        private static Player _instance;
        public int Health { get; set; }
        public int Lives { get; set; }
        public string Nickname { get; set; }

        // Таблица навыков
        public string[] Skills { get; set; }
                
        // Экипировка
        public Equipment Equipment { get; private set; }

        public Player()
        {
            _instance = this;
        }

        public static Player Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Player();
                }
                return _instance;
            }
        }
    }

    // Интерфейс для экипировки
    interface IEquipment
    {
        void AddItem(Item item);
    }

    // Реализация экипировки
    public class Equipment : IEquipment
    {
        List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }
    }

    // Предмет экипировки
    abstract class Item
    {
        protected string name;

        public Item(string name)
        {
            this.name = name;
        }
    }

    // Оружие
    class Weapon : Item
    {
        int ammo;

        public Weapon(string name, int ammo) : base(name)
        {
            this.ammo = ammo;
        }
    }

    // Парашют
    class Parachute : Item
    {
    }

    // Ракетный ранец
    class RocketPack : Item
    {
        int charges;

        public RocketPack(int charges) : base("RocketPack")
        {
            this.charges = charges;
        }
    }

Необходимо переделать код так, чтобы использовать Dependency Injection, и выполнить следующие пункты:

1. Создать интерфейс для класса Player.
2. Реализовать класс Player, используя интерфейс.
3. Создать контейнер IoC и зарегистрировать класс Player в контейнере.
4. Использовать контейнер для получения экземпляра класса Player в другом коде.
5. Объяснить, какие изменения были внесены и как они влияют на работу кода.
6. Продемонстрировать использование нового кода в другом коде, например, в классе Main.
7. Предоставить комментарии к коду, объясняющие его работу.
8. Соблюсти принципы SOLID при переделке кода.
9. Убедиться, что новый код позволяет легко изменять значения атрибутов игрока (здоровье, количество патронов и т. д.) из разных частей программы.
10. Обеспечить безопасность использования синглтона, предотвратив возможность создания нескольких экземпляров класса Player и гарантируя уникальность данных игрока.
11. Добавить в класс Player параметры экипировки игрока: винтовку с патронами, парашют и ракетный ранец.
12. Сделать так, чтобы параметры элементов экипировки можно было задавать в рантайме через Dependency Injection.

