namespace dotnet_rpg.Models
{
    public class Charecter
    {
        public int Id { get; set; }

        public String Name { get; set; } = "Frodo";

        public int HitPoints { get; set; } = 100;

        public int Strength {get; set; } = 10;

        public int Defense {get; set; } = 10;

        public int Intellegence {get; set; } = 10;


        public RpgClass Class {get; set; } = RpgClass.Knight;

    }
}