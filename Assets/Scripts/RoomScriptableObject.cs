using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Room")]
public class RoomScriptableObject : ScriptableObject
{
    public string roomName;
    public Transform prefab;
    public GameObject callingPanel;
    
    //Характеристики//
    public int durability;
    public int performance;
    public int efficiency;
    public int safety;
    public int capacity;
    public int comfort;
    public int physDef;
    public int bioRadDef;
    public int activeDef;
}
