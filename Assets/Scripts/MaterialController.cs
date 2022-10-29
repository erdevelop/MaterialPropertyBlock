using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    [SerializeField] private Color mainColor = Color.black;

    private void Update()
    {
        GetComponent<Renderer>().material.color = mainColor;
    }

}
