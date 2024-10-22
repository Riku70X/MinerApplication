using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bark : State
{
    public override void Execute(Worker worker)
    {
        MinersDog minersDog = (MinersDog)worker;

        if (minersDog == null) { return; }

        // Print out information on what it is doing...
        Debug.Log("Barking!");

        // Increment the miner's dog's boredom
        minersDog.m_Boredom++;
    }
}
