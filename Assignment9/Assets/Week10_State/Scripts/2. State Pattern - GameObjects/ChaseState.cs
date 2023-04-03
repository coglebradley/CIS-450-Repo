using UnityEngine;
using UnityEngine.AI;
using System.Collections;

namespace StatePatternGameObjects
{
    public class ChaseState : EnemyState
    {
        EnemyAIStateManager enemyAIStateManager;
        NavMeshAgent agent;
        GameObject player;
        //Transform target;
        Vector3 startPosition;
        Rigidbody rb;

        public void Start()
        {
            enemyAIStateManager = gameObject.GetComponent<EnemyAIStateManager>();
            agent = gameObject.GetComponent<NavMeshAgent>();
            rb = gameObject.GetComponent<Rigidbody>();
            player = GameObject.FindGameObjectWithTag("Player");
            //target = GameObject.FindGameObjectWithTag("Player").transform;
            startPosition = gameObject.transform.position;

        }

        public override void StartChasing()
        {
            Debug.Log("The enemy sees you and continues chasing you.");

            agent.SetDestination(player.transform.position);
        }

        public override IEnumerator ChargeAttack()
        {

            Debug.Log("The enemy attacks you with a charge attack");
            
            //look at player
            Vector3 direction = (player.transform.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
            
            //enemy charges toward player
            Vector3 pushDirection = (player.transform.position - transform.position).normalized;
            rb.AddForce(pushDirection * 300f, ForceMode.Impulse);
            
            yield return new WaitForSeconds(0.15f);

            //player is pushed back 
            //this is faked here by adding force in the same direction as the charge after 0.1 seconds
            //triggering this on collision rather than after a delay may be better gameplay because the player could try to dodge
            Rigidbody playerRB = player.GetComponent<Rigidbody>();
            playerRB.AddForce(pushDirection * 500f, ForceMode.Impulse);


            //dazed for 3 seconds
            Debug.Log("The enemy is dazed.");
            enemyAIStateManager.currentState = enemyAIStateManager.dazedState;
            yield return new WaitForSeconds(3f);
            Debug.Log("The enemy recovers from being dazed.");
            enemyAIStateManager.currentState.RecoverFromDazed();
            
        }

        public override void StopChasingAndReturnToStart()
        {
            Debug.Log("The enemy begins returning to its start position.");

            agent.SetDestination(startPosition);

            enemyAIStateManager.currentState = enemyAIStateManager.returnToStartState;

        }

        public override void RecoverFromDazed()
        {
            Debug.Log("Tried to recover from being dazed, but chasing and not dazed.");
        }

        public override void ReturnedAndReady()
        {
            Debug.Log("Tried to finish returning to start, but chasing not returning to start.");
        }
        public override string ToString()
        {
            return "The enemy is chasing you!  Run!";
        }
    }
}