using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;

    public float speed = 200f;
    public float NextPointWayDistance = 3f;

    public Transform Enemygfx;

    Path path;
    private int Currentwaypoint = 0;
    private bool ReachedEndOfPath = false;

    Seeker seeker;
    Rigidbody2D rb;
     
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        
        InvokeRepeating("UpdatePath", 0f, .5f );
       
    }

    void UpdatePath()
    {
        if (seeker.IsDone())
            seeker.StartPath(rb.position, target.position, OnPathComplete);
    }
    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            Currentwaypoint = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (path == null)
            return;
        if (Currentwaypoint >= path.vectorPath.Count)
        {
            ReachedEndOfPath = true;
            return;
        }else
        {
            ReachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2) path.vectorPath[Currentwaypoint] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;

        rb.AddForce(force);
        
        float distance = Vector2.Distance(rb.position, path.vectorPath[Currentwaypoint]);

        if (distance < NextPointWayDistance)
        {
            Currentwaypoint++;
            
        }
        if (force.x >= 0.01f)
        {
            Enemygfx.localScale = new Vector3(-1f, 1f, 1f);
            
        }
        else if (force.x <= -0.01f)
        {
            Enemygfx.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
