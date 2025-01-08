using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float Speed = 5f;  
    public float Range = 20f; 

    private void Update()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        if (Vector3.Distance(this.transform.parent.position, this.transform.position) > Range)
        {
            this.transform.parent.GetComponent<PlayerController>().Push(this.gameObject);
        }
    }
}