using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningForGold : State
{
    public override void Execute(Worker worker)
    {
        Miner miner = (Miner)worker;

        if (miner == null ) { return; }
       
        //Print out information on what it is doing...
        Debug.Log("Digging for gold!");

        //Increment the miner's gold amount
        miner.m_Gold++;

        //Working makes you tired and thirsty
        miner.m_Tiredness++;
        miner.m_Thirst++;

        // TO-DO: Check if a certain gold threshold has been reached, if so, then change to a different state using miner.ChangeState
        // This next state should make the Miner deposit gold into the bank (add m_Gold to m_BankedGold, then set m_Gold back to zero)
        // You will have to create a new class that inherits from "State" to achieve this (you can call this class "BankingGold")
        // Be sure to cout information at all stages so you can see how it is functioning

        if (miner.IsAtMaxCapacity())
        {
            miner.ChangeState(new BankingGold());
        }

        //	How many other states can you add? Try adding variables like "Tiredness" and "Thirstiness" to the Miner, and make the
        //  the miner change to other states based on those values
        //	e.g. if (miner.m_Tiredness > 10) miner.ChangeState(new GoHomeAndSleep());

        if (miner.IsTired())
        {
            miner.ChangeState(new GoHomeAndSleep());
        }

        if (miner.IsThirsty())
        {
            miner.ChangeState(new HaveADrink());
        }
    }
}
