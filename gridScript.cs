using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridScript : MonoBehaviour
{
    // Shader parameters
    [Range(-180, 180)]
    public float ScriptHue = 0;
    [Range(0, 1)]
    public float ScriptSmoothness = 1/2;
    [Range(0, 1)]
    public float ScriptMetallic = 0;

    public GameObject[] objectList;
    public Material[] materialList;


    // Start is called before the first frame update
    void Start()
    {
        // Load materials
        objectList = Resources.LoadAll<GameObject>("models");
        materialList = Resources.LoadAll<Material>("materials");

        for (int i = 0; i < objectList.Length; i++)
        {
            objectList[i].GetComponentInChildren<Renderer>().material = materialList[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Update shader inputs
        for (int i = 0; i < objectList.Length; i++)
        {
            objectList[i].GetComponentInChildren<Renderer>().sharedMaterial.SetFloat("_HueOffset", ScriptHue);
            objectList[i].GetComponentInChildren<Renderer>().sharedMaterial.SetFloat("_Smoothness", ScriptSmoothness);
            objectList[i].GetComponentInChildren<Renderer>().sharedMaterial.SetFloat("_Metallic", ScriptMetallic);
        }
    }







}
