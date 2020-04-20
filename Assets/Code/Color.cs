using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    private static UnityEngine.Color black;
    private static UnityEngine.Color white;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
    }

    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
