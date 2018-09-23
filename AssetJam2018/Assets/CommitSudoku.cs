using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommitSudoku : MonoBehaviour {

	void Start()
	{
		StartCoroutine(Waiter());
	}

	IEnumerator Waiter()
	{
		yield return new WaitForSeconds(0.38f);
		Destroy(gameObject);
	}
}
