using UnityEngine;
using System.Collections;

public class TapFingers : KeyTriggeredBehavior
{

    public GuyScript _guy;

    // // Use this for initialization
    // public override void Start()
    // {
    //     base.Start();
    // }

    // // Update is called once per frame
    // public override void Update()
    // {
    //     base.Update();
    // }

    public override void PlayAction()
    {
        _guy.ForceIdle();
        _animator.SetTrigger("Tap");
        base.PlayAction();
    }

    public override void PlayUpAction() {
        _animator.SetTrigger("Hide");
        base.PlayUpAction();
    }
}
