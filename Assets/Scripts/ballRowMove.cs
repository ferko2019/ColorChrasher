using UnityEngine;
using System.Collections;

public class ballRowMove : MonoBehaviour
{
    private float speed = 10.0f;

    private void Update()
    {
        float currentSpeed = speed * (Time.time / 100);
        Debug.Log(currentSpeed);
        if (currentSpeed < 6.0f)
            currentSpeed = 6.0f;

        Debug.Log(currentSpeed);

        transform.Translate(0, 0, currentSpeed * Time.deltaTime * -1);
        if (transform.position.z <= -10)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<hitCheck>().Balls.Remove(gameObject);
            Destroy(gameObject);
        }
    }
}
