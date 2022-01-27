using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class location_coin : MonoBehaviour
{

    /* rotation parameters*/
    public float num_rotation_x = 0.5f;
    public float num_rotation_z = 0.5f; 
    public float rotation_randomness = 0.2f; 
    public bool rotation_random = false;

    /* force parameters*/
    public float flip_target_height = 2f;
    public float force_randomness = 0.2f;
    public bool force_random = true;

    /* rigid body */
    Rigidbody rb;

    Vector3 flip_direction = new Vector3(0f, 1.0f, 0f);

    /* flip variables */
    float initial_height;
    float flip_start_time;
    float flip_time;
    Vector3 flip_rotation = new Vector3(0.0f,0.0f,0.0f);

    float random_rotation_z;
    float random_rotation_x;

    /* state variables */
    bool clickable = true;
    bool being_flipped = false;

    enum orientation
    {
        head = 0,
        tails,
        wat
    }

    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {
        if (being_flipped == true)
        {
            if ((Time.time - flip_start_time < flip_time))
            {
                /* calcule la rotation */
                float rotation_amount_z = 360 * (random_rotation_z+num_rotation_z) * Time.deltaTime / flip_time;
                float rotation_amount_x = 360 * (random_rotation_x+num_rotation_x) * Time.deltaTime / flip_time;
                transform.Rotate(rotation_amount_x, 0.0f, rotation_amount_z);
            }
            else
            {
                being_flipped = false;
                clickable = true;
            }
        }
        if(Vector3.Distance(this.transform.position,this.transform.parent.transform.position)>20)
        {
            this.transform.position = new Vector3(0, 0, 0);
        }
     ISFace = CheckIfFace();
    }
    private void OnMouseDown()
    {
        //flip();
    }

    public void flip()
    {
        if (isClickable() == true)
        {
            float random_force = 0;
            if (force_random == true)
            {
                random_force = Random.Range(-force_randomness, force_randomness);
            }
            /* calcule les paramètres du flip*/
            float initial_velocity = Mathf.Sqrt(2 * (flip_target_height + random_force) * Physics.gravity.magnitude);
            
            Vector3 flip_force = flip_direction*rb.mass * initial_velocity ;

            random_rotation_z = Random.Range(-rotation_randomness, rotation_randomness);
            random_rotation_x = Random.Range(-rotation_randomness, rotation_randomness);

            //flip_rotation = new Vector3(rotation_amount_x + random_rotation_x, 0.0f, rotation_amount_z + random_rotation_z);

            flip_time = (2 * initial_velocity) / Physics.gravity.magnitude;
            flip_time = 2f;
            flip_start_time = Time.time;
            clickable = false;
            initial_height = transform.position.y;
            rb.AddForce(flip_force, ForceMode.Impulse);
            being_flipped = true;
        }
    }

    bool isClickable()
    {
        return clickable; 
    }

    orientation getOrientation()
    {
        if (transform.rotation.z < 181 && transform.rotation.z > 179)
        {
            return orientation.head; 
        } else if (transform.rotation.z < 1 && transform.rotation.z > -1)
        {
            return orientation.tails;
        } else
        {
            return orientation.wat;
        }
    }
    public bool ISFace;
    public bool CheckIfFace()//90 to -90 
    {
        //print(transform.rotation.z);
        if (transform.rotation.z > -0.50 && transform.rotation.z < 0.5)
        {
            return true;
        }//-90 to -270
        else if (transform.rotation.z < -0.5 && transform.rotation.z > 0.5)
        {
            return false;
        }
        else
        {
            return false;
        }
    }
}
