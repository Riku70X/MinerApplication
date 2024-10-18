using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SniffOutGold : State
{
    bool FoundGold() { return Random.Range(0, 5) == 0; }

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
        Debug.Log("Sniffing out gold!");

        if (FoundGold())
        {
            minersDog.ChangeState(new Bark());
        }

        //Increment the miner's dog's boredom
        minersDog.m_Boredom++;

        if (minersDog.IsBored())
        {
            minersDog.ChangeState(new RunAround());
        }
    }
}
