using UnityEngine;
using System.Collections;

public class playerMove : MonoBehaviour
{
    private float screenWidth;

    private void Start()
    {
        screenWidth = Screen.width;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) & transform.position.x >= -1)
            transform.Translate(-1, 0, 0);
        if (Input.GetKeyDown(KeyCode.D) & transform.position.x <= 1)
            transform.Translate(1, 0, 0);

        for (int i = 0; i < Input.touchCount; i++)
        {
            if(Input.GetTouch(i).position.x < screenWidth/2 & transform.position.x >= -1)
                transform.Translate(-1, 0, 0);
            if (Input.GetTouch(i).position.x > screenWidth / 2 & transform.position.x <= 1)
                transform.Translate(1, 0, 0);
        }
    }
}
