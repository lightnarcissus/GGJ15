using UnityEngine;
using System.Collections;

public class LookSmartphone : KeyTriggeredBehavior {

	// // Use this for initialization
	// void Start () {
	
	// }
	
	// // Update is called once per frame
	// void Update () {
	
	// }

	public override void PlayAction() {
		_animator.SetTrigger("show");
		base.PlayAction();
	}

	public override void PlayUpAction() {
		_animator.SetTrigger("hide");
		base.PlayUpAction();
	}
}
