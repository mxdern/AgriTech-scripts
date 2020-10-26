using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gradientScript : MonoBehaviour
{
    public float Color1, Color2;
    public float Speed = 1, Offset;

    private Renderer _renderer;
    private MaterialPropertyBlock _propBlock;

    void Awake()
    {
        _propBlock = new MaterialPropertyBlock();
        _renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Get the current value of the material properties in the renderer.
        _renderer.GetPropertyBlock(_propBlock);
        // Assign the new value.
        Debug.Log(Mathf.Lerp(Color1, Color2, Speed));
        _propBlock.SetFloat("_Color", (Mathf.Lerp(Color1, Color2, Speed))); 
        // Apply the edited values to the renderer.
        _renderer.SetPropertyBlock(_propBlock);
    }
}
