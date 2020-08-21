using System.Collections.Generic;
using System;
using UnityEngine;

public enum EffectType { Envigorate, Resist, Heal, Poison, Heat, Cold, Light }
public enum RefinementType { Mascerate, Toast, Distilation, Charring, Powdering, Drying, Decantation, Combination }

public class IngredientEffect : ScriptableObject
{
    public List<EffectType> possibleEffects = new List<EffectType>();
    public List<RefinementType> requiredRefinements = new List<RefinementType>();

    public Dictionary<RefinementType, EffectType> effectsAndRequirementsDictionary = new Dictionary<RefinementType, EffectType>();

    public EffectType GetResultingEffect(RefinementType refinement)
    {
        EffectType resultingEffect;
        effectsAndRequirementsDictionary.TryGetValue(refinement, out resultingEffect);

        return resultingEffect;
    }
}

