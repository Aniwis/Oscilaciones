using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSen : MonoBehaviour
{
    [SerializeField] [Range(1, 5)] private float amp_x;
    [SerializeField] [Range(1, 5)] private float amp_y;
    [SerializeField] [Range(1, 5)] private float factor;

    private void Start()
    {
        amp_x = Random.Range(1, 5);
        amp_y = Random.Range(1, 5);
        factor = Random.Range(1, 5);
    }

    void Update()
    {
        float x = amp_x * Mathf.Sin(Time.time * factor);
        float y = amp_y * Mathf.Sin(Time.time * factor);
        transform.position = new Vector3(x, y, 0);
    }
}
