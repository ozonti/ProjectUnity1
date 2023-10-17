using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();

    /*void Start()
    {
        ShowAdv();
    }*/

    public void LoadScene(int idScene)
    {
        //Progress.instance.Save();
        SceneManager.LoadScene(idScene);
    }
}
