using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPatternWithGameObjects
{
    public class EnemyVampire : NPC
    {

        void Awake()
        {
            this.NPCType = "Enemy Vampire";
            this.Allegiance = AllegianceType.ENEMY;
            this.Weapon = "Bite";
            this.Damage = 10;
            this.Speed = 5.0f;
        }
        void OnEnable()
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}