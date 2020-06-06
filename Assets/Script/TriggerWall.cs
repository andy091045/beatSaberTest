using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWall : MonoBehaviour
{
    public Score andy;
    public Numbers amy;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        andy.MinusScore();
        amy.MinusScore();
        Lean.Pool.LeanPool.Despawn(col.gameObject);
        // Debug.Log("false");
        CancelInvoke("timer");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
