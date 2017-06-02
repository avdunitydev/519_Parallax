using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MouseInventar : MonoBehaviour {

	public static MouseInventar mouse;
	public Image imgMouse;
	public bool isMove;

	void Awake()
	{
		mouse = this;
	}

	void Start()
	{
		imgMouse = GetComponent<Image>();
		imgMouse.color = new Color(1, 1, 1, 0);
		isMove = false;
	}

	void Update()
	{
		transform.position = Input.mousePosition;
	}

}
