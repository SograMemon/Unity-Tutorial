using System;
using UnityEngine;
public class Clock : MonoBehaviour{

	const float degreePerHour = 30f,
				degreePerMinute = 6f,
				degreePerSecond = 6f;

	public Transform hoursTransform, minutesTransform, secondsTransform;

	public bool Continuous;

	void UpdateContinuous () {

		TimeSpan time = DateTime.Now.TimeOfDay;
		hoursTransform.localRotation=
			Quaternion.Euler(0f, (float)time.TotalHours * degreePerHour, 0f);

		minutesTransform.localRotation=
			Quaternion.Euler(0f, (float)time.TotalMinutes * degreePerMinute, 0f);

		secondsTransform.localRotation=
			Quaternion.Euler(0f, (float)time.TotalSeconds * degreePerSecond, 0f);


	
	}

	void UpdateDiscrete () {

		DateTime time = DateTime.Now;
		hoursTransform.localRotation=
			Quaternion.Euler(0f, time.Hour * degreePerHour, 0f);

		minutesTransform.localRotation=
			Quaternion.Euler(0f, time.Minute * degreePerMinute, 0f);

		secondsTransform.localRotation=
			Quaternion.Euler(0f, time.Second * degreePerSecond, 0f);



	}

	void Update() {
		if (Continuous) {
			UpdateContinuous ();
		}
		else{
			UpdateDiscrete ();
		}

}
}

