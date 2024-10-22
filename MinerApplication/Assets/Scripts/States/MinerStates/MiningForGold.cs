using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningForGold : State
{
    public override void Execute(Worker worker)
    {
        Miner miner = (Miner)worker;

        if (miner == null ) { return; }
       
        // Print out information on what it is doing...
        Debug.Log("Digging for gold!");

        // Increment the miner's gold amount
        miner.m_Gold++;

        // Working makes you tired and thirsty
        miner.m_Tiredness++;
        miner.m_Thirst++;
    }
}
