using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public CubeData[] cds;
    public Corgi corgi;

    private void Start()
    {
        corgi.SetPuppy();
    }
}
