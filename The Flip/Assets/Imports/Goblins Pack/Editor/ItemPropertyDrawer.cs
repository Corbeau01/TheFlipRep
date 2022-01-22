using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(ItemState))]
public class ItemPropertyDrawer : PropertyDrawer
{
    #region Public methods

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        position.height = EditorGUIUtility.singleLineHeight;

        position.width = 14f;

        property.FindPropertyRelative("Show").boolValue = EditorGUI.Toggle(position, property.FindPropertyRelative("Show").boolValue);

        position.x += 25f;

        position.width = Screen.width * 0.8f;

        EditorGUI.ObjectField(position, property.FindPropertyRelative("Item"), GUIContent.none);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUIUtility.singleLineHeight;
    }

    #endregion
}
