using UnityEngine;
using System.Collections;

namespace StatePatternConsole
{
    public class ChaseState : EnemyState
    {
        EnemyAIClient enemyAIClient;

        //Initializing reference to enemyAIclient in constructor 
        //because this class does not extend MonoBehaviour.
        //If it did, we would use void Start() instead.
        public ChaseState(EnemyAIClient enemyAIClient)
        {
            this.enemyAIClient = enemyAIClient;
        }
        public void StartChasing()
        {
            throw new System.NotImplementedException();
        }

        public void ChargeAttack()
        {

            if (enemyAIClient.inRange)
            {
                Debug.Log("The enemy attacks you with a charge attack.\n" +
                          "The enemy is dazed.");
                enemyAIClient.currentState = enemyAIClient.dazedState;
            }
            else
            {
                Debug.Log("The enemy wants to attack you...\n" +
                          "But you are out of range. Press R to get in range.");
            }

        }

        public void StopChasingAndReturnToStart()
        {
            Debug.Log("The enemy begins returning to its start position.");
            enemyAIClient.currentState = enemyAIClient.returnToStartState;
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
            return "The enemy is chasing you.  Press 2 to make the enemy try to attack you.\n" +
                   "Press 3 to make the enemy give up and return to its start position";
        }

    }
}