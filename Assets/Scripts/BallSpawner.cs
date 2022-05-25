using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject _ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBall();
    }

    void SpawnBall()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(_ball, new Vector3(34, 20*i, 23), Quaternion.identity);

            }

        }
    }
}
