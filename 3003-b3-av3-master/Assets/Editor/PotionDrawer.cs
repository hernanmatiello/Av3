using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(PotionSelectorAttribute))]
public class PotionDrawer : PropertyDrawer {

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		string[] potionsName = new string[PotionDB.Instance.potions.Length];

		for (int x = 0; x < PotionDB.Instance.potions.Length; x++) {
			potionsName [x] = PotionDB.Instance.potions [x].name;
		}

		int indicePotions = EditorGUI.Popup (
			position, 
			"Potions", 
			ArrayUtility.IndexOf(potionsName, property.stringValue), 
			potionsName);

		property.stringValue = PotionDB.Instance.potions[indicePotions].name;
	}
}