using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �Q�[���J�n���̉�ʂ�\������X�N���v�g
// �q�G�����L�[�ł͂��̃I�u�W�F�N�g�ȊOFalse�ɂ��Ă���
public class GameStart : MonoBehaviour
{
    private void Start()
    {
        UIMaster.instance.TitleUI.ShowTitle();
    }
}
