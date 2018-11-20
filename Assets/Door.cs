using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Reflections;
public abstract class Door : MonoBehaviour, Target {
    public float openTime = 2;
    public Door nextDoor;
    public bool open = false;
    public bool sideways = false;
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
    public virtual void Start()
    {
        foreach(Transform child in transform)
        {
            Reflector reflector = child.gameObject.AddComponent<Reflector>();
            reflector.parent = this;
        }
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
            if (sideways) transform.position += new Vector3(distance * 10, 0, 0);
            else transform.position += new Vector3(0, distance, 0);
            yield return null;
        }
        yield break;
    }
}
