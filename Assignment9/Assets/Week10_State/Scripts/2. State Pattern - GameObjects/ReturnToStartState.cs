using UnityEngine;
using System.Collections;
using UnityEngine.AI;

namespace StatePatternGameObjects
{
    public class ReturnToStartState : EnemyState
    {
        EnemyAIStateManager enemyAIStateManager;
        NavMeshAgent agent;
        //Transform target;
        GameObject player;
        Vector3 startPosition;

        public void Start()
        {
            enemyAIStateManager = gameObject.GetComponent<EnemyAIStateManager>();
            agent = gameObject.GetComponent<NavMeshAgent>();
            //target = GameObject.FindGameObjectWithTag("Player").transform;
            player = GameObject.FindGameObjectWithTag("Player");
            startPosition = transform.position;
        }

        public override void StartChasing()
        {
            //If the enemy is returning to its start position and sees the player
            //The enemy could chase the player:
            Debug.Log("The enemy sees you and continues chasing you.");
            agent.SetDestination(player.transform.position);
            enemyAIStateManager.currentState = enemyAIStateManager.chaseState;

            //...Or we could have the enemy continue back to its starting position instead:
            /*
            Debug.Log("The enemy saw you, but the enemy was returning to its start position.");
            agent.SetDestination(startPosition);
            enemyAIStateManager.currentState = enemyAIStateManager.returnToStartState;
            */

        }

        public override IEnumerator ChargeAttack()
        {
            Debug.Log("Player got close enough for the enemy to attack, but the enemy was returning to its start position.");
            agent.SetDestination(startPosition);
            yield return null;
        }

        public override void StopChasingAndReturnToStart()
        {
            Debug.Log("Enemy tried to stop chasing and return, but the enemy was already returning to its start position.");
        }

        public override void RecoverFromDazed()
        {
            Debug.Log("Enemy tried to recover from being dazed, but the enemy was returning to its start position.");
        }

        public override void ReturnedAndReady()
        {
            Debug.Log("The enemy has returned to its start position and is ready.");
            enemyAIStateManager.currentState = enemyAIStateManager.idleState;
        }
        public override string ToString()
        {
            return "The enemy has given up and is returning to its start position.";
        }

    }
}