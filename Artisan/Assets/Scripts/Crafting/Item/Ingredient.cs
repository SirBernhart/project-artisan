using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    [SerializeField] private IngredientEffect possibleEffects;
    private IngredientEffectInitializer ingredientEffectInitializer;

    private void Start()
    {
        ingredientEffectInitializer = new IngredientEffectInitializer(possibleEffects);
    }
}
