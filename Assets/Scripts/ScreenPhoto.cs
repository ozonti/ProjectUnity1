using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenPhoto : MonoBehaviour
{
    public void Startting()
    {
        StartCoroutine(ScreenS());
    }


    IEnumerator ScreenS()
    {
        yield return new WaitForEndOfFrame();
        var Screen = ScreenCapture.CaptureScreenshotAsTexture();
        Progress.Instance.PhotosInfo.Add(Screen);
    }
}