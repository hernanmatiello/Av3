using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field)]
public class PotionSelectorAttribute : PropertyAttribute
{
	
}

public class TestBehaviour : MonoBehaviour
{
	[PotionSelector]
	public string potionName;

	int indice;

	public void Start()
	{
		for (int x = 0; x < PotionDB.Instance.potions.Length; x++)
		{
			if (PotionDB.Instance.potions [x].name == potionName) {
				Debug.Log (PotionDB.Instance.potions [x].name + ": +" + PotionDB.Instance.potions [x].heal + " hp");
			}
		}
	}
}
