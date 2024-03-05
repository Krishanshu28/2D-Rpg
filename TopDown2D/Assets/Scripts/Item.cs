using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private string itemName;

    [SerializeField]
    private int quantity;

    [SerializeField]
    private Sprite sprite;

    private InventoryManager inventoryManager;

    bool itemPickUp;
    // Start is called before the first frame update
    void Awake()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
    }
    private void Start()
    {
        
    }

    void OnItemPickUp()
    {
        
        itemPickUp = true;
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { //ye bnd krna ho ki jis 
        
        if(collision.gameObject.CompareTag("Player") && itemPickUp)
        {
            //print("pick");
            inventoryManager.AddItem(itemName, quantity, sprite);
            Destroy(gameObject);
            itemPickUp=false;
        }
    }
    
}
