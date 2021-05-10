/* 
 * John Mordi
 * ArmyComponent.cs 
 * Assignment #12
 * Abstract class for the needed classes in making the premade armies
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ArmyComponent : MonoBehaviour
{
    public enum UnitType
    {
        Warrior, Tank, Allied, Enemy, ArmiesToSpawn
    }
    public UnitType unitType;
    public GameObject prefab;

    public abstract UnitType GetUnitType();
    public abstract GameObject GetPrefab();
    public virtual void Spawn(GameObject panel)
    {
        Debug.Log("Method not implemented.");
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
