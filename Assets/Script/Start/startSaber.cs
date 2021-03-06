﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startSaber : MonoBehaviour
{
    public GameObject Sword;

    public GameObject NextSword;

    public GameObject changeSword;

    public AudioClip impact;
    AudioSource audiosource;

    public LayerMask layer;
    private Vector3 previousPos;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.name == "Controller (right)" || other.name == "Controller (left)")
        {
            Debug.Log("Change!");
            Sword.SetActive(false);
            NextSword.SetActive(true);

            changeSword = Sword;
            Sword = NextSword;
            NextSword = changeSword;

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Sword.SetActive(false);
            NextSword.SetActive(true);
            changeSword = Sword;
            Sword = NextSword;
            NextSword = changeSword;
            audiosource.PlayOneShot(impact);
        }
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 0)
            {
                audiosource.PlayOneShot(impact);
                Debug.Log("music");
                // hit.transform.gameObject.SetActive(false);

            }
        }
        previousPos = transform.position;


    }
}
