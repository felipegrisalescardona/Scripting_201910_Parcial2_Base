public class AICharacter : Character
{
    private State currentState;

    public void SetNewState(State newState)
    {
        currentState = newState;
    }
}