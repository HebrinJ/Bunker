using UnityEngine;

public class Room : MonoBehaviour
{
    private RoomScriptableObject currentType;
    //[SerializeField] private GameObject roomPanel;
    public GameObject roomPanel;
    void Start()
    {
        currentType = GetComponent<RoomTypeHolder>().roomType;
        roomPanel = GameAssets.Instance.buildRoomPanel;
        CloseRoomMenu();
    }    
    
    public void OpenRoomMenu()
    {
        roomPanel.SetActive(true);

        GameController.Instance.BlockRaycast();
    }

    public void CloseRoomMenu()
    {
        roomPanel.SetActive(false);

        GameController.Instance.UnblockRaycast();
    }
}
