using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaveADrink : State
{
    public override void Execute(Worker worker)
    {
        Miner miner = (Miner)worker;

        if (miner == null) { return; }

        // Print out information on what it is doing...
        Debug.Log("Having a drink.");

        // Drink water
        miner.m_Thirst -= 5;

        // Short trip to the water fountain
        miner.m_Tiredness += 2;
    }
}
