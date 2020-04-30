using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mouse : MonoBehaviour
{

    private AudioSource back;

    // Start is called before the first frame update
    void Start()
    {
        back = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))        
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.CompareTag("Fire"))
                {
                    Rigidbody rb = hitInfo.collider.GetComponent<Rigidbody>();

                    if (rb)
                        rb.AddForce(-hitInfo.normal * 3, ForceMode.Impulse);

                }
            }
        }

    }

    public void lessVolumen()
    {
        if (back.volume > 0)
            back.volume -= 0.1f;
    }

    public void moreVolumen()
    {
        if (back.volume < 100)
            back.volume += 0.1f;
    }

    public void ChangeScene(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }

}
