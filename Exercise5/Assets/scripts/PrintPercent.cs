using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPercent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		const int MaxScore = 100;
		int score = 50;
		float percent = (float)score / MaxScore * 100;

		print ("percent = " + percent + "%");
	}

}
