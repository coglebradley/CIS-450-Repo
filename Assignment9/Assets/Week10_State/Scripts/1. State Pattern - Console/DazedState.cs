using UnityEngine;
using System.Collections;

namespace StatePatternConsole
{
    public class DazedState : EnemyState
    {
        EnemyAIClient enemyAIClient;

        //Initializing reference to enemyAIclient in constructor 
        //because this class does not extend MonoBehaviour.
        //If it did, we would use void Start() instead.
        public DazedState(EnemyAIClient enemyAIClient)
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
            Debug.Log("The enemy recovers from being dazed.");
            enemyAIClient.currentState = enemyAIClient.chaseState;
        }

        public void ReturnedAndReady()
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            return "The enemy is dazed after the charge attack.\n" +
                   "Press 4 to make the enemy recover from being dazed.";
        }
    }
}