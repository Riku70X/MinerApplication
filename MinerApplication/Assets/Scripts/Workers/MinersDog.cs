using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinersDog : Worker
{
    //public:

    // These values can be monitored and edited by our "states"
    public int m_Boredom;

    public MinersDog()
    {
        // Set the initial state as SniffOutGold
        pState = new SniffOutGold();

        m_Boredom = 0;

        maxBoredom = 8;
    }

    //protected:

    protected override void ChooseState()
    {
        if (IsBored())
        {
            ChangeState(new RunAround());
            return;
        }

        if (pState is SniffOutGold && FoundGold())
        {
            ChangeState(new Bark());
            return;
        }

        // If running around, keep running around until no longer bored
        if (pState is RunAround)
        {
            if (m_Boredom <= 0)
            {
                ChangeState(new SniffOutGold());
            }

            return;
        }

        // Default state
        ChangeState(new SniffOutGold());
    }

    //private:

    // These functions tell us about the data in the mutables
    private bool IsBored() { return m_Boredom > maxBoredom; }

    // These values cannot change at runtime
    private readonly int maxBoredom;

    //TODO: Specific to the SniffOutGold state... should this be here?
    private bool FoundGold() { return Random.Range(0, 5) == 0; }
}
