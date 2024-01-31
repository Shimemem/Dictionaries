using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class SerializableValuePair<Tkey, TValue>
{
    public Tkey Key;
    public TValue Value;

    public SerializableValuePair(Tkey key, TValue value)
    {
        Key = key;
        Value = value;
    }
}


public class InventorySystem : MonoBehaviour
{
    [SerializeField]
    public Dictionary<int, Items> inventory = new Dictionary<int, Items>();
    [SerializeField]
    private List<SerializableValuePair<int, Items>> inventoryList = new List<SerializableValuePair<int, Items>>();

    public void SyncListWithDictionary()
    {
        inventoryList.Clear();
        foreach (var pair in inventory)
        {
            inventoryList.Add(new SerializableValuePair<int, Items>(pair.Key, pair.Value));
        }
    }

    private void Update()
    {
        
    }

    public void AddItem(Items item)
    {
        if (inventory.ContainsKey(item.ID))
        {
            // update the quantity
        }
        else
        {
            inventory.Add(item.ID, item);
        }
        SyncListWithDictionary();
    }

    public bool RemoveItem(int itemID)
    {
        bool remove = inventory.Remove(itemID);
        if (remove)
        {
            SyncListWithDictionary();
        }
        return remove;
    }

    public bool CheckItem(int itemID)
    {
        return inventory.ContainsKey(itemID);
    }
}

