using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainController : MonoBehaviour
{
    public GameObject playWithFriendDlg;
    public GameObject WelcomeDialog;
    public GameObject ProfilePage;
    // Start is called before the first frame update
    void Start()
    {
        WelcomeDialog.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Premium_btnClicked() {
        SceneManager.LoadScene("Game");
    }

    public void Learning_btnClicked() {
        SceneManager.LoadScene("Game");
    }

    public void Training_btnClicked() {
        SceneManager.LoadScene("Game");
    }

    public void Stock_btnClicked() {
        SceneManager.LoadScene("Game");
    }

    public void Crypto_btnClicked() {
        SceneManager.LoadScene("Game");
    }

    public void Forex_btnClicked() {
        SceneManager.LoadScene("Game");
    }

    public void PlayWithFriendBtnClicked()
    {
        playWithFriendDlg.SetActive(true);
    }

    public void ProfileBtnClicked()
    {
        WelcomeDialog.SetActive(false);
        ProfilePage.SetActive(true);
    }
}
