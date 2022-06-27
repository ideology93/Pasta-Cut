using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Obi;
public class NoodleExtender : MonoBehaviour {

	public float speed = 0.01f;
	ObiRopeCursor cursor;
	ObiRope rope;

	void Start () {
		cursor = GetComponentInChildren<ObiRopeCursor>();
		rope = cursor.GetComponent<ObiRope>();
	}

	void FixedUpdate () {

			cursor.ChangeLength(rope.restLength *speed);
    }
}