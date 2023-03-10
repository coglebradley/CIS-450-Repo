using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPattern
{
    public class EnemyWerewolf : NPC
    {

        public EnemyWerewolf()
        {
            this.NPCType = "Enemy Werewolf";
            this.Allegiance = AllegianceType.ENEMY;
            this.Weapon = "Claw";
            this.Damage = 8;
            this.Speed = 4.0f;
        }
    }
}