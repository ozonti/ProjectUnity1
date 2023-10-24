using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;
using YG;

public class GameManager : MonoBehaviour
{
    public void LoadScene(int idScene)
    {
        if (idScene == 0)
        {
            YandexGame.FullscreenShow();
        }
        SceneManager.LoadScene(idScene);
        if (idScene == 5)
        {
            YandexGame.RewVideoShow(1);
        }
    }
}
