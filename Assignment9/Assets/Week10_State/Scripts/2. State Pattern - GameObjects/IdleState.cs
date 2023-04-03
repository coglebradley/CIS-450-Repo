using UnityEngine;
using UnityEngine.AI;
using System.Collections;

namespace StatePatternGameObjects
{
    public class IdleState : EnemyState
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

        //If enemy is Idle and StartChasing() is called...
        public override void StartChasing()
        {
            Debug.Log("The enemy starts chasing you.");

            agent.SetDestination(target.position);
            
            enemyAIStateManager.currentState = enemyAIStateManager.chaseState;
        }


        public override IEnumerator ChargeAttack()
        {
            Debug.Log("Tried to charge attack, but the enemy was idle and had not started chasing yet.");
            yield return null;
        }

        public override void StopChasingAndReturnToStart()
        {
            Debug.Log("Tried to stop chasing and return to start, but the enemy was idle and had not started chasing yet.");
        }
        public override void RecoverFromDazed()
        {
            Debug.Log("Tried to recover from being dazed, but the enemy was idle and not dazed.");
        }

        public override void ReturnedAndReady()
        {
            Debug.Log("Tried to finish returning to start, but the enemy was idle and had not started chasing yet.");
        }

        public override string ToString()
        {
            return "The enemy is idle, but ready to attack.";
        }
    }
}