using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoCounter : MonoBehaviour
{
    public GameObject player;
    public Gun gun = null;
    public TMP_Text text;

    

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        text = GameObject.FindGameObjectWithTag("UI").GetComponent<TMP_Text>();
        gun = GameObject.FindGameObjectWithTag("GunContainer").GetComponentInChildren<Gun>();
        text.text = "Ammo " + gun.currentAmmo + " / " + (gun.allAmmo + gun.currentAmmo);
    }

}
