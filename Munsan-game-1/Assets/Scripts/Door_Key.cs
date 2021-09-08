using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Key : MonoBehaviour
{
    public GameManager gameManager;
    public float RandomKey_1=0;
    public float RandomKey_2=0;
    public float RandomKey_3=0;
    public float RandomKey_4=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameManager = GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameManager.RandomKey.gameObject.SetActive(true);
            gameManager.RandomKeyPaper = true;
            
        }
    }
}
