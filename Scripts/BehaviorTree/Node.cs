using UnityEngine;

public abstract class Node : MonoBehaviour
{
    [SerializeField]
    private GameObject targetAI;

    public GameObject TargetAI
    {
        get { return targetAI; }
        protected set { targetAI = value; }
    }

    public virtual void SetTargetAI(GameObject target)
    {
        if (TargetAI == null)
        {
            TargetAI = target;
        }
    }

    public abstract bool Execute();
}