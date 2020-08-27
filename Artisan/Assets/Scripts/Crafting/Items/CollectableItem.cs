using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    [SerializeField] private Item itemScript;

    private void OnTriggerEnter(Collider other)
    {
        ItemCollector itemCollector = other.gameObject.GetComponent<ItemCollector>();
        if(itemCollector != null)
        {
            itemCollector.AddItemInRange(itemScript);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ItemCollector itemCollector = other.gameObject.GetComponent<ItemCollector>();

        if(itemCollector != null)
        {
            itemCollector.RemoveItemInRange(itemScript);
        }
    }
}
