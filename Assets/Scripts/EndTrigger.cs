using System;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            gameManager.LevelComplete();
        }
    }
    
}
