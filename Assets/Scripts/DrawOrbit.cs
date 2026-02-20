using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawOrbit : MonoBehaviour
{
    public int segments = 100;
    public float radius = 5f;

    private LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = segments + 1;
        line.useWorldSpace = false;

        DrawOrbitExec();
    }

    void DrawOrbitExec()
    {
        float angle = 0f;

        for (int i = 0; i <= segments; i++)
        {
            float x = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;
            float z = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;

            line.SetPosition(i, new Vector3(x, 0, z));
            angle += 360f / segments;
        }
    }
}
