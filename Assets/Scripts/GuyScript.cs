using UnityEngine;
using System.Collections;

public enum AnimationState {
	Idle,
	Punch,
	Blow,
	CallSteward,
	Slap
};

public class GuyScript : MonoBehaviour {

	public KeyCode _blowKey;
	public KeyCode _punchKey;
	public KeyCode _callStewardKey;
	public KeyCode _slapKey;

	public Steward _steward;
	public StewardSign _sign;

	private Animator _animator;
	private AnimationState _animState;

	private AudioSource _audio;

	// private enum _animState 

	// Use this for initialization
	void Start () {
		_animator = gameObject.GetComponent<Animator>();
		_animState = AnimationState.Idle;
		_audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(_blowKey)) {
			_animator.SetTrigger("Blow");
			_audio.Play();
			_animState = AnimationState.Blow;
		} else if (Input.GetKeyUp(_blowKey)) {
			_audio.Stop();
			if(_animState == AnimationState.Blow) {
				_animator.SetTrigger("Idle");
				_animState = AnimationState.Idle;
			}
		}

		if (Input.GetKeyDown(_punchKey)) {
			_animator.SetTrigger("Punch");
			_animState = AnimationState.Punch;
		} else if (Input.GetKeyUp(_punchKey) && _animState == AnimationState.Punch) {
			_animator.SetTrigger("Idle");
			_animState = AnimationState.Idle;
		}

		if (Input.GetKeyDown(_callStewardKey)) {
			_animator.SetTrigger("Call");
			_animState = AnimationState.CallSteward;
			_steward.RespondToCall();
			_sign.Appear();
		} else if (Input.GetKeyUp(_callStewardKey)) {
			_sign.Hide();
			if (_animState == AnimationState.CallSteward) {
				_animator.SetTrigger("Idle");
				_animState = AnimationState.Idle;
			}
		}
	}

	public void ForceIdle() {
		_animator.SetTrigger("Idle");
		_animState = AnimationState.Idle;
	}
}
