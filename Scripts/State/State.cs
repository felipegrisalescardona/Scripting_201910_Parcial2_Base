using UnityEngine;

public abstract class State : MonoBehaviour
{
    [SerializeField]
    private State nextState;

    public abstract void Execute();

    private void SwitchToNextState()
    {
        if (nextState != null)
        {
            Toggle(false);
            nextState.Toggle(true);
        }
    }

    public void Toggle(bool val)
    {
        this.enabled = val;

        if (val)
        {
            Execute();
        }
    }
}