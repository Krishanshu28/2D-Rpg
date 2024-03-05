using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject InventoryMenu;
    public bool menuActivated;
    

    void OnInventory()
    {
        
        if(menuActivated)
        {
            Time.timeScale = 1;
            InventoryMenu.SetActive(false);
            menuActivated = false;
        }
        else if (!menuActivated)
        {
            Time .timeScale = 0;
            InventoryMenu.SetActive(true);
            menuActivated = true;
        }
    }
    

    public void AddItem(string itemName, int quantity, Sprite itemSprite)
    {
        Debug.Log("item Name= " + itemName + " quantity= " + quantity + " itemSprite= " + itemSprite);
    }
    
 
}
