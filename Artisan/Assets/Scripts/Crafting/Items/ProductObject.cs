using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Product Object", menuName = "Scriptable Objects/Items/Product")]
public class ProductObject : ItemObject
{
    private void Awake()
    {
        base.type = ItemType.Product;
    }
}
