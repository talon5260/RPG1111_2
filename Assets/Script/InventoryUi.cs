using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.UI;
public class InventoryUi : MonoBehaviour
{
   public GameObject InventoryPanel;
    bool activeInventory = false;


    private void Start()
    {
        InventoryPanel.SetActive(activeInventory);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            activeInventory = !activeInventory;
            InventoryPanel.SetActive(activeInventory);
        }
        
    }
    public void StartInventory()
    {
        InventoryPanel.SetActive(true);
    }
    public void ExitInventory()
    {
        InventoryPanel.SetActive(false);
    }
}
