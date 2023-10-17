using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenPhoto : MonoBehaviour
{
    public RawImage rw;
    public GameObject Photo;


    public void Startting()
    {
        StartCoroutine(ScreenS());
    }

    public void DeletePhoto()
    {
        Destroy(Photo);
    }

    IEnumerator ScreenS()
    {
        yield return new WaitForEndOfFrame();
        var Screen = ScreenCapture.CaptureScreenshotAsTexture();
        Progress.Instance.PlayerInfo.PhotosInfo.Add(Screen);
        rw.texture = Screen;
    }
}