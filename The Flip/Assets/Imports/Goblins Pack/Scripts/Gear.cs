
using System.Collections.Generic;
#if UNITY_EDITOR
using System.Linq;
#endif

using UnityEngine;

#pragma warning disable 649

public class Gear : MonoBehaviour
{
    #region Private serialized fields

    [SerializeField]
    private ItemState[] _itemStates;

    #endregion

    #region Private fields

    private List<Item> _items;

    #endregion

    #region Public properties

    public List<Item> Items
    {
        get { return _items; }
    }

    #endregion

    #region Private monobeahviour

    private void Awake()
    {
        _items = new List<Item>(_itemStates.Length);

        foreach (var itemState in _itemStates)
        {
            if (itemState.Item == null) continue;

            var item = itemState.Item;

            item.Show(itemState.Show);

            _items.Add(item);
        }
    }

#if UNITY_EDITOR
    private void OnValidate()
    {
        //only use linq expression in editor as certain platforms (iOS) do not fully support it
        foreach (var itemState in _itemStates.Where(itemBone => itemBone.Item != null))
        {
            itemState.Item.Show(itemState.Show);
        }
    }
#endif

    #endregion
}
