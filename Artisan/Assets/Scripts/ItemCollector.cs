using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Inventory inventory;
    private List<Item> itensInRange = new List<Item>();

    public void CollectItem()
    {
        Item itemToCollect = GetNearestItem();

        if(itemToCollect != null)
        {
            inventory.TryAddItem(itemToCollect.item, 1);
        }
    }

    private Item GetNearestItem()
    {
        if(itensInRange.Count > 0)
        {
            Item nearestItem;
            nearestItem = itensInRange[0];
            foreach(Item item in itensInRange)
            {
                if (Vector3.Distance(item.transform.position, this.transform.position) < 
                    Vector3.Distance(nearestItem.transform.position, this.transform.position))
                {
                    nearestItem = item;
                }
            }
            return nearestItem;
        }
        return null;
    }

    public void AddItemInRange(Item item)
    {
        itensInRange.Add(item);
    }

    public void RemoveItemInRange(Item item)
    {
        itensInRange.Remove(item);
    }
}
