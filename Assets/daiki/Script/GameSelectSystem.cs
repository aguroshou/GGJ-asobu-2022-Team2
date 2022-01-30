using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSelectSystem : MonoBehaviour
{
    public int Stage_num;
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject CLEAR1;
    public GameObject CLEAR2;
    public GameObject CLEAR3;

    void Start()
    {
        //���݂�Stage_num���Ăяo��
        Stage_num = PlayerPrefs.GetInt("STAGE",0);
    }

    void Update()
    {
        if(Stage_num == 1)
        {
            //Stage_num��2�ȏ�̂Ƃ��A�X�e�[�W1�̉摜���N���A�摜�ɕύX
            Level1.SetActive(false);
            CLEAR1.SetActive(true);
        }

        if (Stage_num == 2)
        {
            //Stage_num��3�ȏ�̂Ƃ��A�X�e�[�W1�̉摜���N���A�摜�ɕύX
            Level2.SetActive(false);
            CLEAR2.SetActive(true);
        }

        if (Stage_num == 3)
        {
            //Stage_num��3�ȏ�̂Ƃ��A�X�e�[�W1�̉摜���N���A�摜�ɕύX
            Level3.SetActive(false);
            CLEAR3.SetActive(true);
        }
    }

    public void OnClickLevel1Button()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void OnClickLevel2Button()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void OnClickLevel3Button()
    {
        SceneManager.LoadScene("Stage3");
    }

    public void OnClicGameEndButton()
    {
        Application.Quit();
    }
}
