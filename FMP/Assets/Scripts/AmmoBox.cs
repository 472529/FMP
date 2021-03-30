using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public Gun gun;
    private void OnTriggerEnter(Collider other)
    {
        gun = GetComponent<Gun>();
        if (other.gameObject.tag.Equals("Player"))
        {
            gun.allAmmo += 20;
            Destroy(gameObject);
        }
    }

}
