using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wintxt : MonoBehaviour {

	public Text txt;
	

	// Use this for initialization
	void Start () {
				
	}
	
	// Update is called once per frame
	void Update () {

		var boxes = GameObject.FindGameObjectsWithTag("Box");
 		if (boxes.Length == 0) 
 			{
 	    	txt.text = "You Win! Now cross the GUORLIN door of perception...";
 	    	Debug.Log("All the boxes are gone");
 	    	Destroy(txt, 5);
 			}

	}	


}
