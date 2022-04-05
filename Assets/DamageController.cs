using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{

    [SerializeField] private int itemDamage; // Default value for funsies
    [SerializeField] private HealthController _healthController;

    public AudioSource hiss;

    // When a player runs into an obstacle, play the hissing noise and call Damage()
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hiss.Play(); // Play audio cue before potentially destroying object
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
