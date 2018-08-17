using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(ReadOnlyWithColorAttribute))]
public class ReadOnlyWithColorAttributeDrawer : PropertyDrawer {

    string value = "";
    Color inputColor;
    ReadOnlyWithColorAttribute _attribute;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        _attribute = (ReadOnlyWithColorAttribute)attribute;
        inputColor = new Color(_attribute.r, _attribute.g, _attribute.b);

        if (property.propertyType == SerializedPropertyType.Integer)
            value = property.intValue.ToString();
        if (property.propertyType == SerializedPropertyType.Float)
            value = property.floatValue.ToString();
        if (property.propertyType == SerializedPropertyType.String)
            value = property.stringValue;

        GUI.color = inputColor;
        Debug.Log(GUI.color);
        GUI.Label(position, property.displayName + " : " + value);
        GUI.color = Color.white;
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label);
    }
}
