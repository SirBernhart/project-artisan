using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientSlot : MonoBehaviour
{
    private Ingredient slottedIngredient;

    public Ingredient GetSlottedIngredient()
    {
        return slottedIngredient;
    }

    public bool TryAddIngredient(Ingredient ingredient)
    {
        if(slottedIngredient == null)
        {
            slottedIngredient = ingredient;
            return true;
        }
        else
        {
            return false;
        }
    }
}
