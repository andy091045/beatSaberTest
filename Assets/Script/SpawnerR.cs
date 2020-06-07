using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;
using UnityEngine.UI;

public class SpawnerR : MonoBehaviour
{
    public Text WIN;
    public GameObject[] cubes;
    public Transform[] points;
    public float beat = (60 / 130) * 2;

    public sheepMusic playMusic;
    private float timer;

    public int i = 0;

    // Start is called before the first frame update

    private void Awake()
    {


    }
    void Start()
    {

    }
    public void WinGame()
    {
        WIN.enabled = !WIN.enabled;

    }
    // Update is called once per frame

    void Update()
    {


        if (timer > beat)
        {

            if (playMusic.musicBlue[i] == 1)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[1], points[0]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if (playMusic.musicBlue[i] == 2)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[1], points[1]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if (playMusic.musicBlue[i] == 3)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[1], points[2]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if (playMusic.musicBlue[i] == 4)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[1], points[3]);
                cube.transform.localPosition = Vector3.zero;
            }


            if (playMusic.musicRed[i] == 1)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[0], points[0]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if (playMusic.musicRed[i] == 2)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[0], points[1]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if (playMusic.musicRed[i] == 3)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[0], points[2]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if (playMusic.musicRed[i] == 4)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[0], points[3]);
                cube.transform.localPosition = Vector3.zero;
            }


            if (playMusic.musicYellow[i] == 1)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[2], points[0]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if (playMusic.musicYellow[i] == 2)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[2], points[1]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if (playMusic.musicYellow[i] == 3)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[2], points[2]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if (playMusic.musicYellow[i] == 4)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[2], points[3]);
                cube.transform.localPosition = Vector3.zero;
            }


            if (playMusic.musicPurple[i] == 1)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[3], points[0]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if (playMusic.musicPurple[i] == 2)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[3], points[1]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if (playMusic.musicPurple[i] == 3)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[3], points[2]);
                cube.transform.localPosition = Vector3.zero;
            }
            else if (playMusic.musicPurple[i] == 4)
            {
                GameObject cube = Lean.Pool.LeanPool.Spawn(cubes[3], points[3]);
                cube.transform.localPosition = Vector3.zero;
            }


            timer -= beat;
            i++;

        }
        timer += Time.deltaTime;
        if (i == 180)
        {
            WinGame();
        }
    }


}
