using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactoryMethodPatternWithGameObjects
{
    [System.Serializable]
    public class AllyZombie : NPC
    {

        void Awake()
        {
            this.NPCType = "Ally Zombie";
            this.Allegiance = AllegianceType.ALLY;
            this.Weapon = "Bite";
            this.Damage = 7;
            this.Speed = 3.0f;
        }
        void OnEnable()
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}