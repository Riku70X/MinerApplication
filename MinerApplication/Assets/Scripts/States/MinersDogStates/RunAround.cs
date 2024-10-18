using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAround : State
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
        Debug.Log("Running around!");

        //Decrease the miner's dog's boredom
        minersDog.m_Boredom -= 2;

        if (minersDog.m_Boredom <= 0)
        {
            minersDog.ChangeState(new SniffOutGold());
        }
    }
}