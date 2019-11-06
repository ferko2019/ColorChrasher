using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class buttonScheneChange : MonoBehaviour
{
	public void changeScene(int index)
	{
		SceneManager.LoadScene(index);
	}
}
