using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinersDog : Worker
{
    //public members
    //These values can be monitored and edited by our "states"
    public int m_Boredom;

    //These values cannot change at runtime
    private readonly int maxBoredom;

    //These functions tell us about the data in the mutables
    public bool IsBored() { return m_Boredom > maxBoredom; }

    public MinersDog()
    {
        //Set the initial state as SniffOutGold
        pState = new SniffOutGold();

        m_Boredom = 0;

        maxBoredom = 8;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
