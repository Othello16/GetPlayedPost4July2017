using UnityEngine;
using System.Collections;

public class Music_player : MonoBehaviour {
	static Music_player instance = null;
	
	void Awake(){
		Debug.Log ("music player awake " + GetInstanceID());
		if (instance != null){
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		Debug.Log ("music player start " + GetInstanceID());
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
