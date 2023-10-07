using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Image[] objectImage;
    public Color newColor;

    public void Change(int idBtn)
    {
        switch (idBtn)
        {
            case 1: //����� ffffff
                newColor = new Color32(0xff, 0xff, 0xff, 0xFF);
                foreach (Image image in objectImage)
                {
                    image.color = newColor;
                }
                break;
            case 2: //������ 30355�
                newColor = new Color32(0x30, 0x35, 0x5C, 0xFF);
                foreach (Image image in objectImage)
                {
                    image.color = newColor;
                }
                break;
            case 3: //���� ffe540
                newColor = new Color32(0xFF, 0xE5, 0x40, 0xFF);
                foreach (Image image in objectImage)
                {
                    image.color = newColor;
                }
                break;
            case 4: //����� ff4a1d
                newColor = new Color32(0xFF, 0x4A, 0x1D, 0xFF);
                foreach (Image image in objectImage)
                {
                    image.color = newColor;
                }
                break;
            case 5: //��� a47220
                newColor = new Color32(0xA4, 0x72, 0x20, 0xFF);
                foreach (Image image in objectImage)
                {
                    image.color = newColor;
                }
                break;
            case 6: //������� 00ff57
                newColor = new Color32(0x00, 0xFF, 0x57, 0xFF);
                foreach (Image image in objectImage)
                {
                    image.color = newColor;
                }
                break;
            case 7: //������� eb00ff
                newColor = new Color32(0x00, 0xD3, 0xFF, 0xFF);
                foreach (Image image in objectImage)
                {
                    image.color = newColor;
                }
                break;
            case 8: //����� 00d3ff
                newColor = new Color32(0xEB, 0x00, 0xFF, 0xFF);
                foreach (Image image in objectImage)
                {
                    image.color = newColor;
                }
                break;
        }
    }
}