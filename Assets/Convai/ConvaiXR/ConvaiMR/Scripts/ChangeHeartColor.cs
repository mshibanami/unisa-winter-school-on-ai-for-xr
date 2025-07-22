using System.Linq;
using UnityEngine;

public class ChangeHeartColor : StateMachineBehaviour
{
    [SerializeField] private string heartObjectName = "heart";
    [SerializeField] private Color targetColor = Color.yellow;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Renderer heartRenderer = GetHeartRenderer(animator);
        if (heartRenderer != null)
        {
            heartRenderer.material.color = targetColor;
        }
        else
        {
            Debug.LogError("heartRenderer が設定されていません");
        }
    }

    private MeshRenderer GetHeartRenderer(Animator animator)
    {
        return animator.GetComponentsInChildren<MeshRenderer>(true)
                       .FirstOrDefault(r => r.name == heartObjectName);
    }
}
