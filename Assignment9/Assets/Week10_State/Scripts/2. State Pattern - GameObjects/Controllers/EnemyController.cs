// This script is from this Brackeys video:https://www.youtube.com/watch?v=blPglabGueM

using UnityEngine;
using UnityEngine.AI;
//using UnityStandardAssets.Characters.ThirdPerson;

namespace StatePatternGameObjects
{
    public class EnemyController : MonoBehaviour
    {

        public Camera cam;

        public NavMeshAgent agent;

        //public ThirdPersonCharacter character;

        public Transform target;
        public Vector3 startPosition;

        public EnemyAIStateManager enemyAIStateManager;

        public float detectionRange;
        public float distanceFromPlayer;
        public float distanceFromStart;

        void Start()
        {
            agent.updateRotation = false;

            startPosition = transform.position;

            target = GameObject.FindGameObjectWithTag("Player").transform;
        }

        // Update is called once per frame
        void Update()
        {

            distanceFromPlayer = Vector3.Distance(target.position, transform.position);
            /* See #16 at https://www.youtube.com/watch?v=thA3zv0IoUM for a faster way to calculate distance
               than Vector3.Distance if performance is an issue. */
            
            distanceFromStart = Vector3.Distance(startPosition, transform.position);

            //If player is within detection range, enemy moves towards player
            if (distanceFromPlayer <= detectionRange)
            {
                //Instead of doing this here...
                //agent.SetDestination(target.position);

                enemyAIStateManager.StartChasing();

                //If player is within attack range, enemy attacks player with charge attack
                if (distanceFromPlayer <= 1.2f)
                {
                    Debug.Log("Enemy is close enough to attack");
                    enemyAIStateManager.ChargeAttack();
                }

            }
            //Else if player is outside detection range and not at start position, enemy returns to start position
            else if (distanceFromStart > 1.2f && (enemyAIStateManager.currentState != enemyAIStateManager.returnToStartState) )
            {
                enemyAIStateManager.StopChasingAndReturnToStart();
            }

            //Else if player is at start position, change to idle state
            else if (distanceFromStart <= 1.2f && (enemyAIStateManager.currentState != enemyAIStateManager.idleState) )
            {
                enemyAIStateManager.ReturnedAndReady();
            }

                       

            //Move towards agent's destination using ThirdPersonCharacter.Move()
            if (agent.remainingDistance > 1.2f)
            {
                //character.Move(agent.desiredVelocity, false, false);
            }
            else
            {
                //character.Move(Vector3.zero, false, false);
            }

        }
    }
}