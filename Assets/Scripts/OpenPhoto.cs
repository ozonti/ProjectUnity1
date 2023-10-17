using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenPhoto : MonoBehaviour
{
    public GameObject rwPrefab;
    public GameObject LeftBtn;
    public GameObject RightBtn;


    void Start()
    {
        int idx = Progress.Instance.PlayerInfo.index;
        rwPrefab.GetComponent<RawImage>().texture = Progress.Instance.PlayerInfo.PhotosInfo[idx];
    }

    void Update()
    {
        if (Progress.Instance.PlayerInfo.index == Progress.Instance.PlayerInfo.PhotosInfo.Count - 1)
        {
            RightBtn.SetActive(false);
        }
        if (Progress.Instance.PlayerInfo.index == 0)
        {
            LeftBtn.SetActive(false);
        }

        if (Progress.Instance.PlayerInfo.index != Progress.Instance.PlayerInfo.PhotosInfo.Count - 1)
        {
            RightBtn.SetActive(true);
        }
        if (Progress.Instance.PlayerInfo.index != 0)
        {
            LeftBtn.SetActive(true);
        }
    }

    public void ChangeIdx(int to)
    {
        if (to == 0)
        {
            Progress.Instance.PlayerInfo.index -= 1;
            LoadImages();
        }
        else
        {
            Progress.Instance.PlayerInfo.index += 1;
            LoadImages();
        }
    }

    public void LoadImages()
    {
        int idx = Progress.Instance.PlayerInfo.index;
        rwPrefab.GetComponent<RawImage>().texture = Progress.Instance.PlayerInfo.PhotosInfo[idx];
    }
}