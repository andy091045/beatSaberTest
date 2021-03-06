﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class saber : MonoBehaviour
{
    public GameObject Sword;

    public GameObject NextSword;

    public GameObject changeSword;

    public AudioClip impact1;
    public AudioClip impact2;
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

    void OnTriggerEnter(Collider other)
    {

        if (other.name == "Controller (right)" || other.name == "Controller (left)")
        {
            audiosource.PlayOneShot(impact2);
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
        if (Input.GetKeyDown(KeyCode.B))
        {
            audiosource.PlayOneShot(impact1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Sword.SetActive(false);
            NextSword.SetActive(true);
            changeSword = Sword;
            Sword = NextSword;
            NextSword = changeSword;
            audiosource.PlayOneShot(impact2);
        }
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 0)
            {
                audiosource.PlayOneShot(impact1);
                Debug.Log("music");
                Lean.Pool.LeanPool.Despawn(hit.transform.gameObject);
                andy.distroyCube();
                amy.distroyCube();

            }
        }
        previousPos = transform.position;


    }
}
