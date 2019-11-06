using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class hitCheck : MonoBehaviour
{
    public Text scoreText;
    public Text timeText;
    public List<GameObject> Balls;
    public float checkDistance = 0.5f;
    private int score = 0;

    private void Update()
    {
        foreach (GameObject obj in Balls)
        {
            if(Vector3.Distance(obj.transform.position,transform.position) <= checkDistance)
            {
				if (obj.GetComponent<Renderer>().material.color != GetComponent<Renderer>().material.color)
					SceneManager.LoadScene(2);
				else if (!obj.GetComponentInParent<randomMatGen>().rowChecked)
				{
					score++;
					obj.GetComponentInParent<randomMatGen>().rowChecked = true;
					Balls.Remove(obj);
					Destroy(obj);
				}
            }
        }
        scoreText.text = score.ToString();
        timeText.text =  Mathf.Round(Time.time).ToString();
    }
}
