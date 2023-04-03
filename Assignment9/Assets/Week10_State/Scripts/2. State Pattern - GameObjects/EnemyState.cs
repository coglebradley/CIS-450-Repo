using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePatternGameObjects
{
    public abstract class EnemyState: MonoBehaviour
    {

        public abstract void StartChasing();
        public abstract IEnumerator ChargeAttack();
        public abstract void RecoverFromDazed();
        public abstract void StopChasingAndReturnToStart();
        public abstract void ReturnedAndReady();



    }
}