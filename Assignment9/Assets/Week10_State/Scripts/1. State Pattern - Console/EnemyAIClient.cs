using UnityEngine;
using System.Collections;

namespace StatePatternConsole
{
    public class EnemyAIClient : MonoBehaviour
    {
        public EnemyState returnToStartState { get; set; }
        public EnemyState idleState { get; set; }
        public EnemyState chaseState { get; set; }
        public EnemyState dazedState { get; set; }

        public EnemyState currentState { get; set; }

        public bool inRange { get; set; }

        // Use this for initialization
        void Start()
        {
            returnToStartState = new ReturnToStartState(this);
            idleState = new IdleState(this);
            chaseState = new ChaseState(this);
            dazedState = new DazedState(this);

            currentState = idleState;
            inRange = false;

            Debug.Log("Welcome to the enemy AI simulation.\n" +
                "Press spacebar to display the current state of the enemy AI.");

        }

        public void StartChasing() { currentState.StartChasing(); }
        public void ChargeAttack() { currentState.ChargeAttack(); }
        public void RecoverFromDazed() { currentState.RecoverFromDazed(); }
        public void StopChasingAndReturnToStart() { currentState.StopChasingAndReturnToStart(); }
        public void ReturnedAndReady() { currentState.ReturnedAndReady(); }


        // This Update() code is not part of the client in the pattern, it is the test-drive code
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Current enemy state: " + currentState);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                inRange = !inRange;
                Debug.Log("It is now " + inRange + " that you are close enough for the enemy to attack you.");
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                StartChasing();
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ChargeAttack();
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                StopChasingAndReturnToStart();
            }

            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                RecoverFromDazed();
            }

            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                ReturnedAndReady();
            }

        }
    }
}