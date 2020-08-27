using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Ingredient,
    Product
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public Sprite UISprite;
    public ItemType type;
    [TextArea(15, 20)]
    public string description;
}
