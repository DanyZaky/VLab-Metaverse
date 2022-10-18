using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerVLab : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel, buttonBackpanel, creditsPanel;

    private void Start()
    {
        menuPanel.SetActive(true);
        buttonBackpanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void OnClickPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void OnClickCredits()
    {
        menuPanel.SetActive(false);
        buttonBackpanel.SetActive(true);
        creditsPanel.SetActive(true);
    }

    public void OnClickBackCredtis()
    {
        menuPanel.SetActive(true);
        buttonBackpanel.SetActive(false);
        creditsPanel.SetActive(false);
    }
}
