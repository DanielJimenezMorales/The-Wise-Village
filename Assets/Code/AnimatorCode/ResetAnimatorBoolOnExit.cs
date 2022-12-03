using UnityEngine;

public class ResetAnimatorBoolOnExit : StateMachineBehaviour
{
    [SerializeField] private string parameterName = System.String.Empty;
    [SerializeField] private bool status = false;

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(parameterName, status);
    }
}
