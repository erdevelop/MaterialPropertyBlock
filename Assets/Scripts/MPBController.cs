using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPBController : MonoBehaviour
{
    [SerializeField] private Color mainColor = Color.black;

    private Renderer _renderer = null;
    private MaterialPropertyBlock _materialPropertyBlock = null;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _materialPropertyBlock = new MaterialPropertyBlock();
    }
    private void Update()
    {
        _materialPropertyBlock.SetColor("_Color", mainColor);
        _renderer.SetPropertyBlock(_materialPropertyBlock);
    }
}
