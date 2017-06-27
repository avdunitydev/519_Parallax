using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScaler : MonoBehaviour
{

	public void ScaleUpItem (RectTransform targetItem)
	{
		targetItem.localScale += new Vector3 (0.2f, 0.2f, 0f);
	}

	public void ScaleNormalItem (RectTransform targetItem)
	{
		targetItem.localScale -= new Vector3 (0.2f, 0.2f, 0f);
	}
}
