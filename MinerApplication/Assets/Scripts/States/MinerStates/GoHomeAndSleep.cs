using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHomeAndSleep : State
{
    public override void Execute(Worker worker)
    {
        Miner miner = (Miner)worker;

        if (miner == null) { return; }

        // Print out information on what it is doing...
        Debug.Log("Sleeping...");

        // Decrease tiredness
        miner.m_Tiredness -= 2;
    }
}
