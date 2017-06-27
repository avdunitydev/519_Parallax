using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicPlay : MonoBehaviour
{
	public Button btnPlay;
	public AudioSource cameraAudioListener;


	public void SwichMusic ()
	{
		if (SceneManager.GetActiveScene ().Equals (SceneManager.GetSceneAt (0))) {
			btnPlay.interactable = !btnPlay.interactable;
		}
		
		if (cameraAudioListener.isPlaying) {
			cameraAudioListener.Stop ();
			transform.GetComponent<Image> ().color = new Color (225, 225, 225, 100);
		} else {
			cameraAudioListener.Play ();
			transform.GetComponent<Image> ().color = new Color (255, 255, 255, 255);
		}
	}
		
}
