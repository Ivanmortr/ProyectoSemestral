using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private string _id;

    public string ID => _id;

    public abstract void ChaseTarget();

}
