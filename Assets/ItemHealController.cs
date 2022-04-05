using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHealController : MonoBehaviour
{

    [SerializeField] private int itemHeal = 1; // Default value for funsies
    [SerializeField] private HealthController _healthController;

    public AudioSource crunch;

    // When player runs into a food item, play the eating noise and call Heal()
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            crunch.Play(); // Play audio cue before potentially destroying object
            Heal();
        }
    }

    // Healing mechanics
    void Heal()
    {
        if(_healthController.playerHealth < 3) // If statement prevents overhealing 
        {
            _healthController.playerHealth += itemHeal;
        }
        
        _healthController.UpdateHealth();
        gameObject.SetActive(false); // Makes the item disappear after collision
    }

}
