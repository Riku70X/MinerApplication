using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miner : Worker
{
    //public members
    //These values can be monitored and edited by our "states"
    public int m_Gold;
    public int m_BankedGold;
    public int m_Tiredness;
    public int m_Thirst;

    //These values cannot change at runtime
    private readonly int maxGoldStorage;
    private readonly int maxTiredness;
    private readonly int maxThirst;

    public Miner()
    {
        pState = new MiningForGold();

        m_Gold = 0;
        m_BankedGold = 0;
        m_Tiredness = 0;
        m_Thirst = 0;

        maxGoldStorage = 5;
        maxTiredness = 10;
        maxThirst = 7;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
