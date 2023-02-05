/* Example Code for Game Programming Design Patterns
 * Author: Owen Schaffer
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPatternAssignment
{
    public interface IObserver
    {
        void UpdateData(List<Valuable> valuables);

    }
}
