using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( menuName = "RoomList")]
public class RoomList : ScriptableObject
{
    public List<RoomScriptableObject> roomList;
}
