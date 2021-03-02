using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    Transform player;

    public float smoothX;
    public float SmoothY;

    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    private void LateUpdate()
    {
        float posX = Mathf.MoveTowards(transform.position.x, player.position.x, smoothX);
        float posY = Mathf.MoveTowards(transform.position.y, player.position.y, SmoothY);

        transform.position = new Vector3(Mathf.Clamp(posX, minX, maxX), Mathf.Clamp(posY, minY, maxY), transform.position.z);
    }
}
