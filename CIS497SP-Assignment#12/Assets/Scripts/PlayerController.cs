/* 
 * John Mordi
 * PlayerController.cs 
 * Assignment #12
 * Handles player inputs and the games response to them
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GroupComposite armiesToLoad;
    public GroupComposite premade1, premade2;
    public GroupComposite temp1, temp2;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            armiesToLoad.Spawn(null);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            temp1 = Instantiate(premade1);
            armiesToLoad.units[0] = temp1;
            armiesToLoad.units[0].unitType = ArmyComponent.UnitType.Allied;
            Debug.Log(armiesToLoad.units[0].unitType);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            temp2 = Instantiate(premade2);
            armiesToLoad.units[0] = temp2;
            armiesToLoad.units[0].unitType = ArmyComponent.UnitType.Allied;
            Debug.Log(armiesToLoad.units[0].unitType);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            temp1 = Instantiate(premade1);
            armiesToLoad.units[1] = temp1;
            armiesToLoad.units[1].unitType = ArmyComponent.UnitType.Enemy;
            Debug.Log(armiesToLoad.units[1].unitType);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            temp2 = Instantiate(premade2);
            armiesToLoad.units[1] = temp2;
            armiesToLoad.units[1].unitType = ArmyComponent.UnitType.Enemy;
            Debug.Log(armiesToLoad.units[1].unitType);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
