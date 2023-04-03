using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment9
{
    public interface PlayerState
    {
        void Moving(int Direction, Rigidbody rb);

        void Gravity(bool gravityOn, Rigidbody rb);

        void Stop(Rigidbody rb);
    }
}