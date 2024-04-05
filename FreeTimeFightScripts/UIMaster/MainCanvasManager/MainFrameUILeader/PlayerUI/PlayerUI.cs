using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] GameObject playerStatusPanel;
    [SerializeField] GameObject playerInfoPanel;
    [SerializeField] GameObject playerInventoryPanel;
    [SerializeField] GameObject playerGoldPanel;
    [SerializeField] GameObject playerEventPanel;

    public void HidePlayerUI()
    {
        this.gameObject.SetActive(false);
        //playerStatusPanel.SetActive(false);
        //playerInfoPanel.SetActive(false);
        //playerInventoryPanel.SetActive(false);
       // playerGoldPanel.SetActive(false);
       // playerEventPanel.SetActive(false);
    }

    // default�ł悭�g��
    public void ShowMainPanel()
    {
        HidePlayerUI();
        this.gameObject.SetActive(true);
        //playerStatusPanel.SetActive(true);
        // playerInfoPanel.SetActive(true);
        //playerGoldPanel.SetActive(true);
    }

    // EnemyStatus��\������Ƃ�
    public void ShowStatusPanel()
    {
        playerStatusPanel.SetActive(true);
    }
    public void HideStatusPanel()
    {
        playerStatusPanel.SetActive(false);
    }

    // Inventory��Button�Ŏg�p
    public void ShowInventory()
    {
        playerInfoPanel.SetActive(false);
        playerInventoryPanel.SetActive(true);
    }
    public void HideInventory()
    {
        playerInfoPanel.SetActive(true);
        playerInventoryPanel.SetActive(false);
    }

    // Player��Door�����蔻��Ɏg�p
    public void ShowEventPanel()
    {
        playerEventPanel.SetActive(true);
    }
    public void HideEventPanel()
    {
        playerEventPanel.SetActive(false);

    }
}
