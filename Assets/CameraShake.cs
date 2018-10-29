using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
	public float amplitude;
	public Vector2 frequency;
	Vector2 time = Vector2.zero;

	void Update()
	{
		time.x = Mathf.Repeat(time.x + Time.deltaTime * frequency.x, 1.0f);
		time.y = Mathf.Repeat(time.y + Time.deltaTime * frequency.y, 1.0f);
		Vector2 shake = new Vector3(
			Mathf.PerlinNoise(time.x, 0.0f) - 0.5f,
			Mathf.PerlinNoise(0.0f, time.y) - 0.5f,
			0.0f) * amplitude;
		transform.localPosition = shake;
	}
}
