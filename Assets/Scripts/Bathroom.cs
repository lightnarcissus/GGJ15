using UnityEngine;
using System.Collections;

public class Bathroom : KeyTriggeredBehavior {

	private bool __bladderFull = true;

	public override void PlayAction() {
		if (__bladderFull) {
			_animator.SetTrigger("go");
			__bladderFull = false;
		}
	}

	public override void PlayUpAction() {

	}

	public void SetBladderFull() {
		// Debug.Log("I have to go");
		__bladderFull = true;
	}

	public void PlayFlush() {
		_audio.Play();
	}

}
