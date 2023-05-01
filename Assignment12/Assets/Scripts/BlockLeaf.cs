/*
 * (Conner Ogle)
 * (Assignment12)
 * (Assignment 12)
 * (Leaf Object of Blocks)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLeaf : ListOfBlocks
{
    public override BlockType GetBlockType()
    {
       return blocktype;
    }

    public override GameObject GetPrefab()
    {
        return prefab;
    }

    public override string ReturnDesc()
    {
        return desc;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
