using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Ingredient Object", menuName = "Scriptable Objects/Items/Ingredient")]
public class IngredientObject : ItemObject
{
    private void Awake()
    {
        base.type = ItemType.Ingredient;
    }
}
