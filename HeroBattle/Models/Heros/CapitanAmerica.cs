﻿using System;
namespace HeroBattle.Models.Heros
{
    public class CapitanAmerica : BaseHero
    {
        public override string ToString()
        {
            return $"Capitan America: Hp:{this.HealthPoint}  Demage:{this.Damage}  Armor:{this.Armor}";
        }
     
    }
}
