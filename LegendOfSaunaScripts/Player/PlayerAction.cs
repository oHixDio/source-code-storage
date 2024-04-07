using Cainos.CustomizablePixelCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class PlayerAction : MonoBehaviour
{
    [SerializeField] Transform weaponSlot;

    PlayerState playerState;

    void Awake()
    {
        playerState = GetComponent<PlayerState>();
    }

    public void ChestOpen() //�`�F�X�g���J����Action
    {
        Weapon weapon = playerState.Chest.WeaponPrefab.GetComponent<Weapon>();
        Image weaponImage = playerState.Chest.ChestUI.transform.GetChild(1).GetComponent<Image>();

        playerState.BesideChest = false;


        if(weapon.Type() == Weapon.ItemType.Weapon)
        {
            playerState.BesideWeapon = true;
        }
        

        playerState.Chest.ChestAnime();
        AudioManager.instance.ChestOpenSE();




        weaponImage.sprite = weapon.WeaponSprite();
        weaponImage.color = new Color(1, 1, 1, 1);

        playerState.Chest.ChestUI.SetActive(true);


    }

    public void ChestClose() //�`�F�X�g��߂�Action
    {

        //playerState.Chest.IsOpen = false;
        playerState.Chest.ChestAnime();
        AudioManager.instance.ChestCloseSE();

        playerState.Chest.ChestUI.SetActive(false);

        playerState.BesideWeapon = false;

    }

    public void DropWeapon() //�����Ă��镐��𗎂Ƃ�
    {
        if (weaponSlot.childCount <= 0) return;
        Transform weapon = weaponSlot.GetChild(0);

        var c = weapon.GetComponent<Collider2D>();
        if (!c) return;
        c.isTrigger = false;
        weapon.gameObject.layer = LayerMask.NameToLayer("NotWepon");

        var r = weapon.GetComponent<Rigidbody2D>();
        if (!r) return;
        r.bodyType = RigidbodyType2D.Dynamic;                   //���ꊈ�p����

        weapon.transform.parent = null;
    }

    public void ClearWeapon() //����X���b�g����ɂ���
    {
        for (int i = 0; i < weaponSlot.childCount; i++)
        {
            var w = weaponSlot.GetChild(i);
            Destroy(w.gameObject);
        }
    }

    public void AddWeapon(GameObject weaponPrefab, bool clearOld = true) //������E��
    {
        if (weaponPrefab == null) return;
        DropWeapon();
        if (clearOld) ClearWeapon();

        AudioManager.instance.WeaponSE();

        weaponPrefab.layer = LayerMask.NameToLayer("HasWepon");

        var weapon = Instantiate(weaponPrefab);
        weapon.transform.parent = weaponSlot;
        weapon.transform.localPosition = Vector3.zero;
        weapon.transform.localRotation = Quaternion.identity;
    }

    public void Attack() //�U�������鏈��
    {
        
    }

    public void Damage() //�_���[�W��H�炤����
    {
        //Damage����
    }
    
    public void Dead()  //�̗͂��O�ɂȂ�������s
    {

    }

    
    public void PlayerATAmount()
    {
        Weapon weapon = playerState.GetWeapon.GetComponent<Weapon>();
        
        playerState.CurrentAT = playerState.PlayerAT + weapon.AttackPoint();
    }

}
