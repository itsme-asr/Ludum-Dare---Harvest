using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    private Image healthBar;
    public float currentHealth;
    private float maxHealth = 100f;
    Life Player;
    void Start()
    {
        healthBar = GetComponent<Image>();
        Player = FindObjectOfType<Life>();
        //Player = FindObjectOfType<player>();

    }

    // Update is called once per frame
    private void Update()
    {

        currentHealth = Player.heal;
        //Debug.Log("Namaste World");
        healthBar.fillAmount = currentHealth / maxHealth;

    }


}
