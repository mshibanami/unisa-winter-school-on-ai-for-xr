using UnityEngine;

public class ProximityAction : MonoBehaviour
{
    [Tooltip("接近判定に使うタグ")]
    public string targetTag = "MainCamera";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            Debug.Log($"{name} に近づきました！");
            // ここに好きな処理を追加（例：色変更やアニメ再生）
        }
    }
}
