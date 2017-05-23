using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CubeLife : MonoBehaviour
{
	public float HP;


	// Use this for initialization
	void Awake ()
	{
		HP = 30;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnParticleCollision (GameObject go)
	{
		if (HP <= 0) {
			Destroy (gameObject);
		} else {
			--HP;
		}
	}
}
