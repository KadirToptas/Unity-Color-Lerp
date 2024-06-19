using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Lerp : MonoBehaviour
{
    [SerializeField] private MeshRenderer mr;
    [SerializeField] private Color[] colors;
    [SerializeField] private float lerpTime;
    [SerializeField] private int index;
    [SerializeField] private float changer;
    void Start()
    {
        mr.GetComponent<MeshRenderer>();
    }

    
    void Update()
    {
        mr.material.color = Color.Lerp(mr.material.color, colors[index], lerpTime*Time.deltaTime);

        changer = Mathf.Lerp(changer, 1f,lerpTime*Time.deltaTime);

        if (changer >= 0.9f)
        {
            changer = 0f;
            index++;

            if (index >= colors.Length)
            {
                index = 0;
            }
        }   
    }
}
