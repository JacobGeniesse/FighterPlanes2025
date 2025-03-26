using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
public GameObject enemy01;
public GameObject enemy02;
// Start is called before the first frame update
    void Start()
    {
     InvokeRepeating("Enemy01Spawn", 2.0f, 0.3f);
     InvokeRepeating("Enemy02Spawn", 2.0f, 0.3f);
    }

   void Enemy01Spawn ()
   {
        var spawnpoint = new Vector3(Random.Range(-8.4f, 8.41f), 6.8f, 0f);
        Instantiate(enemy01, spawnpoint, Quaternion.identity);
    }

    void Enemy02Spawn (){
        var spawnpoint = new Vector3(11, Random.Range(-4.4f, 6.5f), 0f);
        Instantiate(enemy02, spawnpoint, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
    
    }
}
