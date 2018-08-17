using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public float areaRedius;
    public float speed;
    public bool showNodeHandles = false;
    public Vector3[] nodePoints;
    public Quaternion[] nodePointsRotations;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, areaRedius);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * speed);
        Gizmos.color = Color.yellow;
        for (int i = 0; i < nodePoints.Length; i++)
        {
            switch (i % 4)
            {
                case 0:
                    Gizmos.color = Color.red;
                    break;
                case 1:
                    Gizmos.color = Color.yellow;
                    break;
                case 2:
                    Gizmos.color = Color.blue;
                    break;
                case 3:
                    Gizmos.color = Color.green;
                    break;
            }
            Gizmos.DrawSphere(nodePoints[i], 0.5f);
        }
        Gizmos.color = Color.white;
        for (int i = 0; i < nodePoints.Length; i++)
        {
            Gizmos.DrawLine(nodePoints[i], nodePoints[(int)Mathf.Repeat(i + 1, nodePoints.Length)]);
        }
        Gizmos.DrawIcon(transform.position, "home.png");

    }

    void OnDrawGizmosSelected()
    {

    }

}
