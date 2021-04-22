using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Gun gun;
    Enemy enemy;
    GeneratorBehaviour generatorBehaviour;
    public int maxHealth = 100;
    public int currentHealth;

    public Healthbar healthBar;
    public bool isLoadScene;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        healthBar = GameObject.FindGameObjectWithTag("UIHealth").GetComponent<Healthbar>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        isLoadScene = false;

    }

    // Update is called once per frame
    void Update()
    {
        healthBar.SetHealth(currentHealth);
        Death();
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void Death()
    {
        if(currentHealth <= 0)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            isLoadScene = true;
            SceneManager.LoadScene(0);
        }
    }
}
