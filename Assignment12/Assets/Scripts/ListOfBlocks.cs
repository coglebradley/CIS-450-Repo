/*
 * (Conner Ogle)
 * (Assignment12)
 * (Assignment 12)
 * (Composite of Blocks)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ListOfBlocks : MonoBehaviour
{
    public enum BlockType
    {
        Grid,
        Block,
        Flat,
        LBlock,
        LBlockInv,

    }    
    public BlockType blocktype;
    public GameObject prefab;
    public string desc;
    // Start is called before the first frame update

    public abstract BlockType GetBlockType();
    public abstract GameObject GetPrefab();

    public abstract string ReturnDesc();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
