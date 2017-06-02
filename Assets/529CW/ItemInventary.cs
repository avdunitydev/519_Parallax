using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInventary : MonoBehaviour {

    public Image itemImage;
    public Sprite[] elementSprites;

	void Start()
	{
		if (!itemImage.sprite)
		{
            itemImage.color = new Color(1, 1, 1, 0);
        }else {
            itemImage.sprite = RandomSprite();
			itemImage.color = new Color(1, 1, 1, 1);
        }
	}

	Sprite RandomSprite()
	{
		return elementSprites[Random.Range(0, elementSprites.Length)];
	}

    public void DragBegin()
	{
		print("begin " + gameObject.name);

		MouseInventar.mouse.imgMouse.sprite = itemImage.sprite;
		MouseInventar.mouse.imgMouse.color = new Color(1, 1, 1, 1);
        itemImage.color = new Color(1, 1, 1, 0);
		itemImage.sprite = null;
		MouseInventar.mouse.isMove = true;
	}

	public void DragEnd()
	{
		print("end " + gameObject.name);
		
        if (MouseInventar.mouse.isMove)
		{
			itemImage.sprite = MouseInventar.mouse.imgMouse.sprite;
			MouseInventar.mouse.imgMouse.color = new Color(1, 1, 1, 0);
			itemImage.color = new Color(1, 1, 1, 1);
			MouseInventar.mouse.imgMouse.sprite = null;
		}
	}

    public void Drop()
	{
		print("drop " + gameObject.name);
		if (itemImage.sprite)
		{
			Sprite temp;
			temp = itemImage.sprite;
			itemImage.sprite = MouseInventar.mouse.imgMouse.sprite;
			MouseInventar.mouse.imgMouse.sprite = temp;

		}
		else
		{
			itemImage.sprite = MouseInventar.mouse.imgMouse.sprite;
			MouseInventar.mouse.imgMouse.color = new Color(1, 1, 1, 0);
			itemImage.color = new Color(1, 1, 1, 1);
			MouseInventar.mouse.imgMouse.sprite = null;
			MouseInventar.mouse.isMove = false;
		}

	}

}
