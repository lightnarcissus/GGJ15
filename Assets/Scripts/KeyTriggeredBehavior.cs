using UnityEngine;
using System.Collections;

public class KeyTriggeredBehavior : MonoBehaviour {

	public KeyCode _triggerKeyCode;

	protected Animator _animator;

	protected AudioSource _audio;

	// Use this for initialization
	public virtual void Start () {
		if (GetComponent<Animator>()) {
			_animator = GetComponent<Animator>();
		} else {
			Debug.Log("KeyTriggeredBehavior must have an animator!!!!");
		}

		if (GetComponent<AudioSource>()) {
			_audio = GetComponent<AudioSource>();
		}
	}
	
	// Update is called once per frame
	public virtual void Update () {
		if (Input.GetKeyDown(_triggerKeyCode)) {
			PlayAction();
		} else if (Input.GetKeyUp(_triggerKeyCode)) {
			PlayUpAction();
		}
	}

	public virtual void PlayAction() {
		if (_audio) {
			_audio.Play();
		}
	}

	public virtual void PlayUpAction() {
		if (_audio) {
			_audio.Stop();
		}
	}
}
