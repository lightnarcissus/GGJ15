using UnityEngine;
using System.Collections;

public class GuyRecline : KeyTriggeredBehavior {

	// Use this for initialization
	public override void Start () {
        gameObject.GetComponent<Animator>().enabled = false; 
	}
	
	// Update is called once per frame
    public override void Update()
    {
        base.Update();
	}

    public override void PlayAction()
    {
        gameObject.GetComponent<Animator>().enabled = true; //triggers GuyRecline movement
    }
}
