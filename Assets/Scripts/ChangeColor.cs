using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Renderer ren;




    public void ChangingColor(int idBtn)
    {
        ren = GetComponent<Renderer>();

        if (idBtn == 1)
        {
            ren.material.color = Color.red;
        }
        else if (idBtn == 2)
        {
            ren.material.color = Color.blue;
        }
        else if (idBtn == 3)
        {
            ren.material.color = Color.green;
        }
        else if (idBtn == 4)
        {
            ren.material.color = Color.yellow;
        }
        else if (idBtn == 5)
        {
            ren.material.color = Color.grey;
        }
    }
}
