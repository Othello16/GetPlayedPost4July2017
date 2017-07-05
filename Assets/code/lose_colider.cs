using UnityEngine;
using System.Collections;

public class lose_colider : MonoBehaviour {

	public Level_Maniger Level_Maniger;

	void OnTriggerEnter2D (Collider2D trigger) {
		print ("Trigger");
		Level_Maniger.LoadLevel("lose");
	}

	void OnCollisionEnter2D (Collision2D collision) {
		print ("Collision");
	}
}
