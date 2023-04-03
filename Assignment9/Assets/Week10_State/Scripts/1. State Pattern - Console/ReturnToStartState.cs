using UnityEngine;
using System.Collections;

namespace StatePatternConsole
{
    public class ReturnToStartState : EnemyState
    {
        EnemyAIClient enemyAIClient;

        //Initializing reference to enemyAIclient in constructor 
        //because this class does not extend MonoBehaviour.
        //If it did, we would use void Start() instead.
        public ReturnToStartState(EnemyAIClient enemyAIClient)
        {
            this.enemyAIClient = enemyAIClient;
        }

        public void StartChasing()
        {
            throw new System.NotImplementedException();
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
            Debug.Log("The enemy has returned to its start position and is ready.");
            enemyAIClient.currentState = enemyAIClient.idleState;
        }
        public override string ToString()
        {
            return "The enemy is returning to its start position.\n" +
                   "Press 5 to make the enemy finish returning to its start position";
        }

    }
}