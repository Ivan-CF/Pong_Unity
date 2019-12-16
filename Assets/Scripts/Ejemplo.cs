using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejemplo : MonoBehaviour
{
    public int test = 0;

    private void Awake()
    {
        Debug.Log("me quiero morir "+test);
    }

    private void OnEnable()
    {
        Debug.LogError("yoquese" + test);
    }

    private void Update()
    {
        Debug.Log("update");
    }

    private void LateUpdate()
    {
        Debug.Log("lateupdate");
    }
}
