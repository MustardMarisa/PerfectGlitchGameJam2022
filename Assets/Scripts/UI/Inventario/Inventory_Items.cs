using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_Items : MonoBehaviour
{
    Inventory_Player inventory;
    public ParticleSystem particulas;
    public Sprite sprite;
    public string nameItem;
    public TipoItems type;
    void Start()
    {
        inventory = Inventory_Player.estancia;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Item Agregado");
            for(int i = 0; i < inventory.items.Length; i++)
            {
                if (inventory.items[i].lleno == false) {
                    inventory.items[i].lleno = true;
                    inventory.items[i].cantidad = 1;
                    inventory.items[i].type = type;
                    inventory.items[i].nombre = name;
                    inventory.items[i].textslot.text = inventory.items[i].cantidad.ToString();
                    inventory.items[i].slot.GetComponent<Image>().sprite = sprite;
                    inventory.items[i].slot.GetComponent<Image>().enabled = true;
                    Destroy(this.gameObject);
                    Instantiate(particulas, transform.position, Quaternion.identity);
                    break;
                }

                if (inventory.items[i].lleno==true && inventory.items[i].type == type && inventory.items[i].cantidad < 64)
                {
                    Debug.Log("Item estanqueado");
                    inventory.items[i].cantidad += 1;
                    inventory.items[i].textslot.text = inventory.items[i].cantidad.ToString();
                    Destroy(gameObject);
                    Instantiate(particulas,transform.position,Quaternion.identity);
                    break;
                }
                
            }
        }
    }
}
