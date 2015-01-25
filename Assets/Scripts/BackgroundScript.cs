using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {

	public Transform _background;
	[Range(0, 1)]
	public float _parallax;

	private ArrayList __backgrounds = new ArrayList();

	private float __spriteWidth;

	// Use this for initialization
	void Start () {

		Renderer bRenderer = _background.renderer;
		float xbound = bRenderer.bounds.extents.x;
		__spriteWidth = xbound * 2;

		SetupBackgrounds(__backgrounds, _background);

	}
	
	// Update is called once per frame
	void Update () {
		ApplyParalax(__backgrounds, _parallax);
	}

	void SetupBackgrounds(ArrayList array, Transform background) {
		array.Add(background);
		Transform background2 = (Transform)Instantiate(background);
		background2.position = new Vector3(__spriteWidth, background.position.y, background.position.z);
		background2.parent = background.parent;
		array.Add(background2);
	}

	void ApplyParalax(ArrayList array, float parallax) {

		for (int index = 0; index < array.Count; index++) {
			Transform tran = (Transform)array[index];
			tran.position += new Vector3(-parallax, 0, 0);
		}

		//if the first background sprite has moved offscreen, put it up at the
		//top and at the end of the background array
		Transform first_tran = (Transform)array[0];
		if (!first_tran.renderer.isVisible) {
			array.RemoveAt(0);
			Transform last_tran = (Transform)array[array.Count - 1];
			first_tran.position = last_tran.position + new Vector3(__spriteWidth, 0, 0);
			array.Add(first_tran);
		}
	}
}
