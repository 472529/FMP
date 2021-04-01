using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSpawner : MonoBehaviour
{
    Object ammoBox;
    // Start is called before the first frame update
    void Start()
    {
        ammoBox = Resources.Load("AmmoBox");
        Spawner();
    }

    // Update is called once per frame
    void Spawner()
    {
        float random = Random.Range(-1, 4);
        if (random == 2)
        {
            Instantiate(ammoBox, transform.position, transform.rotation);
        }
        else
        {

        }
    }
}
