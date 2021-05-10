/* 
 * John Mordi
 * GroupComposite.cs 
 * Assignment #12
 * This handles the groupings of leaves
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupComposite : ArmyComponent
{
    public List<ArmyComponent> units = new List<ArmyComponent>();
    GameObject panel;

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
        if(unitType == UnitType.Allied)
        {
            panel = GameObject.FindGameObjectWithTag("Allied");
        }
        else if(unitType == UnitType.Enemy)
        {
            panel = GameObject.FindGameObjectWithTag("Enemy");
        }
        foreach(ArmyComponent component in units)
        {
            if (component != null)
                component.Spawn(panel);
        }
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
