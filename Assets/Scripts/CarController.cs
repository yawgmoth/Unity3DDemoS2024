using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    public int impulse;
    public CheckpointController target;
    public float starttime;
    public Text timelbl;
    // Start is called before the first frame update
    void Start()
    {
        target.Recolor(Color.red);
        starttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, impulse * Time.deltaTime));
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, -impulse * Time.deltaTime));
        }
        float dx = Input.mousePosition.x - Screen.width / 2;
        transform.Rotate(new Vector3(0, dx * Time.deltaTime, 0));
        timelbl.text = (Time.time - starttime).ToString() + " seconds";
    }
}
