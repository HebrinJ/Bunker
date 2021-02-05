using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    [System.NonSerialized]
    public string roomName;
    [System.NonSerialized]
    public string spriteName;
    [System.NonSerialized]
    public List<GameObject> rooms = new List<GameObject>();
    
    public Transform roomsParent;
    
    public GameObject buildRoomPanel;

    private void Start()
    {
        for (int i = 0; i < roomsParent.childCount; i++)
        {
            rooms.Add(roomsParent.GetChild(i).gameObject);
        }
        
    }
    public void SetSprite()
    {
        SpriteRenderer spriteRenderer = GameObject.Find(roomName).GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
            return;
        else
            spriteRenderer.sprite = Resources.Load<Sprite>("Sprites/Prototypes/" + spriteName);

        CloseWindow(buildRoomPanel);

        foreach (GameObject item in rooms)
        {
            item.layer = 0;
        }
    }
        
    public void CloseWindow(GameObject obj)
    {
        obj.SetActive(false);
        foreach (GameObject item in GameController.Instance.rooms)
        {
            item.layer = 0;
        }
    }
}
