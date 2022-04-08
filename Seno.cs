using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seno : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private int instanciasTotales = 50;
    [SerializeField]
    [Range(0,10)] private float factorSeparacion = 0.2f;
    [Range(1f, 10f)] public float amplitud = 1f;
    void Start()
    {
        for (int i = 0; i < instanciasTotales; i++) Instantiate(prefab, transform);
    }

    void Update()
    {
        int i = 0;
        foreach(Transform child in transform)
        {
            float x = i * factorSeparacion;
            float y = amplitud * Mathf.Sin(x + Time.time);
            child.transform.localPosition = new Vector3(x,y);
            ++i;
        }
    }
}
