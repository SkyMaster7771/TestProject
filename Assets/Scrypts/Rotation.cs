using UnityEngine;

public class Rotation : MonoBehaviour
{
	void Start()
	{
		Debug.Log("start test");
	}

	void Update()
	{
		var ea = transform.eulerAngles;
		ea.y += 30 * Time.deltaTime;
		transform.eulerAngles = ea;
	}
}
