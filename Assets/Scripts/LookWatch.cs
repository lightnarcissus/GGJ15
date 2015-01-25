using UnityEngine;
using System.Collections;

public class LookWatch : KeyTriggeredBehavior
{

    public CanvasController _ui;
    // // Use this for initialization
    // public override void Start()
    // {
    // }

    // // Update is called once per frame
    // public override void Update()
    // {
    //     base.Update();
    // }

    public override void PlayAction() {
        _animator.SetTrigger("show");
        _ui.DisplayWatch();
        base.PlayAction();
    }

    public override void PlayUpAction() {
        _animator.SetTrigger("hide");
        _ui.ReturnToPlane(CurrentDisplay.watch);
        base.PlayUpAction();
    }
}