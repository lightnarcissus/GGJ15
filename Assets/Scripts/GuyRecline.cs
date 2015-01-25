using UnityEngine;
using System.Collections;

public class GuyRecline : KeyTriggeredBehavior {

	// Use this for initialization
    public static bool reclining = false;
    public GameObject back;
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
        
          gameObject.GetComponent<Animator>().enabled = true;
            back.GetComponent<Animator>().Play("NoWolf", 0);
           // gameObject.GetComponent<Animator>().Play("ManRecline", 0);
      /*  if(!reclining)
        {
            gameObject.GetComponent<Animator>().enabled = true; 
        gameObject.GetComponent<Animator>().Play("ManRecline",0);
        reclining=true;
        }
        else
        {
            gameObject.GetComponent<Animator>().enabled = true; 
            gameObject.GetComponent<Animator>().Play("ManChange 0", 0);
            reclining = false;
        }*/
                        //triggers GuyRecline movement
    }
}
