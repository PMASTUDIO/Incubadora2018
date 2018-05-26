using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour {
   public  Sprite s;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
       
	}

    public void Click()
        {
            Image ar = gameObject.GetComponent<Image>();

             ar.sprite = s;
        }
}
