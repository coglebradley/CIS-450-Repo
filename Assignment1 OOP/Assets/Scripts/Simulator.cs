/*
 * (Conner Ogle)
 * (Assignment1 OOP)
 * (Assignment1)
 * (main script that runs the game)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Simulator : MonoBehaviour
    {
        public Creature goon;

        public Beetle beet;

        public Creature[] creatures = new Creature[5];

        public List<Creature> creatureList = new List<Creature>();

        public List<IAttack> attackList = new List<IAttack>();

        // Start is called before the first frame update
        void Start()
        {
            beet = new Beetle();

            goon = new Monster();
 
            goon.Die();

                        //creating the lists
                        creatures[0] = new Monster();
                        creatures[1] = new Human();
                        creatures[2] = new Beetle();
                        creatures[3] = new Monster();
                        creatures[4] = new Human();
                        
                        for (int i = 0; i < 2; i++)
                        {
                            attackList.Add(new Human());
                            attackList.Add(new Monster());
                        }


        }
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                foreach (Creature creature in creatures)
                        {
                            if (creature == null) { break; }

                            creature.Die();
                        }
                beet.Walk();
            }

            if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                foreach (IAttack attack in attackList)
                        {
                            if (attack == null) { break; }
                            attack.Attack();
                        }
                beet.Attack();
            }
        }

    }

