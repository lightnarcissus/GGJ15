using UnityEngine;
using System.Collections;

public class LookSmartphone : KeyTriggeredBehavior {

	public CanvasController _ui;

	// // Use this for initialization
	// void Start () {
	
	// }
	
	// // Update is called once per frame
	// void Update () {
	
	// }

	public override void PlayAction() {
		_animator.SetTrigger("show");
		_ui.DisplayPhone();
		base.PlayAction();
	}

	public override void PlayUpAction() {
		_animator.SetTrigger("hide");
		_ui.ReturnToPlane(CurrentDisplay.phone);
		base.PlayUpAction();
	}
}
