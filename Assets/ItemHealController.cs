using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHealController : MonoBehaviour
{

    [SerializeField] private int itemHeal = 1;
    [SerializeField] private HealthController _healthController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Heal();
        }
    }

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
