using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePatternConsole
{
    public interface EnemyState
    {

        void StartChasing();
        void ChargeAttack();
        void RecoverFromDazed();
        void StopChasingAndReturnToStart();
        void ReturnedAndReady();



    }
}