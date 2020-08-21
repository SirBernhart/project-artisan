using System.Collections.Generic;
using UnityEngine;

class IngredientEffectInitializer
{
    public IngredientEffectInitializer(IngredientEffect ingredientEffect)
    {
        List<EffectType> possibleEffects = ingredientEffect.possibleEffects;
        List<RefinementType> requiredRefinements = ingredientEffect.requiredRefinements;

        if (possibleEffects.Count != requiredRefinements.Count)
        {
            Debug.LogError("Number of effects differ from the number of required refinement");
        }
        else
        {
            for (int i = 0 ; i<possibleEffects.Count ; ++i)
            {
                ingredientEffect.effectsAndRequirementsDictionary.Add(requiredRefinements[i], possibleEffects[i]);
            }
        }
    }

}
