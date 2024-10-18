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

    //These functions tell us about the data in the mutables
    public bool IsAtMaxCapacity() { return m_Gold >= maxGoldStorage; }
    public bool IsTired() { return m_Tiredness > maxTiredness; }
	public bool IsThirsty() { return m_Thirst > maxThirst; }

    public Miner()
    {
        //Set the intial state as MiningForGold
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
    protected override void Update()
    {
        base.Update();
    }
}
