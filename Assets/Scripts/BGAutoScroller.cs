using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGAutoScroller : MonoBehaviour
{
    private MeshRenderer _mesh;

    public float scrollSpeed = 0.75f;

    private void Awake()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * scrollSpeed);
        _mesh.material.mainTextureOffset = offset;
    }
}
