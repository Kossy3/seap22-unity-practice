using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    public float speed;
    public float height;
    private Vector3 initPosition;

    void Start()
    {
        initPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        pos.y += speed * Time.deltaTime;
        this.transform.position = pos;
        if (this.transform.position.y - initPosition.y > height)
        {
            Destroy(this.gameObject);
        }
    }
}
