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
        int idx = Progress.Instance.index;
        rwPrefab.GetComponent<RawImage>().texture = Progress.Instance.PhotosInfo[idx];
    }

    void Update()
    {
        if (Progress.Instance.index == Progress.Instance.PhotosInfo.Count - 1)
        {
            RightBtn.SetActive(false);
        }
        if (Progress.Instance.index == 0)
        {
            LeftBtn.SetActive(false);
        }

        if (Progress.Instance.index != Progress.Instance.PhotosInfo.Count - 1)
        {
            RightBtn.SetActive(true);
        }
        if (Progress.Instance.index != 0)
        {
            LeftBtn.SetActive(true);
        }
    }

    public void ChangeIdx(int to)
    {
        if (to == 0)
        {
            Progress.Instance.index -= 1;
            LoadImages();
        }
        else
        {
            Progress.Instance.index += 1;
            LoadImages();
        }
    }

    public void LoadImages()
    {
        int idx = Progress.Instance.index;
        rwPrefab.GetComponent<RawImage>().texture = Progress.Instance.PhotosInfo[idx];
    }
}