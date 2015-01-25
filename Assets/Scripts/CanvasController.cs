using UnityEngine;
using System.Collections;

public enum CurrentDisplay {
	plane,
	watch,
	phone
}

public class CanvasController : MonoBehaviour {

	public GameObject _introPanel;
	public GameObject _instructions;
	public GameObject _watch;
	public GameObject _smartphone;

	private bool __checkedPhone = false;
	private bool __checkedWatch = false;

	private CurrentDisplay _display;

	// Use this for initialization
	void Start () {
		// _display = CurrentDisplay.plane;	
		// _introPanel.active = true;
		DisplayCaptain();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space)) {
			_introPanel.active = false;
			ReturnToPlane(CurrentDisplay.plane);
		}	
	}

	public void DisplayCaptain() {
		_introPanel.active = true;
		_display = CurrentDisplay.plane;
		GetComponent<AudioSource>().Play();
	}

	public void DisplayPhone() {
		if (!__checkedPhone) {
			_smartphone.active = true;
			__checkedPhone = true;
		}
		_introPanel.active = false;
		_instructions.active = false;
		_watch.active = false;
		_display = CurrentDisplay.phone;
	}

	public void DisplayWatch() {
		if (!__checkedWatch) {
			__checkedWatch = true;
			_watch.active = true;
		}
		_introPanel.active = false;
		_instructions.active = false;
		_smartphone.active = false;
		_display = CurrentDisplay.watch;
	}

	public void ReturnToPlane(CurrentDisplay returnFrom) {
		if (_display == returnFrom) {
			if (!__checkedPhone || !__checkedWatch) {
				_instructions.active = true;
			}
			_smartphone.active = false;
			_watch.active = false;
			_display = CurrentDisplay.plane;
		}
	}
}
