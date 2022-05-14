using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class BtnClickListeners : MonoBehaviour
{
    public Button GameBtn;
    public Button MenuBtn;
    public Button ShopBtn;
    public Button InventoryBtn;
    public Button DictionaryBtn;
    public Button BackBtn;
    public Button CastingBtn;
    public GameObject OnOff;
    public GameObject MenuSet;
    public GameObject EquipSet;
    public GameObject TimerSet;
    public GameObject UserStatusSet;
    public GameObject LiveStatusSet;
    public GameObject CastingText;

    bool mClicked;

    void Start()
    {
        mClicked = false;
        if(SceneManager.GetActiveScene().name == "FirstScene")
        {
            GameBtn.onClick.AddListener( delegate { GameBtnClicked(); });
        }
        else if(SceneManager.GetActiveScene().name == "GameScene")
        {
            MenuBtn.onClick.AddListener(delegate { MenuBtnClicked(); });
            ShopBtn.onClick.AddListener(delegate { ShopBtnClicked(); });
            InventoryBtn.onClick.AddListener(delegate { InventoryBtnClicked(); });
            DictionaryBtn.onClick.AddListener(delegate { DictionaryBtnClicked(); });
            CastingBtn.onClick.AddListener(delegate { CastBtnClicked(); });
        }
        else if(SceneManager.GetActiveScene().name == "Inventory")
        {
            BackBtn.onClick.AddListener(delegate { BackBtnClicked(); });
        }
        else if (SceneManager.GetActiveScene().name == "ShopScene")
        {
            BackBtn.onClick.AddListener(delegate { BackBtnClicked(); });
        }
        else if (SceneManager.GetActiveScene().name == "CollectionScene")
        {
            BackBtn.onClick.AddListener(delegate { BackBtnClicked(); });
        }
    }

    void GameBtnClicked()
    {
        SceneManager.LoadScene("GameScene");
    }
    void MenuBtnClicked()
    {
        mClicked = !mClicked;
        OnOff.SetActive(mClicked);
    }
    void ShopBtnClicked()
    {
        SceneManager.LoadScene("ShopScene");
    }
    void InventoryBtnClicked()
    {
        SceneManager.LoadScene("Inventory");
    }
    private void DictionaryBtnClicked()
    {
        SceneManager.LoadScene("CollectionScene");
    }
    void BackBtnClicked()
    {
        SceneManager.LoadScene("GameScene");
    }
    void CastBtnClicked()
    {
        WaittoGame(true);
    }

    public void WaittoGame(bool boolean)
    {
        CastingBtn.gameObject.SetActive(!boolean);
        MenuSet.SetActive(!boolean);
        EquipSet.SetActive(!boolean);
        TimerSet.SetActive(boolean);
        UserStatusSet.SetActive(boolean);
        CastingBtn.gameObject.SetActive(!boolean);
        CastingText.gameObject.SetActive(boolean);
    }
}