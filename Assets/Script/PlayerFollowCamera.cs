using System.Drawing;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerFollowCamera : MonoBehaviour
{
    public  Vector3 offset = new Vector3(0, 3, -3.5f);
    public Transform targetTransform;
    float smoothTime = 0.2f;

    Vector3 velocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (targetTransform == null)
        {
            //Debug.LogError
            Debug.LogWarning("<color=red>taret이 지정되지 않았습니다</color>");
        }

        else
        {
            Debug.Log($"<color=yellow><b>{targetTransform}</b></color>이 연결되었습니다.");
        }

        transform.position = targetTransform.transform.position + offset;
        Vector3 lookAtPos = targetTransform.transform.position;
        lookAtPos.y += 2;

        transform.LookAt(lookAtPos);


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dest = targetTransform.transform.position + offset;
        // 뒤늦게 따라가는 효과. dest가 카메라의 위치
        transform.position = Vector3.SmoothDamp(transform.position, dest, ref velocity, smoothTime);
    }
}
