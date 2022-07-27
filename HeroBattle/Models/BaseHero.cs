using System;
namespace HeroBattle.Models
{
    public abstract class BaseHero
    {
        public int HealthPoint { get; set; } = 100;

        public virtual int Armor { get; set; } = 10;

        public virtual int Damage { get; set; } = 10;
    }
}
