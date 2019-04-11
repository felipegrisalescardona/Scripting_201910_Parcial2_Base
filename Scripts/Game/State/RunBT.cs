using UnityEngine;

public class RunBT : State
{
    [SerializeField]
    protected Root btRoot;

    public override void Execute()
    {
        if (btRoot != null)
        {
            btRoot.Execute();
        }
    }
}