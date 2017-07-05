using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class options_controller : MonoBehaviour {

	public Slider volumeSlider, diffSlider;
	public Level_Maniger Level_Maniger;
	
	private Music_Maniger Music_Maniger;

	// Use this for initialization
	void Start () {
		Music_Maniger = GameObject.FindObjectOfType<Music_Maniger> ();
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
		diffSlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
		Music_Maniger.ChangeVolume (volumeSlider.value);
	}

	public void SaveAndExit () {
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (diffSlider.value);
		Level_Maniger.LoadLevel ("01a Start");
	}

	public void SetDefaults () {
		volumeSlider.value = 0.8f;
		diffSlider.value = 2f;
	}	
}
