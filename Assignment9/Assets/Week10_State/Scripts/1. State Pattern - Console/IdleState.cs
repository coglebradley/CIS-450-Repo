using UnityEngine;
using System.Collections;

namespace StatePatternConsole
{
    public class IdleState : EnemyState
    {
        EnemyAIClient enemyAIClient;

        //Initializing reference to enemyAIclient in constructor 
        //because this class does not extend MonoBehaviour.
        //If it did, we would use void Start() instead.
        public IdleState(EnemyAIClient enemyAIClient)
        {
            this.enemyAIClient = enemyAIClient;
        }

        //If enemy is Idle and StartChasing() is called...
        public void StartChasing()
        {
            Debug.Log("The enemy starts chasing you.");
            enemyAIClient.currentState = enemyAIClient.chaseState;
        }


        public void ChargeAttack()
        {
            throw new System.NotImplementedException();
        }

        public void StopChasingAndReturnToStart()
        {
            throw new System.NotImplementedException();
        }
        public void RecoverFromDazed()
        {
            throw new System.NotImplementedException();
        }

        public void ReturnedAndReady()
        {
            throw new System.NotImplementedException();
        }


        public override string ToString()
        {
            return "The enemy is idle.  Press 1 to make the enemy start chasing you.";
        }


    }
}