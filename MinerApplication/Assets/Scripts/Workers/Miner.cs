using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Miner : Worker
{
    //public:

    // These values can be monitored and edited by our "states"
    public int m_Gold;
    public int m_BankedGold;
    public int m_Tiredness;
    public int m_Thirst;

    public Miner()
    {
        // Set the intial state as MiningForGold
        pState = new MiningForGold();

        m_Gold = 0;
        m_BankedGold = 0;
        m_Tiredness = 0;
        m_Thirst = 0;

        maxGoldStorage = 5;
        maxTiredness = 15;
        maxThirst = 7;
    }

    //protected:

    protected override void ChooseState()
    {
        if (IsAtMaxCapacity())
        {
            ChangeState(new BankingGold());
            return;
        }

        if (IsTired())
        {
            ChangeState(new GoHomeAndSleep());
            return;
        }

        if (IsThirsty())
        {
            ChangeState(new HaveADrink());
            return;
        }

        // If sleeping, stay sleeping until fully rested
        if (pState is GoHomeAndSleep)
        {
            if (m_Tiredness <= 0)
            {
                ChangeState(new MiningForGold());
            }

            return;
        }

        // Default state
        ChangeState(new MiningForGold());
    }

    //private:

    // These functions tell us about the data in the mutables
    private bool IsAtMaxCapacity() { return m_Gold >= maxGoldStorage; }
    private bool IsTired() { return m_Tiredness > maxTiredness; }
    private bool IsThirsty() { return m_Thirst > maxThirst; }

    // These values cannot change at runtime
    private readonly int maxGoldStorage;
    private readonly int maxTiredness;
    private readonly int maxThirst;
}
