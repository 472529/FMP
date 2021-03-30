using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    public Object ShotGun;
    public Object AK47;
    
    void Start()
    {
        ShotGun = Resources.Load("870_Shotgun 1");
        AK47 = Resources.Load("AK-47 1");
        Spawner();
    }

    public void Spawner()
    {
        float random = Random.Range(1, 5);
        if(random == 1)
        {
            Instantiate(ShotGun, transform.position, transform.rotation);

        }
        else if(random == 3)
        {
            Instantiate(AK47, transform.position, transform.rotation);
        }
    }

   
    

    
}
