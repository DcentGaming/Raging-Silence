using UnityEngine;

public class NoticeMeSenpai : MonoBehaviour
{

    public float viewRadius;
    public float FOV;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 DirFromAngle(float FOVAngle)
    {
        return new Vector3(Mathf.Sin(FOVAngle * Mathf.Deg2Rad), 0, Mathf.Cos(FOVAngle * Mathf.Deg2Rad));
    }
}
