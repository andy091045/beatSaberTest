using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    /// <summary>
    /// OnTriggerExit is called when the Collider other has stopped touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerExit(Collider other)
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0);
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("finish");
            Application.Quit();
        }
    }
}
