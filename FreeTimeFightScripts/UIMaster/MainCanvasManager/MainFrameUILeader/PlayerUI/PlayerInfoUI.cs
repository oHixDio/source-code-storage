using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerInfoUI : MonoBehaviour
{
    [SerializeField] Image playerIcon;
    [SerializeField] Text playerNameText;
    [SerializeField] Text playerLevelText;
    [SerializeField] Text playerWeaponText;
    [SerializeField] Text playerArmorText;
    [SerializeField] Text playerPetText;
    [SerializeField] Text playerFstSkillText;
    [SerializeField] Text playerSndSkillText;
    [SerializeField] Text playerTrdSkillText;

    // Actor��Update�Ŏg�p

    public void SetPlayerInfoUI(Sprite faceIcon, string name, int level)
    {
        playerIcon.sprite = faceIcon;
        playerNameText.text = name;
        playerLevelText.text = level.ToString();
    }

    // todo: ����A�h��A�y�b�g�̈������L�q����
    public void SetPlayerInventoryText()
    {
        playerWeaponText.text = string.Empty;
        playerArmorText.text = string.Empty;
        playerPetText.text = string.Empty;
    }

    // todo: �X�L��������n��
    public void SetPlayerSkillText()
    {
        playerFstSkillText.text = string.Empty;
        playerSndSkillText.text = string.Empty;
        playerTrdSkillText.text = string.Empty;
    }
}
