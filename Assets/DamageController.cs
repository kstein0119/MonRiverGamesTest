using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{

    [SerializeField] private int itemDamage;
    [SerializeField] private HealthController _healthController;

    public AudioSource hiss;

    /* private void Start()
    {
        hiss = GetComponent<AudioSource>();
    } */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            hiss.Play();
            Damage();
            
        }
    }

    void Damage()
    {
        _healthController.playerHealth -= itemDamage;
        _healthController.UpdateHealth();
        gameObject.SetActive(false); // Makes the item disappear after collision
    }

}
