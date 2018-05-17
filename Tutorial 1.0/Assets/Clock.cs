using System;
using UnityEngine;
public class Clock : MonoBehaviour{

	const float degreePerHour = 30f,
				degreePerMinute = 6f,
				degreePerSecond = 6f;

	public Transform hoursTransform, minutesTransform, secondsTransform;

	void Awake () {
		hoursTransform.localRotation=
		Quaternion.Euler(0f, DateTime.Now.Hour * degreePerHour, 0f);

		minutesTransform.localRotation=
			Quaternion.Euler(0f, DateTime.Now.Minute * degreePerMinute, 0f);

		secondsTransform.localRotation=
			Quaternion.Euler(0f, DateTime.Now.Second * degreePerSecond, 0f);


	
	}

}

