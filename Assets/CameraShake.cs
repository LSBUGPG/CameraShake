using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
	public Vector2 amplitude;
	public Vector2 frequency;
	Vector2 time = Vector2.zero;

	void Update()
	{
		time.x += Time.deltaTime * frequency.x;
		time.y += Time.deltaTime * frequency.y;
		Vector2 shake = new Vector3(Mathf.Sin(time.x), Mathf.Sin(time.y), 0.0f) * amplitude;
		transform.localPosition = shake;
	}
}
