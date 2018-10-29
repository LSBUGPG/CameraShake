using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeEffect : MonoBehaviour
{
	public CameraShake shake;
	public AnimationCurve amplitudeCurve;
	public float amplitudeMultiplier = 1.0f;
	public Vector2 frequency = Vector2.zero;
	float time = 0.0f;

	public float Duration(AnimationCurve curve)
	{
		return curve.keys[curve.length - 1].time;
	}

	public float Length()
	{
		return Duration(amplitudeCurve);
	}

	void OnEnable()
	{
		time = 0.0f;
	}

	void Update()
	{
		time += Time.deltaTime;
		if (time < Length())
		{
			shake.amplitude = amplitudeCurve.Evaluate(time) * amplitudeMultiplier;
			shake.frequency = frequency;
		}
		else
		{
			shake.amplitude = 0.0f;
			enabled = false;
		}
	}
}
