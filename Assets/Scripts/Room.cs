using UnityEngine;

public class Room : MonoBehaviour
{
    private RoomType currentType;
            
    public GameObject buildRoomPanel;

    void Start()
    {
        currentType = SetType(RoomType.emptyField);
        
    }

    private void OnMouseOver()
    {
        
            if (Input.GetMouseButtonDown(0))
            {
                foreach (GameObject item in GameController.Instance.rooms)
                {
                    item.layer = 2;
                }
                

                if (currentType == RoomType.emptyField)
                {
                    buildRoomPanel.SetActive(true);
                    GameController.Instance.roomName = gameObject.name;
                    GameController.Instance.spriteName = "Room_empty_prototype";

                }
                else if (currentType == RoomType.emptyRoom)
                {
                    Debug.Log("type " + currentType);
                }
                else
                {
                    Debug.Log("type " + currentType);
                }
           
        }
    }

    private RoomType SetType(RoomType type)
    {
        return RoomType.emptyField;
    }

}

public enum RoomType
{
    emptyField,
    emptyRoom,
    entrance,
    reactor,
    workshop,
    storage,
    lifeQuat,
    waterStation,
    hydroFarm,
    lab,
    airCondition,
    garage,
    classicFarm,
    trainingRoom
}