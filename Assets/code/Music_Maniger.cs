using UnityEngine;
using System.Collections;

public class Music_Maniger : MonoBehaviour {

	private AudioSource audioSource;

	public AudioClip[] levelMusicChangeArray;
	
	void Awake() {
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destroy on load: " + name);
	}

	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	void OnLevelWasLoaded (int level) {
		AudioClip thisLevelMusic = levelMusicChangeArray [level];
		Debug.Log ("Playing clip: " + thisLevelMusic);

		if (thisLevelMusic) { //if there is some music attached
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}

	public void ChangeVolume (float volume){
		audioSource.volume = volume;
	}
}