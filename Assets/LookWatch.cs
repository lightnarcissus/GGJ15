using UnityEngine;
using System.Collections;

public class LookWatch : KeyTriggeredBehavior
{

    // Use this for initialization
    public override void Start()
    {
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    public override void PlayAction()
    {
        gameObject.GetComponent<Animator>().enabled = true;
        gameObject.GetComponent<Animator>().Play("YesWatch", 0); //triggers TapFingers movement
    }
}