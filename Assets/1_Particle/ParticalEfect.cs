using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ParticalEfect : MonoBehaviour
{
	void OnParticleTrigger ()
	{
	}

	void OnParticleCollision (GameObject other)
	{
		ParticleSystem ps = GetComponent<ParticleSystem> ();
		List<ParticleCollisionEvent> collEvent1 = new List<ParticleCollisionEvent> ();
		List<ParticleCollisionEvent> collEvent2 = new List<ParticleCollisionEvent> ();
		List<ParticleCollisionEvent> collEvent3 = new List<ParticleCollisionEvent> ();
		
		if (other.name.Equals ("Cube (0)")) {
			int numCollisionEvents = ps.GetCollisionEvents (other, collEvent1);
			MeshRenderer mat = other.GetComponent<MeshRenderer> ();

			int i = 0;

			while (i < numCollisionEvents) {
				mat.material.color = new Color ((float)Random.Range (0, 250), (float)Random.Range (0, 250), (float)Random.Range (0, 250), (float)Random.Range (0, 250));
				i++;
			}
		}
		
		
	}

}
