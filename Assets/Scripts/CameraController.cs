using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // �ѵ�ط����ͧ�еԴ���

    // Update is called once per frame
    void Update()
    {
        // ���˹觢ͧ���ͧ������˹觢ͧ target
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
    }
}
