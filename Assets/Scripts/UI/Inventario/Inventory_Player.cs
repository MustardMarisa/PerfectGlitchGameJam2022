using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public enum TipoItems
{
    Vacio,
    PocionStamina,
    PocionFuego,
    PocionHielo,
    PocionCuracion
}

[System.Serializable]
public class Itemclass
{
    public int cantidad;
    public TipoItems type;
    public bool lleno;
    public string nombre;
    public GameObject slot;
    public TMP_Text textslot;
}


public class Inventory_Player : MonoBehaviour
{
    

    public static Inventory_Player estancia;
    public Itemclass[] items;

    private void Awake()
    {
        estancia = this;
    }

  
}


