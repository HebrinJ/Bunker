using UnityEngine;
using UnityEngine.UI;

public class ButtonEvents : MonoBehaviour
{
    public static GameObject currentRoom;

    public Button buildEmptyRoomBtn;

    private void Start()
    {
        buildEmptyRoomBtn.onClick.AddListener(() => BuildEmptyRoom(currentRoom, GameAssets.Instance.pfLab));
    }

    private void BuildEmptyRoom(GameObject currentRoom, GameObject prefab)
    {        
        GameObject newRoom = Instantiate(prefab, currentRoom.transform.position, Quaternion.identity);
        newRoom.transform.SetParent(currentRoom.transform.parent.transform);
        Destroy(currentRoom.gameObject);
        GameController.Instance.UnblockRaycast();
    }
}
