using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    public float spinValue = 90;
    public Renderer rend;


    // Use this for initialization
    void Start()
    {

        rend = GetComponent<Renderer>();
         rend.enabled = true;


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * spinValue * Time.deltaTime);
    }

    public void flipSpin() 
    {
        Destroy(gameObject);

        AudioSource audio = GetComponent<AudioSource>();
         audio.Play();
         rend.enabled = false;
         gameObject.SetActive (false);

    }
}
      
                         