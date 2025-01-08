using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Bullet;
    private Queue<GameObject> ObjPool;

    void Start()
    {
        ObjPool = new Queue<GameObject>();
        for (int i = 0; i < 20; i++)
        {
            GameObject bullet = Instantiate(Bullet, this.transform.position, Quaternion.identity);
            bullet.transform.parent = this.transform;
            bullet.SetActive(false);
            ObjPool.Enqueue(bullet);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GameObject obj = Pop();
            obj.SetActive(true);
        }
    }

    public GameObject Pop()
    {
        return ObjPool.Dequeue();
    }

    public void Push(GameObject obj)
    {
        obj.SetActive(false);
        obj.transform.position = this.transform.position;
        ObjPool.Enqueue(obj);
    }
}
