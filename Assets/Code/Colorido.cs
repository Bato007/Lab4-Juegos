using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorido : MonoBehaviour
{

    private AudioSource nani;

    // Start is called before the first frame update
    void Start()
    {
        nani = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseEnter()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        nani.Play();
    }

    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
