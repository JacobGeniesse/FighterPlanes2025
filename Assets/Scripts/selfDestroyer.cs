using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfDestroyer : MonoBehaviour
{
    public float destructTime;
    private gamemanager gameManager;
    // Start is called before the first frame update
    void Start()
    {
      Destroy(this.gameObject, destructTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
