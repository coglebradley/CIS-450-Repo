using UnityEngine;
using UnityEngine.AI;
using System.Collections;

namespace StatePatternGameObjects
{
    public class EnemyAIStateManager : MonoBehaviour
    {
        public EnemyState returnToStartState { get; set; }
        public EnemyState idleState { get; set; }
        public EnemyState chaseState { get; set; }
        public EnemyState dazedState { get; set; }

        public EnemyState currentState { get; set; }




        // Use this for initialization
        void Start()
        {
            idleState = gameObject.AddComponent<IdleState>();
            chaseState = gameObject.AddComponent<ChaseState>();
            dazedState = gameObject.AddComponent<DazedState>();
            returnToStartState = gameObject.AddComponent<ReturnToStartState>();

            currentState = idleState;

        }

        public void StartChasing() { currentState.StartChasing(); }
        public void ChargeAttack() { StartCoroutine(currentState.ChargeAttack()); }
        public void RecoverFromDazed() { currentState.RecoverFromDazed(); }
        public void StopChasingAndReturnToStart() { currentState.StopChasingAndReturnToStart(); }
        public void ReturnedAndReady() { currentState.ReturnedAndReady(); }

    }
}