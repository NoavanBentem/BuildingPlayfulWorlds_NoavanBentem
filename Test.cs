using UnityEngine;
using UnityEditor;

public class ColourChanger : MonoBehaviour {

    public Color cubeColour = new Color();

    public Renderer cubeRenderer;

    void Start (){

        cubeRenderer.material.color = cubeColour;
    }

    void Update (){


    }

}