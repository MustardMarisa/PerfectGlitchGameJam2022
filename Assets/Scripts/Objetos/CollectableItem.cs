using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    [SerializeField]
    private int itemID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {

    
            switch (itemID)
            {
                case 0:
                //Player recolecta cierto item y se ejecuta el comportamiento del item
                break;
                    
                default:
                break;
            }
            

        Destroy(this.gameObject);
        
        }    
    }
}
