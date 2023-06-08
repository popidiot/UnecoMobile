using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Change1 : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }

}
