using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpawner : MonoBehaviour
{
    Object light;

    private void Start()
    {
        light = Resources.Load("Lamp");
        Spawner();
    }

    void Spawner()
    {
        Instantiate(light, transform.position, transform.rotation);

    }
}
