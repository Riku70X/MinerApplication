using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bark : State
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
        MinersDog minersDog = (MinersDog)worker;

        if (minersDog == null) { return; }

        //Print out information on what it is doing...
        Debug.Log("Barking!");

        //Increment the miner's dog's boredom
        minersDog.m_Boredom++;

        if (minersDog.IsBored())
        {
            minersDog.ChangeState(new RunAround());
        }
    }
}
