using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHomeAndSleep : State
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Execute(Worker worker)
    {
        Miner miner = (Miner)worker;

        if (miner == null) { return; }

        //Print out information on what it is doing...
        Debug.Log("Sleeping...");

        //Decrease tiredness
        miner.m_Tiredness -= 2;

        if (miner.m_Tiredness <= 0)
        {
            miner.ChangeState(new MiningForGold());
        }
    }
}