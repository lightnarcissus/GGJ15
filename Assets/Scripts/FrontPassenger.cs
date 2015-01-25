using UnityEngine;
using System.Collections;

public class FrontPassenger : KeyTriggeredBehavior {

	// Use this for initialization
	public override void Start () {
		base.Start();
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update();	
	}

	public override void PlayAction() {
		_animator.SetTrigger("Gorilla");
		base.PlayAction();
	}

	public override void PlayUpAction() {
		_animator.SetTrigger("Idle");
		base.PlayUpAction();
	}
}
