using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommitSudoku : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine(Sudoku());
    }

    IEnumerator Sudoku()
    {
        yield return new WaitForSeconds(0.38f);
        Destroy(gameObject);
    }
}
