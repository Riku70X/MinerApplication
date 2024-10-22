using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SniffOutGold : State
{
    public override void Execute(Worker worker)
    {
        MinersDog minersDog = (MinersDog)worker;

        if (minersDog == null) { return; }

        // Print out information on what it is doing...
        Debug.Log("Sniffing out gold!");

        // Increment the miner's dog's boredom
        minersDog.m_Boredom++;
    }
}
