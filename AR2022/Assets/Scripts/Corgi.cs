using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corgi : MonoBehaviour
{
    private void Update()
    {
        SetPuppy();
    }

    public void SetPuppy()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<Animator>().SetTrigger("Jump");
        }
    }
}
