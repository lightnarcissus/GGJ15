using UnityEngine;
using System.Collections;

public class BackPassenger : KeyTriggeredBehavior {

	public int _angerTigger;

	private int __anger;

	// private SpriteRenderer _wolfHead;
	// private Animator _animator;

	// Use this for initialization
	public override void Start () {
		_animator = GetComponent<Animator>();
		// _wolfHead = GetComponent<SpriteRenderer>();	

		__anger = 0;

		base.Start();
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update();	
	}

	public override void PlayAction() {
		// __anger++;
		// if (__anger >= _angerTigger) {
			_animator.SetTrigger("Anger");
		// }
		base.PlayAction();
	}

	public override void PlayUpAction() {
		_animator.SetTrigger("Calm");
		base.PlayUpAction();
	}
}
