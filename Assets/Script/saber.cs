using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class saber : MonoBehaviour
{

    public AudioClip impact;
    AudioSource audiosource;
    public Score andy;
    public Numbers amy;
    public LayerMask layer;
    private Vector3 previousPos;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            audiosource.PlayOneShot(impact);
        }
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 0)
            {
                audiosource.PlayOneShot(impact);
                Debug.Log("music");
                Destroy(hit.transform.gameObject);
                andy.distroyCube();
                amy.distroyCube();

            }
        }
        previousPos = transform.position;


    }
}
