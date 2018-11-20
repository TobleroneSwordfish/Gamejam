using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Door : MonoBehaviour {
    public float openTime = 2;
    public Door nextDoor;
    public bool open = false;
    protected virtual void OpenDoor()
    {
        if (nextDoor != null)
        {
            nextDoor.enabled = true;
        }
        open = true;
        //gameObject.SetActive(false);
        StartCoroutine(Move());
    }
    public abstract void OnMouseDown();
    private IEnumerator Move()
    {
        float height = GetComponent<Renderer>().bounds.size.y * 2;
        float currentHeight = 0;
        while (currentHeight < height)
        {
            float distance = (Time.deltaTime * height) / openTime;
            currentHeight += distance;
            transform.position += new Vector3(0, distance, 0);
            yield return null;
        }
        yield break;
    }
}
