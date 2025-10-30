using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSquare : MonoBehaviour
{
    public GameObject redBlock;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        redBlock.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "RedBlock")
        {
            gameObject.SetActive(false);
            Destroy(other.gameObject);
            redBlock.SetActive(true);
            
        }
    }
}
