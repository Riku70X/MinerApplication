using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinersDog : Worker
{
    //public:

    //These values can be monitored and edited by our "states"
    public int m_Boredom;

    //These functions tell us about the data in the mutables
    public bool IsBored() { return m_Boredom > maxBoredom; }

    public MinersDog()
    {
        //Set the initial state as SniffOutGold
        pState = new SniffOutGold();

        m_Boredom = 0;

        maxBoredom = 8;
    }

    //private:

    //These values cannot change at runtime
    private readonly int maxBoredom;
}
