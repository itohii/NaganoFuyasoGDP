using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusinessManager : MonoBehaviour
{
    public GameObject[] BusinessTex;

    public float InstInterval;
    float IntervalReset;

    // Start is called before the first frame update
    void Start()
    {
        IntervalReset = InstInterval;
    }

    // Update is called once per frame
    void Update()
    {
        InstInterval -= 0.01f;

        if (InstInterval < 0)
        {
            int Rand = Random.Range(0, BusinessTex.Length);
            float PosX = Random.Range(-4.5f, 5.1f);
            float PosY = Random.Range(-10.1f, 10.2f);
            GameObject BusinessObj = Instantiate(BusinessTex[Rand], new Vector3(PosX, PosY,0), Quaternion.identity);
            Destroy(BusinessObj, 3.0f);
            InstInterval = IntervalReset;
        }
    }
}
