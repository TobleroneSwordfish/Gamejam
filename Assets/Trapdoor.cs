using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapdoor : MonoBehaviour
{
    public Door A, B;
    public GameObject flap1, flap2;
    public float openingTime = 2;
    // Update is called once per frame
    private void Update()
    {
        //print("Trigger netere");
        if (//collider.gameObject.GetComponent<CharacterController>() != null
            A.open
            && B.open)
        {
            print("opening trapdoor");
            StartCoroutine(help());
        }
    }
    private IEnumerator help()
    {
        while ((flap1.transform.position - flap2.transform.position).magnitude < 30)
        {
            float distance = (Time.deltaTime * 2) / openingTime;
            flap1.transform.position += new Vector3(0, distance, 0);
            flap2.transform.position += new Vector3(0, -distance, 0);
            yield return null;
        }
    }
    //to have lives you need a concept of death - max whale
}

