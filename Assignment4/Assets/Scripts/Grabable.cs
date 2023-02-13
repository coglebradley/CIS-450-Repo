using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabable : MonoBehaviour
{
    public enum CollectableType { low, mid, high}

    public CollectableType collectableType;
}
