namespace PlayerSingleton
{
    /// <summary>
    /// Навыки игрока
    /// </summary>
    public class PlayerSkills : ISkills
    {
        public PlayerSkills(string[] skills)
        {
            Skills = skills;
        }

        public string[] Skills { get; set; }
    }
}