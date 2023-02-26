using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactDropOff : MonoBehaviour
{
    public int artifactsFound = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "GoldCylinder")
        {
            artifactsFound++;
            Destroy(other);
        }
    }
}
