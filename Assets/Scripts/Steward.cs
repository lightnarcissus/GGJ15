using UnityEngine;
using System.Collections;

public class Steward : MonoBehaviour {

	public float _angle;
	public float _moveIncrement;
	public float _moveTiming;

	private Vector3 __startPos;
	private int __forward_backward = 1;
	private bool __responding = false;

	// Use this for initialization
	void Start () {
		__startPos = transform.position;	
	}
	
	// // Update is called once per frame
	// void Update () {
	
	// }

	public void RespondToCall() {
		if (!__responding) {
			InvokeRepeating("MoveForward", 0, _moveTiming);
			__responding = true;
		}
	}

	public void MoveForward() {
		Quaternion angle = Quaternion.Euler(0, 0, _angle * __forward_backward);
		transform.rotation = angle;
		__forward_backward *= -1;

		transform.position += new Vector3(_moveIncrement, 0, 0);
		if (transform.position.x >= Mathf.Abs(__startPos.x) + 5) {
			// transform.position = new Vector3(__startX, 0, 0);
			transform.position = __startPos;
			CancelInvoke();
			__responding = false;
		}
	}
}
