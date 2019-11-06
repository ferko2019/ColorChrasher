using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMatGen : MonoBehaviour
{
    public bool rowChecked = false;
    public List<Color> colors = new List<Color>();

    private void Start()
    {
        if (transform.name == "player")
        {
            Color randColor = colors[Random.Range(0, colors.Count)];
            GetComponent<Renderer>().material.color = randColor;
        }
        else
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Color randColor = colors[Random.Range(0, colors.Count - 1)];
                transform.GetChild(i).GetComponent<Renderer>().material.color = randColor;
                colors.Remove(randColor);
            }
        }
    }
}
