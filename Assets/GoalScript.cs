using UnityEngine;
using System.Collections;
public class GoalScript : MonoBehaviour
{
    private bool solved = false;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            solved = true;
            other.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
    public bool IsSolved()
    {
        return solved;
    }
}
