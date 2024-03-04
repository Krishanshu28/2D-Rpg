using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject InventoryMenu;
    public bool menuActivated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
}
