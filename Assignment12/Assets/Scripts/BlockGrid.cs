/*
 * (Conner Ogle)
 * (Assignment12)
 * (Assignment 12)
 * (Object that spawns blocks and performs instantiation)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockGrid : ListOfBlocks
{
    public List<GameObject> spawnlocations = new List<GameObject>();

    public Stack<GameObject> BlocksAdded = new Stack<GameObject>();

    public List<ListOfBlocks> ListOfBlocks = new List<ListOfBlocks>();

    public Text text;

    public int currentpos = 0;
    public override BlockType GetBlockType()
    {
        return blocktype;
    }

    public override GameObject GetPrefab()
    {
        return prefab;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ListOfBlocks[currentpos].ReturnDesc();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Spawn(spawnlocations[0]);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Spawn(spawnlocations[1]);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Spawn(spawnlocations[2]);
        }
    }
    public void nextBlock()
    {
        if (currentpos == ListOfBlocks.Count)
        {
            currentpos = 0;
        }
        else
        {
            currentpos++;
        }
            

        text.text = ListOfBlocks[currentpos].ReturnDesc();
    }

    void Spawn(GameObject spawn)
    {
        GameObject spawnedBlock;
        string desc = ListOfBlocks[currentpos].ReturnDesc();
        if (desc == "L Block")
        {
            spawnedBlock = Instantiate(ListOfBlocks[currentpos].GetPrefab(), spawn.transform.position, Quaternion.Euler(0f,0f,90f));
        }
        else if(desc == "Inverse L Block")
        {
            spawnedBlock = Instantiate(ListOfBlocks[currentpos].GetPrefab(), spawn.transform.position, Quaternion.Euler(0f,0f,-90f));
        }
        else
        {
            spawnedBlock = Instantiate(ListOfBlocks[currentpos].GetPrefab(), spawn.transform.position, Quaternion.identity);
        }
        
        BlocksAdded.Push(spawnedBlock);
    }

    public void Undo()
    {
        if (BlocksAdded.Count > 0)
        {
            GameObject RemoveBlock = BlocksAdded.Pop();
            Destroy(RemoveBlock);
        }
        
    }

    public override string ReturnDesc()
    {
        throw new System.NotImplementedException();
    }
}
