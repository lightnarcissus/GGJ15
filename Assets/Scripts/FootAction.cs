﻿using UnityEngine;
using System.Collections;

public class FootAction : KeyTriggeredBehavior {

	// Use this for initialization
	public override void Start () {
	
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update();	
	}

	public override void PlayAction() {
		Debug.Log("tap foot");
	}
}
