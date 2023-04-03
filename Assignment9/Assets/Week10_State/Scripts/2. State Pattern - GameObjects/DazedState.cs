using UnityEngine;
using UnityEngine.AI;
using System.Collections;

namespace StatePatternGameObjects
{
    public class DazedState : EnemyState
    {
        EnemyAIStateManager enemyAIStateManager;
        NavMeshAgent agent;
        Transform target;

        public void Start()
        {
            this.enemyAIStateManager = gameObject.GetComponent<EnemyAIStateManager>();
            this.agent = gameObject.GetComponent<NavMeshAgent>();
            this.target = GameObject.FindGameObjectWithTag("Player").transform;

        }
        public override void StartChasing()
        {
            Debug.Log("Tried to start chasing, but the enemy was dazed.");
        }

        public override IEnumerator ChargeAttack()
        {
            Debug.Log("Tried to do a charge attack, but the enemy was dazed.");
            yield return null;
        }

        public override void StopChasingAndReturnToStart()
        {
            Debug.Log("Tried to stop chasing and return to start, but the enemy was dazed.");
        }

        public override void RecoverFromDazed()
        {
            Debug.Log("The enemy recovers from being dazed.");
            enemyAIStateManager.currentState = enemyAIStateManager.chaseState;
        }

        public override void ReturnedAndReady()
        {
            Debug.Log("Tried to finish returning to start, but the enemy was dazed.");
        }
        public override string ToString()
        {
            return "The enemy is dazed after a charge attack.";
        }
    }
}