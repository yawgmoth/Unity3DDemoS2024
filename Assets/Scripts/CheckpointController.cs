using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public CheckpointController next;
    public MeshRenderer left;
    public MeshRenderer right;
    public bool start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        CarController plr = other.gameObject.GetComponent<CarController>();
        if (plr != null)
        {
            if (plr.target == this)
            {
                plr.target = next;
                next.Recolor(Color.red);
                Recolor(Color.white);
                Debug.Log("Reached checkpoint");
                if (start)
                {
                    plr.starttime = Time.time;
                }
            }
        }
    }

    public void Recolor(Color c)
    {
        left.materials[0].color = c;
        right.materials[0].color = c;
    }
}
