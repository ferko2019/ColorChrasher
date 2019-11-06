using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapGenerator : MonoBehaviour
{
    public float generateSpeed = 5.0f;
    public GameObject ballRow;
    public Transform ballParent;
    public Vector3 startPos;

    private float nextGenerate = 0.0f;

    private void Update()
    {
        if(nextGenerate <= Time.time)
        {

            nextGenerate = 0;
			if(Time.time / 10 < 1)
			{
				nextGenerate = Time.time + generateSpeed;
			}
			else
			{
				nextGenerate = Time.time + generateSpeed * Time.time / 10;
			}
            GameObject go = Instantiate(ballRow, startPos, Quaternion.identity, ballParent);
            for (int i = 0; i < go.transform.childCount; i++)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<hitCheck>().Balls.Add(go.transform.GetChild(i).gameObject);
            }
        }
    }
}
