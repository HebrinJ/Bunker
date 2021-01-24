
using UnityEngine;

public class Outline : MonoBehaviour
{
    private SpriteRenderer sprite;
    public Material defaultMaterial, outlineMaterial;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    private void OnMouseEnter()
    {
        sprite.material = outlineMaterial;
    }

    private void OnMouseExit()
    {
        sprite.material = defaultMaterial;
    }
}
