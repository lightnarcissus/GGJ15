using UnityEngine;
using System.Collections;

public class KeyTriggeredBehavior : MonoBehaviour {

	public KeyCode _triggerKeyCode;

	// Use this for initialization
	public virtual void Start () {
	
	}
	
	// Update is called once per frame
	public virtual void Update () {
		if (Input.GetKeyDown(_triggerKeyCode)) {
			PlayAction();
		}	
	}

	public virtual void PlayAction() {

	}
}
