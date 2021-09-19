using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        ScoreResult.result += 1;
        Debug.Log("Number of Animals Player Fed: " + ScoreResult.result);
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
