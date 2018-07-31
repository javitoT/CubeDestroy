using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text txt;
	public int score;
	public int deltaScore;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		var boxes = GameObject.FindGameObjectsWithTag("Box");
 	
 	    score = boxes.Length;
 	    txt.text = "" + score;
 	    if (boxes.Length == 0) 
 			{
 	    	txt.text = "";
 			}	
		
	}
}
