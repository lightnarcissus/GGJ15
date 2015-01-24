using UnityEngine;
using System.Collections;

public class PunchFront : KeyTriggeredBehavior
{
    public GameObject feet;
    public GameObject hand;
    public GameObject front;
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
        gameObject.GetComponent<Animator>().Play("ManChange 3", 0); //triggers TapFingers movement
      //   feet.GetComponent<Animator>().Play("NoFeet",0);
        hand.GetComponent<Animator>().Play("NoFingers 0", 0);
        front.GetComponent<Animator>().Play("GorillaShow", 0);
       
    }
}