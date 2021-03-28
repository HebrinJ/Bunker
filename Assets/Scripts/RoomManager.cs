using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    private RoomScriptableObject currentType;
    private RoomList roomTypes;
    private Room room;

    private void Start()
    {
        currentType = GetComponentInChildren<RoomTypeHolder>().roomType;
        roomTypes = Resources.Load<RoomList>(typeof(RoomList).Name);
        room = GetComponentInChildren<Room>();
    }

    public void CreateRoom(GameObject prefab)
    {
        GameObject newRoom = Instantiate(prefab, transform.position, Quaternion.identity);
        newRoom.transform.SetParent(transform);
        newRoom.name = "Room";
        Debug.Log("Create");
    }

    private void DestroyRoom()
    {
        Destroy(transform.Find("Room").gameObject);
    }

    private void OnMouseDown()
    {
        currentType = GetComponentInChildren<RoomTypeHolder>().roomType;
        ButtonEvents.currentRoom = transform.Find(GetComponentInChildren<Room>().name).gameObject;
        room.OpenRoomMenu();
        Debug.Log("Click");
        /*if (currentType == roomTypes.roomList[0])
        {
            Debug.Log("InCycle");
            room.OpenPanel();
            room.transform.SetParent(GameObject.Find("Canvas").transform);
            //GameObject panel = Instantiate(GetComponentInChildren<Room>().roomPanel, transform.position, Quaternion.identity);
            //panel.transform.SetParent(GameObject.Find("Canvas").transform);
            //panel.SetActive(true);
            //currentType.callingPanel.SetActive(true);
            //DestroyRoom();
            //CreateRoom(GameAssets.Instance.pfPlaceForCreate);
        }
        else if (currentType == roomTypes.roomList[1])
        {
            DestroyRoom();
            CreateRoom(GameAssets.Instance.pfPlaceForCreate);
        }
        else
        {

        }*/
    }
}
