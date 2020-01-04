using UnityEngine;

public class FlyDragon : MonoBehaviour
{
    private Transform tra;
    private Transform target_Tra;
    private Transform faceOnTarget_Tra;

    [Header("移動速度"), Range(0, 10)]
    public float speed = 1.5f;
    //[Header("旋轉速度"), Range(0, 1000)]
    //public float turn = 1.5f;

    private Rigidbody rig;


    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        tra = GetComponent<Transform>();
        target_Tra = GameObject.Find("target").GetComponent<Transform>();
        faceOnTarget_Tra = GameObject.Find("faceOnTarget").GetComponent<Transform>();
        
    }

    private void Update()
    {
        Track();
    }

    /// <summary>
    /// 寵物追蹤玩家功能
    /// </summary>
    private void Track()
    {
        Vector3 postarget = target_Tra.position;
        Vector3 posD = tra.position;


        tra.position = Vector3.Lerp(posD, postarget, speed * 0.3f * Time.deltaTime);
        tra.LookAt(faceOnTarget_Tra);
    } 


}
