using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

[CustomPropertyDrawer(typeof(MyReadOnlyAttribute))]
public class ReadOnlyAttributeDrawer : PropertyDrawer
{
    public override VisualElement CreatePropertyGUI(SerializedProperty property)
    {
        var propertyField = new PropertyField(property);
        propertyField.SetEnabled(false);
        propertyField.label = "Read Only: "+property.name;
        propertyField.tooltip = "This field is read only"; 
        
        return propertyField;
    }

    /*public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);
    }*/
}
