using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider col)
    {

        Lean.Pool.LeanPool.Despawn(col.gameObject);
        Debug.Log("false");

    }
    // Update is called once per frame
    void Update()
    {

    }
}
