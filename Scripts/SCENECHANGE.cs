using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SCENECHANGE : MonoBehaviour
{
   public void firstpagetologinpage()
    {
        SceneManager.LoadScene("Loginpage1");
    }
    public void loginpagetohomepage()
    {
        SceneManager.LoadScene("homepage");
    }
    public void homepagetoselection()
    {
        SceneManager.LoadScene("selection");
    }
    public void selectiontosingleplayer()
    {
        SceneManager.LoadScene("singleplayer");
    }
    public void selectiontomultiplayer()
    {
        SceneManager.LoadScene("multiplayer");
    }
    public void singleplayertoselection()
    {
        SceneManager.LoadScene("selection");
    }
    public void multiplayertoselection()
    {
        SceneManager.LoadScene("selection");
    }
    public void singletovr()
    {
        SceneManager.LoadScene("vrheadset1");
    }
    public void multitovr()
    {
        SceneManager.LoadScene("vrheadset2");
    }
    public void loadvrwarningtomulti()
    {
        SceneManager.LoadScene("multiplayer");
    }
    public void loadvrwarningtosingle()
    {
        SceneManager.LoadScene("singleplayer");
    }
    public void singletoovr()
    {
        SceneManager.LoadScene("New Scene 1");
    }
    
}


