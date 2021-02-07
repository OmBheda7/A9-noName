using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePointer : MonoBehaviour
{
    public float m_DefaultLength = 5.0f;
    public GameObject m_Dot;
    public VRInput m_InputModule;

    private LineRenderer m_LineRenderer = null;

    //
    private void Awake()
    {
        m_LineRenderer = GetComponent<LineRenderer>();
    }

    //
    private void Update()
    {
        UpdateLine();
    }
    private void UpdateLine()
    {
        //1. def length or distance received from ip module
        float targetLength = m_DefaultLength;

        //2. send/ create raaycast
        RaycastHit hit = CreateRaycast(targetLength);

        //3. Default end of ray
        //Vector3 endPosition = transform.postion + (transform.forward * targetLength);

        //4. or based on the hit.
        //if (hit.collider != null)
          //  endPosition = hit.point;

        //5. Set the position of sphere based on hit
        //m_Dot.transform.position = endPosition;

        //6. Set the position of line renderer
        //m_LineRenderer.SetPosition(0, transform.position);
        //m_LineRenderer.SetPosition(1, endPosition);
    }

    //returning the raycast hit indicating click or button press
    private RaycastHit CreateRaycast(float length)
    {
        RaycastHit hit;

        //Ray ray = new Ray(transform.position, transform.forward);
        Ray ray = new Ray();

        Physics.Raycast(ray, out hit, m_DefaultLength);

        return hit;
    }
}
