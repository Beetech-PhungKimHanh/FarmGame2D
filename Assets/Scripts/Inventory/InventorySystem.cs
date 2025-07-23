using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = Constants.SCRIPTABLE_OBJECTS_FOLDER + "Systems/InventorySystem")]
public class InventorySystem : ScriptableObject
{
    public List<ItemData> items = new();

    public void AddItem(ItemData item)
    {
        items.Add(item);
    }

    public List<ItemData> GetItems() => new(items); // trả về bản sao
}
