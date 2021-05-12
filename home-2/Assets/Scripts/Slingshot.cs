using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    public GameObject launchPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        Transform lanchPointTrans = transform.Find("LaunchPoint");
        launchPoint = lanchPointTrans.gameObject;
        launchPoint.SetActive(false);
    }
    void OnMouseEnter()
    {
        print("Slingshot:OnMouseEnter()");
        launchPoint.SetActive(true);
    }

    private void OnMouseExit()
    {
        print("Slingshot:OnMouseExit()");
        launchPoint.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
    }
}
