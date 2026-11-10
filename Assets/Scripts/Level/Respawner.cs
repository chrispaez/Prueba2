using System;
using System.Collections;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField] Gem gemPrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform  spawnPoint2;
    [SerializeField] float respawnDelay ;
    
    private Gem spawnGem1;
    private Gem spawnGem2;
    
   
    
    void OnEnable()
    {
        if (gemPrefab != null && spawnPoint != null)
        {
           // Instantiate(gemPrefab, spawnPoint.position, spawnPoint.rotation);
         
           spawnGem1 = Instantiate(gemPrefab, spawnPoint.position, spawnPoint.rotation);
           Destroy(spawnGem1.gameObject, respawnDelay);
            
           Invoke("Respawn", respawnDelay);
        }
    }

    void OnDisable()
    {
        
        if (gemPrefab != null && spawnPoint2 != null)
        {
            spawnGem2 = Instantiate(gemPrefab, spawnPoint2.position, spawnPoint2.rotation);
            Destroy(spawnGem2.gameObject, respawnDelay);
            
            Invoke("Respawn", respawnDelay);
           // Instantiate(gemPrefab, spawnPoint2.position, spawnPoint2.rotation);
            
            
        }
    }
    
         
   
}
