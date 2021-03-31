using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public Gun gun;

    private void Start()
    {
        gun = GameObject.FindGameObjectWithTag("Gun").GetComponent<Gun>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            gun.allAmmo += 20;
            Destroy(gameObject);
        }
    }

}
