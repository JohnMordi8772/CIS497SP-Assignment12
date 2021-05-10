/* 
 * John Mordi
 * UnitLeaf.cs 
 * Assignment #12
 * These are the individual objects that would be help by the composite
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitLeaf : ArmyComponent
{
    public int amount;

    public override GameObject GetPrefab()
    {
        return prefab;
    }

    public override UnitType GetUnitType()
    {
        return unitType;
    }

    public override void Spawn(GameObject panel)
    {
        Instantiate(prefab, panel.transform);
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
