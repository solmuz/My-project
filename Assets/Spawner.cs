using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject myBoll;
    public void SpawnBoll()
    {
        Instantiate(myBoll);
    }
}
