using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class Block: MonoBehaviour{
    public List<Block> blocks;
    public bool isPanel(){
        return false;
    }
    public bool isNewBlock(Block newBlock)
    {
        foreach (Block oldBlock in this.blocks)
        {
            if (oldBlock == newBlock)
            {
                return false;
            }
        }
        return true;
    }

    public void addBlock(Block block)
    {
        if (this.isNewBlock(block))
        {
            this.blocks.Add(block);
        }
    }
}