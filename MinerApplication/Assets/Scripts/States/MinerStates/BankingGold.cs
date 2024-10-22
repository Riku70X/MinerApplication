using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankingGold : State
{
    public override void Execute(Worker worker)
    {
        Miner miner = (Miner)worker;

        if (miner == null) { return; }

        //Move gold to the bank
        miner.m_BankedGold += miner.m_Gold;
        miner.m_Gold = 0;

        //Print out information on what it is doing...
        Debug.Log("Banking gold! Current balance: " + miner.m_BankedGold + " gold.");

        //Long trip to the bank
        miner.m_Tiredness += 3;
        miner.m_Thirst += 2;

        //Return to mining
        miner.ChangeState(new MiningForGold());
    }
}
