using UnityEngine;
using System.Collections;

public class StewardSign : MonoBehaviour {

	public void Appear() {
		gameObject.active = true;
		GetComponent<AudioSource>().Play();
	}

	public void Hide() {
		gameObject.active = false;
	}
}
