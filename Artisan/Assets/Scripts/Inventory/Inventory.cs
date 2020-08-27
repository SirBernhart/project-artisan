using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<InventorySlot> inventorySlots = new List<InventorySlot>();
    [SerializeField] private int numberOfSlots;
    [SerializeField] private InventoryUIHandler inventoryUIHandler;

    public bool TryAddItem(ItemObject newItem, int additionalAmount)
    { 
        int indexThatWillStore = GetItemIndexInSlots(newItem);

        if(indexThatWillStore == -1)
        {
            if (inventorySlots.Count <= numberOfSlots)
            {
                inventorySlots.Add(new InventorySlot(newItem, additionalAmount));
                inventoryUIHandler.ShowNewItem(newItem, additionalAmount);

                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            inventorySlots[indexThatWillStore].AddAmount(additionalAmount);
            inventoryUIHandler.UpdateInventory(indexThatWillStore,
                                                inventorySlots[indexThatWillStore].item,
                                                inventorySlots[indexThatWillStore].amount);
            return true;
        }
    }

    public bool RemoveEntireItem(Item itemToRemove)
    {
        int indexThatWillRemove = GetItemIndexInSlots(itemToRemove.item);
        if(indexThatWillRemove > -1)
        {
            inventorySlots.RemoveAt(indexThatWillRemove);
            inventoryUIHandler.RemoveAnItemAtSlotPosition(indexThatWillRemove);
            return true;
        }
        
        return false;
    }

    private int GetItemIndexInSlots(ItemObject item)
    {
        for (int i = 0; i < inventorySlots.Count; ++i)
        {
            if (inventorySlots[i].item == item)
            {
                return i;
            }
        }

        // If the item hasn't been found
        return -1;
    }
}
