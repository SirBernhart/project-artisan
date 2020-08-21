using UnityEngine;

public class CraftingStation : MonoBehaviour
{
    [SerializeField] private int numberOfSlots;
    [SerializeField] private RefinementType possibleRefinement;
    [SerializeField] private IngredientSlot[] ingredientSlots;
    [SerializeField] private GameObject resultSlot;

    // Decides if should combine or refine the ingredients
    public void ProcessIngredients()
    {
        int numberOfOccupiedSlots = GetNumberOfSlotsOccupied();

        if(numberOfOccupiedSlots > 1)
        {
            CombineIngredients();
        }
        else if(numberOfOccupiedSlots == 1)
        {
            RefineIngredient();
        }
    }

    private int GetNumberOfSlotsOccupied()
    {
        int slotsOccupied = 0;
        foreach(IngredientSlot slot in ingredientSlots)
        {
            if (slot.GetSlottedIngredient() != null)
            {
                ++slotsOccupied;
            }
        }

        return slotsOccupied;
    }

    private Ingredient[] GetIngredientsFromSlots()
    {
        Ingredient[] ingredients = new Ingredient[GetNumberOfSlotsOccupied()];

        int currentIngredientId = 0;
        foreach (IngredientSlot slot in ingredientSlots)
        {
            if(slot.GetSlottedIngredient() != null)
            {
                ingredients[currentIngredientId++] = slot.GetSlottedIngredient(); 
            }
        }

        return ingredients;
    }

    private void CombineIngredients()
    {

    }

    private void RefineIngredient()
    {
        Ingredient[] ingredientToRefine = GetIngredientsFromSlots();

        ingredientToRefine[0].SetActivatedEffect(ingredientToRefine[0].GetResultingEffect(possibleRefinement));

        ingredientToRefine[0].SetIsRefined(true);
    }
}
