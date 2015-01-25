using UnityEngine;
using System.Collections;

public enum CurrentDisplay {
	plane,
	watch,
	phone,
	title,
	captain,
}

public class CanvasController : MonoBehaviour {

	public GameObject _introPanel;
	public GameObject _instructions;
	public GameObject _watch;
	public GameObject _smartphone;
	public GameObject _title;

	private bool __checkedPhone = false;
	private bool __checkedWatch = false;

	private CurrentDisplay _display;

	// Use this for initialization
	void Start () {
		_title.active = true;
		_display = CurrentDisplay.title;	
		// _introPanel.active = true;
		// DisplayCaptain();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space)) {
			if (_display == CurrentDisplay.title) {
				_title.active = false;
				DisplayCaptain();
			} else if (_display == CurrentDisplay.captain) {
				_introPanel.active = false;
				ReturnToPlane(CurrentDisplay.captain);
			}
		}	
	}

	public void DisplayCaptain() {
		_introPanel.active = true;
		_display = CurrentDisplay.captain;
		GetComponent<AudioSource>().Play();
	}

	public void DisplayPhone() {
		if (!__checkedPhone) {
			__checkedPhone = true;
		}
		_smartphone.active = true;
		_introPanel.active = false;
		_instructions.active = false;
		_watch.active = false;
		_display = CurrentDisplay.phone;
		GetComponent<AudioSource>().Stop();
	}

	public void DisplayWatch() {
		if (!__checkedWatch) {
			__checkedWatch = true;
		}
		_watch.active = true;
		_introPanel.active = false;
		_instructions.active = false;
		_smartphone.active = false;
		_display = CurrentDisplay.watch;
		GetComponent<AudioSource>().Stop();
	}

	public void ReturnToPlane(CurrentDisplay returnFrom) {
		if (_display == returnFrom) {
			if (!__checkedPhone || !__checkedWatch) {
				_instructions.active = true;
			}
			_smartphone.active = false;
			_watch.active = false;
			_display = CurrentDisplay.plane;
			GetComponent<AudioSource>().Stop();
		}
	}
}
