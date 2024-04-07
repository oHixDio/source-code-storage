using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool IsPlayMode
    {
        get { return isPlayMode; }
        set { isPlayMode = value; }
    }
    bool isPlayMode;

    public bool IsTitleBack
    {
        get { return isTitleBack; }
    }
    bool isTitleBack;


    [SerializeField] GameObject startPanel;
    [SerializeField] Text saunaText;
    [SerializeField] GameObject titleBackPanel;
    AudioSource audioBGM;
    [SerializeField] AudioClip defaultClip;
    [SerializeField] AudioClip lastClip;
    [SerializeField] AudioClip fireClip;
    private void Awake()
    {
        audioBGM = GetComponent<AudioSource>();
        isPlayMode = false;
        isTitleBack = false;
        startPanel.SetActive(true);
    }
    void Start()
    {
        isPlayMode = false;
        audioBGM.Play();
    }


    public void HideStartPanel()
    {
        startPanel.SetActive(false);
        isPlayMode = true;
    }

    public void FireBGM()
    {
        audioBGM.clip = fireClip;
        audioBGM.Play();
    }
    public void DefaultBGM()
    {
        audioBGM.clip = defaultClip;
        audioBGM.Play();
    }
    public void LastBGM()
    {
        audioBGM.clip = lastClip;
        audioBGM.Play();
    }




    //example
    //���P�U�����܂łł��B
    //3��܂ŋL���ł��܂��B

    List<string> words = new List<string>()
    {
        "�Ȃ񂾂������ȏꏊ���ȁB\n�G���������񂢂�B\n�C��t���Ȃ��ƁB",
        "�T�E�i�̔��˂̒n�̓t�B�������h\n�炵���B���{�Ǝ��̕���\n����Ȃ��񂾂ˁB",
        "�t�B�������h��ŏ������C���Ӗ�����\nSauna���ꌹ�炵���ˁB",
        "�T�E�i�ɂ͊����Ɖ����������\n�ł��A��ʓI�Ɋ������T�E�i��\n�ĂԂ݂����B",
        "�x���`�̏�ɍs���قǔM����ˁB\n�l�͔M���̋�肾����\n���̐Ȃł�����B",
        "�T�E�i���ă��P�h���Ȃ��̂��ȁH\n�֎q�ɐڂ��Ă��镔����\n�M���Ȃ��Ă����ˁB",
        "�����C�͊����܂ŋ�肾�����ȁB\n���ǂ��̂���̓v�[����\n���Ⴂ���Ă���B",
        "���������ς��̎��̃T�E�i��\n���܂茒�N�ɗǂ��Ȃ���B",
        "���߂��߂Ƃ�����C���ȁB\n�����������炱�̐�̃T�E�i��\n�~�X�g�T�E�i��������Ȃ��B",
        "������ւ�̑���؂�\n�T�E�i�ɓ��ꂽ����ʂ��邩�ȁH\n����A��߂Ă������B",
        "������ւ�̐΂�\n�T�E�i�ɓ��ꂽ�烍�E�����݂�����\n���p�ł��邩�Ȃ��B",
        "���ꂾ������U������̃T�E�i��\n���������񂾂낤�Ȃ��B",
        "�����C���Ȃ�������\n������͂����I\n�����Ă���Ȃɂ�\n�O�͊����񂾂���I",
        "�T�E�i�͌����𑣐i���邩��\n���N�ɂƂ��Ă������񂾁I",
        "���ׂ������Ă�����\n�������Ă���Ƃ��̃T�E�i��\n�s���Ȃ��ق������������B",
        "�T�E�i�ɓ���Ύ��b���R�Ă����B\n�܂葉�����Ƃ������Ƃ��I",
        "���������ΓG����U������Ȃ���\n�T�E�i�̎���ɋ���G��\n������͂��Ȃ����Ă��Ƃ��B",
        "�����܂ŗV��ł���Ă��肪�Ƃ��I\n��:HiroGames66\n����̊������������肢���܂��B",
    };


    public void ShowWords()
    {
        saunaText.text = words[Random.Range(0, words.Count-1)];
        AudioManager.instance.WordsSE();
    }
    public void LastWords()
    {
        saunaText.text = words[words.Count -1];
        AudioManager.instance.WordsSE();
    }

    public void End()
    {
        titleBackPanel.SetActive(true);
        isTitleBack = true;
    }

    public void TitleBack()
    {
        SceneManager.LoadScene(0);
    }
    
}
