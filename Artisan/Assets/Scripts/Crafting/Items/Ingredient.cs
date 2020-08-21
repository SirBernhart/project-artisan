using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    [SerializeField] private IngredientEffect possibleEffects;
    private IngredientEffectInitializer ingredientEffectInitializer;

    private EffectType activatedEffect;
    private bool isRefined;

    private void Start()
    {
        ingredientEffectInitializer = new IngredientEffectInitializer(possibleEffects);
    }

    public EffectType GetResultingEffect(RefinementType refinementType)
    {
        return possibleEffects.GetResultingEffect(refinementType);
    }

    public void SetActivatedEffect(EffectType value)
    {
        activatedEffect = value;
    }

    public EffectType GetActivatedEffect()
    {
        return activatedEffect;
    }

    public void SetIsRefined(bool value)
    {
        isRefined = value;
    }

    public bool GetIsRefined()
    {
        return isRefined;
    }
}
