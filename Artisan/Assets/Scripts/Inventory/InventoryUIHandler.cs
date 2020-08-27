using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryUIHandler : MonoBehaviour
{
    [SerializeField] private Transform inventoryUI;
    [SerializeField] private GameObject itemSlotUIPrefab;

    public void UpdateInventory(int slotPosition, ItemObject itemObject, int amount)
    {
        inventoryUI.GetChild(slotPosition).GetComponentInChildren<Image>().sprite = itemObject.UISprite;
        inventoryUI.GetChild(slotPosition).GetComponentInChildren<TextMeshProUGUI>().text = amount.ToString();
    }

    public void ShowNewItem(ItemObject itemObject, int amount)
    {
        GameObject newItem = Instantiate(itemSlotUIPrefab, inventoryUI, false);

        newItem.GetComponentInChildren<Image>().sprite = itemObject.UISprite;
        newItem.GetComponentInChildren<TextMeshProUGUI>().text = amount.ToString();
    }

    public void RemoveAnItemAtSlotPosition(int slotPosition)
    {
        Destroy(inventoryUI.GetChild(slotPosition).gameObject);
    }
}
