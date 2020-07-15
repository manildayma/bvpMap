using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pageChanger : MonoBehaviour
{
   public GameObject creditPanel, infoPanel;
   public void BackToHome() { SceneManager.LoadScene("home"); }
   public void ExitApp() { Application.Quit(); }
   public void MainMap(){ SceneManager.LoadScene("mainMap"); }
   public void infoON() { infoPanel.SetActive(true); }
   public void creditON() { creditPanel.SetActive(true); }  
   public void PanelOFF() { infoPanel.SetActive(false); creditPanel.SetActive(false); }

}