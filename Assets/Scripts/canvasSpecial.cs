using UnityEngine;
using UnityEngine.UI;

public class canvasSpecial : MonoBehaviour
{
	public Button yourButton;
	public float maxSize = 1.5f;
	public float minSize = 1f;
	public float speed = 1f;

	void Update()
	{
		float newSize = Mathf.Lerp(minSize, maxSize, Mathf.PingPong(Time.time * speed, 1f));
		yourButton.transform.localScale = new Vector3(newSize, newSize, 1f);
	}
}