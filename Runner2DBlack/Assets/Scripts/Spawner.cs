using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject obstacle;

    public float Timebtwspawn;
    public float Starttimebtwspawn;

    private void Update()
    {
        if (Timebtwspawn <= 0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            Timebtwspawn = Starttimebtwspawn;

        }
        else
        {
            Timebtwspawn -= Time.deltaTime;
        }
    }

}
