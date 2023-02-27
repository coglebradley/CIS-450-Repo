/*
 * (Conner Ogle)
 * (Assignment6)
 * (Assignment 6)
 * (Location that receives the artifacts to achieve victory)
 */
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
        if (other.tag == "SilverCylinder")
        {
            artifactsFound++;
            Destroy(other);
        }
        if (other.tag == "GoldCube")
        {
            artifactsFound++;
            Destroy(other);
        }
        if (other.tag == "GoldSphere")
        {
            artifactsFound++;
            Destroy(other);
        }
        if (other.tag == "SilverCube")
        {
            artifactsFound++;
            Destroy(other);
        }
        if (other.tag == "SilverSphere")
        {
            artifactsFound++;
            Destroy(other);
        }
    }
}
