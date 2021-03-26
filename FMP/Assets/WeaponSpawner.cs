using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    public Object ShotGun;
    
    void Start()
    {
        ShotGun = Resources.Load("870_Shotgun 1");
        Spawner();
    }

    public void Spawner()
    {
        Instantiate(ShotGun, transform.position, transform.rotation);
    }

   
    

    
}
