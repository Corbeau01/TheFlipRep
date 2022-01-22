using UnityEditor;

using Rotorz.ReorderableList;

[CustomEditor(typeof(Gear))]
public class GearInspector : Editor
{
    #region Private fields

    private SerializedProperty _itemsSerializedProperty;

    private ReorderableListControl _itemsReorderableListControl;

    #endregion

    #region Private editor methods

    private void OnEnable()
    {
        _itemsReorderableListControl = new ReorderableListControl();

        _itemsReorderableListControl.ItemInserted += HandleOnItemInserted;

        _itemsSerializedProperty = serializedObject.FindProperty("_itemStates");
    }

    private void OnDisable()
    {
        if (_itemsReorderableListControl == null) return;

        _itemsReorderableListControl.ItemInserted -= HandleOnItemInserted;
    }

    #endregion

    #region Private methods

    private void HandleOnItemInserted(object sender, ItemInsertedEventArgs args)
    {
        if (args.WasDuplicated) return;

        var item = _itemsSerializedProperty.GetArrayElementAtIndex(args.ItemIndex);

        if (item == null) return;

        var showSerializedProperty = item.FindPropertyRelative("Show");

        if (showSerializedProperty == null) return;

        showSerializedProperty.boolValue = true;
    }

    #endregion

    #region Public methods

    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        //_itemsReorderableListControl.Draw(new SerializedPropertyAdaptor(_itemsSerializedProperty));

        serializedObject.ApplyModifiedProperties();
    }

    #endregion
}
