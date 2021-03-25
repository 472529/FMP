﻿using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;
    public float fireRate = 2f;

    PlayerController player;
    public Camera fpsCam;
    ParticleSystem muzzleFlash;
    GameObject impactEffect;
    New_Weapon_Recoil_Script recoil;
    AudioSource gunSound;

    private float nextTimeForFire = 2f;

    private void Start()
    {
        gunSound = GetComponent<AudioSource>();
        recoil = GetComponent<New_Weapon_Recoil_Script>();
        fpsCam = gameObject.GetComponent<Camera>();
        
    }
    void Update()
    {
        
        if (Input.GetButton("Fire1") && Time.time >= nextTimeForFire)
        {
            nextTimeForFire = Time.time + 1f / fireRate;
            Shoot();
        }

    }

    void Shoot()
    {
        gunSound.Play();
        recoil.Fire();
        muzzleFlash.Play();
        RaycastHit hit;

        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);

        }

        
    }
}
