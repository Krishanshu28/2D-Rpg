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

    [TextArea]  //inspector pe direct likh lena
    [SerializeField]
    private string itemDescription;

    private InventoryManager inventoryManager;

    bool itemPickUp;
    void Awake()
    {
        
    }
    private void Start()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
    }

    //for picking up item from "F" key and to add from gamepad 
    void OnItemPickUp()
    {
        itemPickUp = true;
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision.gameObject.CompareTag("Player") && itemPickUp)
        {
            //print("pick");
            inventoryManager.AddItem(itemName, quantity, sprite, itemDescription);
            Destroy(gameObject);
            itemPickUp=false;
        }
    }
    
}
