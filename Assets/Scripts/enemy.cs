using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject explosionPrefab;
    private gamemanager gameManager;
    public bool canBeShot = true;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        if(whatDidIHit.tag == "Player")
        {
            whatDidIHit.GetComponent<player>().LoseLife();
           if(canBeShot == true){
               Instantiate(explosionPrefab, transform.position, Quaternion.identity);
           }
            Destroy(this.gameObject);
        } else if(whatDidIHit.tag == "weapon")
        {
            if(canBeShot == true){
             Destroy(whatDidIHit.gameObject);
             Instantiate(explosionPrefab, transform.position, Quaternion.identity);
             gameManager.AddScore(5);
             Destroy(this.gameObject);
            }    
        }
    }
}
