using UnityEngine;
using System.Collections;

public class Circle : MonoBehaviour
{

    public GameObject Planet;
    public int Segments;

    private float radius;
    private LineRenderer line;

    void Start()
    {
        line = gameObject.GetComponent<LineRenderer>();
        radius = Planet.transform.position.x;

        line.positionCount = Segments + 1;
        line.useWorldSpace = false;
        CreatePoints();
    }


    void CreatePoints()
    {
        float x;
        float y;
        float z = 0f;

        float angle = 20f;

        for (int i = 0; i < (Segments + 1); i++)
        {
            x = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
            y = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;

            line.SetPosition(i, new Vector3(x, y, z));

            angle += (360f / Segments);
        }
    }
}
