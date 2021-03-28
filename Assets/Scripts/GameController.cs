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
    public List<GameObject> placeHolders = new List<GameObject>();
    public List<GameObject> panels = new List<GameObject>();
    
    public Transform placeHoldersParent;
    
    public GameObject buildRoomPanel;

    private void Start()
    {
        for (int i = 0; i < placeHoldersParent.childCount; i++)
        {
            placeHolders.Add(placeHoldersParent.GetChild(i).gameObject);            
        }
        
    }

    public void SetType()
    {
        Destroy(gameObject);
    }
    /*public void SetSprite()
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
    }*/
        
    public void CloseWindow(GameObject obj)
    {
        obj.SetActive(false);
        foreach (GameObject item in placeHolders)
        {
            item.layer = 0;
        }
    }

    public void BlockRaycast()
    {
        foreach (GameObject item in placeHolders)
        {
            item.layer = 2;
        }
        Debug.Log("Raycast Block");
    }

    public void UnblockRaycast()
    {
        foreach (GameObject item in placeHolders)
        {
            item.layer = 0;
        }
    }
}
