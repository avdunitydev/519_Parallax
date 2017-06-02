using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlane : MonoBehaviour {
    public Sprite[] elementSprites;
    int n;
    Image element;
	// Use this for initialization
	void Start () {
        n = 0;
        element = GetComponent<Image>();
        element.sprite = RandomSprite();

		Instantiate(element, transform.position, Quaternion.identity);
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    Sprite RandomSprite()
    {
        return elementSprites[Random.Range(0,elementSprites.Length)];
    }
}
