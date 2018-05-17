using System;
using UnityEngine;
public class Clock : MonoBehaviour{

	public Transform hoursTransform, minutesTransform, secondsTransform;

	void Awake () {
		Debug.Log (DateTime.Now);
	
	}

}

