using UnityEngine;
using System.Collections;

public class MoveChair : KeyTriggeredBehavior
{

    // private AudioSource _audio;
    // private Animator animator;

    // Use this for initialization
    public override void Start()
    {
        // _audio = GetComponent<AudioSource>();
        // gameObject.GetComponent<Animator>().enabled = false;
        // _animator = gameObject.GetComponent<Animator>();
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    public override void PlayAction()
    {
        _animator.SetTrigger("ReclineChair");
        // _audio.Play();
        base.PlayAction();
    }

    public override void PlayUpAction() {
        _animator.SetTrigger("RaiseChair");
        // _audio.Stop();
        base.PlayUpAction();
    }
}
