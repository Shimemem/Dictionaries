using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public string ItemName;
    public int ItemID;
    public int Quantity;

    InventorySystem inventorySystem;
    // Start is called before the first frame update
    void Start()
    {
        inventorySystem = GameObject.FindGameObjectWithTag("Player").GetComponent<InventorySystem>();
    }

    // Update is called once per frame
    public void CollectItems()
    {
        Items itemToAdd = new Items(ItemName, ItemID, Quantity);
        inventorySystem.AddItem(itemToAdd);
        Destroy(gameObject);
    }
}
