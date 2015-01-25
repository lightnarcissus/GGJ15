using UnityEngine;
using System.Collections;

public class TapFeet : KeyTriggeredBehavior
{
    // public static bool tapping = false;
    // public GameObject guy;
    // // Use this for initialization
    // public override void Start()
    // {
    // }

    // // Update is called once per frame
    // public override void Update()
    // {
    //     base.Update();
    // }

    // public override void PlayAction()
    // {
    //     gameObject.GetComponent<Animator>().enabled = true;
    //     guy.GetComponent<Animator>().enabled = true;
    //     guy.GetComponent<Animator>().Play("ManChange 1", 0);
    //     gameObject.GetComponent<Animator>().Play("TapHeel", 0); //triggers TapFingers movement
    // }

    public override void PlayAction() {
        _animator.SetTrigger("Tap");
        base.PlayAction();
    }

    public override void PlayUpAction() {
        _animator.SetTrigger("Idle");
        base.PlayUpAction();
    }
}