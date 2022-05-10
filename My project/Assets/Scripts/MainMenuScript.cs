using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    static int ct = 0;
    //panou de intrucțiuni
    public GameObject panelInstruct;

    public void Start()
    {
        //dezactivarea panoului de instrucțiuni de la început
        panelInstruct.SetActive(false);
    }

    public void LanseazaScenaDinButon (int indexScena)
    {
        if (ct == 0 && indexScena == 1)
        {
            SceneManager.LoadScene(indexScena);
            ct++;
        }
        else
        {
            SceneManager.LoadScene(indexScena);
            SceneManager.LoadScene(indexScena);
        }
       
    }

    //funcție atașată butonului X din panelul de instrucțiuni

    public void Back()
    {
        panelInstruct.SetActive(false);
    }

    //funcție activată atunci când se apasă butonul Instrucțiuni din mediul principal; panelul se va face vizibil pe ecran

    public void LoadPanelInstruct()
    {
        panelInstruct.SetActive(true);
    }

    //funcție de sfârșit de joc

    public void ExitApp()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
       // Debug.Log("Game is exiting");
    }
}
