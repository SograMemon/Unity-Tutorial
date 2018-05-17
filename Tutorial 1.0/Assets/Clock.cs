using System;
using UnityEngine;
public class Clock : MonoBehaviour{

	const float degreePerHour = 30f;

	public Transform hoursTransform, minutesTransform, secondsTransform;

	void Awake () {
		hoursTransform.localRotation=
		Quaternion.Euler(0f, DateTime.Now.Hour * degreePerHour, 0f);


	
	}

}

