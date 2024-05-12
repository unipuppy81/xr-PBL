using System;
using System.Collections;
using UnityEngine;
using UnityEditor;
using System.Collections.Specialized;

public class Enemy : MonoBehaviour
{
    public static bool isEnemy;

    [SerializeField] bool DebugMode = false;
    [Range(0f, 360f)][SerializeField] float ViewAngle = 0f;
    [SerializeField] float ViewRadius = 1f;
    [SerializeField] LayerMask layerMask;

    public float searchRadius;
    public float enmeySpeed;

    private bool pos1;
    private bool pos2;
    private bool pos3;
    private bool pos4;

    public GameObject Player;

    public Vector3 transform1, transform2, transform3, transform4, tmpTransform;


    void Start()
    {
        //InvokeRepeating("FindPlayer", 0f, 0.1f);

        isEnemy = true;

        transform1 = new Vector3(-48.0f, 20.0f, -48.0f);
        transform2 = new Vector3(48.0f, 20.0f, -48.0f);
        transform3 = new Vector3(48.0f, 20.0f, -2.0f);
        transform4 = new Vector3(-48.0f, 20.0f, -2.0f);

        pos1 = true;
        pos2 = false;
        pos3 = false;
        pos4 = false;

        enmeySpeed = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnemy) { 
            FindPlayer();
            move();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        //Gizmos.DrawRay(transform.position, tmpTransform * ViewRadius);
        Gizmos.DrawSphere(transform.position, searchRadius);
    }

    

    private void FindPlayer()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, searchRadius, layerMask);

        foreach(Collider col in colls)
        {
            if (col.name == "Enemy") continue;

            UnityEngine.Debug.Log("플레이어 감지");
        }
    }

    void move()
    {
        if (pos1) { move1(); }
        if (pos2) { move2(); }
        if (pos3) { move3(); }
        if (pos4) { move4(); }
    }
    
    void move1()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform2, enmeySpeed);
        tmpTransform = transform2 - transform1;
        tmpTransform = tmpTransform.normalized;
        transform.rotation = Quaternion.Euler(new Vector3(0,90,0)); 
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform2), Time.deltaTime * 3.0f);
        if (transform.position == transform2)
        {
            UnityEngine.Debug.Log("1");
            pos1 = false;
            pos2 = true;
            pos3 = false;
            pos4 = false;
        }
    }

    void move2()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform3, enmeySpeed);
        tmpTransform = transform3 - transform2;
        tmpTransform = tmpTransform.normalized;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform3), Time.deltaTime * 3.0f);
        if (transform.position == transform3)
        {
            UnityEngine.Debug.Log("2");
            pos1 = false;
            pos2 = false;
            pos3 = true;
            pos4 = false;
        }
    }

    void move3()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform4, enmeySpeed);
        tmpTransform = transform4 - transform3;
        tmpTransform = tmpTransform.normalized;
        transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform4), Time.deltaTime * 3.0f);
        if (transform.position == transform4)
        {
            UnityEngine.Debug.Log("3");
            pos1 = false;
            pos2 = false;
            pos3 = false;
            pos4 = true;
        }
    }

    void move4()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform1, enmeySpeed);
        tmpTransform = transform1 - transform4;
        tmpTransform = tmpTransform.normalized;
        transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(transform1), Time.deltaTime * 3.0f);
        if (transform.position == transform1)
        {
            UnityEngine.Debug.Log("4");
            pos1 = true;
            pos2 = false;
            pos3 = false;
            pos4 = false;
        }
    }
}
