using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScore : MonoBehaviour
{
    public MeshRenderer gateRenderer;

    public Material redMaterial;
    public Material greenMaterial;
    public Material gateMaterial;


    private void Start()
    {
        EnableLights();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("something happened");
        GameManager.Instance.WentThroughGate();
        //GetComponent<BoxCollider>().enabled = false;
        gameObject.SetActive(false);
        DisableLights();
    }

    public void ChangeMaterial(Material foo)
    {
        Material[] mats = gateRenderer.materials;
        mats[0] = foo;
        mats[1] = foo;
        gateRenderer.materials = mats;
    }

    public void EnableLights()
    {
        ChangeMaterial(greenMaterial);
    }

    public void DisableLights()
    {
        ChangeMaterial(redMaterial);
    }
}
