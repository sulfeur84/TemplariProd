
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraMultiplePlayers : MonoBehaviour
{
    public List<Transform> targets ;
    private Vector3 velocity;
    public float smoothTime = .5f;
    public Vector3 offset;
    public float minZoom = 40f;
    public float maxZoom = 10f;
    public float zoomLimiter = 50f;
    private Camera cam;

    private bool A, B, C, D;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    float GetGreatestDistance()
    {
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.size.x;
    }

    private void LateUpdate()
    {
        if (targets.Count == 0) return;
        Checker();
        Move();
        Zoom();
    }

    public void Update()
    {
        if (!A && GameObject.FindWithTag("Player1"))
        {
            targets.Add(GameObject.FindWithTag("Player1").transform);
            A = true;
        }
        if (!B && GameObject.FindWithTag("Player2"))
        {
            B = true;
            targets.Add(GameObject.FindWithTag("Player2").transform);
        }
        if (!C&& GameObject.FindWithTag("Player3"))
        {
            C = true;
            targets.Add(GameObject.FindWithTag("Player3").transform);
        }
        if (!D&& GameObject.FindWithTag("Player4"))
        {
            D = true;
            targets.Add(GameObject.FindWithTag("Player4").transform);
        }

    }

    void Checker()
    {
        for (int i = 0; i < targets.Count; i++)
        {
            if (targets[i] == null)
            {
                targets.Remove(targets[i]);
            }
            if (targets[i].gameObject.activeSelf == false)
            {
                targets.Remove(targets[i]);
            }
        }
    }

    void Move()
    {
        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
    }

    void Zoom()
    {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance() / zoomLimiter);
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom , Time.deltaTime);
    }

    Vector3 GetCenterPoint()
    {
        if (targets.Count == 1)
        {
            return targets[0].position;
        }

        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.center;
    }
}
