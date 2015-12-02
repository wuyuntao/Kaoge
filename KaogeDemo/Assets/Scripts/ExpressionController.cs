using System.Collections.Generic;
using UnityEngine;

public class ExpressionController : MonoBehaviour
{
    public Transform face;

    public Transform leftEye;
    public Transform leftEyebrow;
    public Transform leftEyelid;
    public Transform leftEyeball;

    public Transform rightEye;
    public Transform rightEyebrow;
    public Transform rightEyelid;
    public Transform rightEyeball;

    public Transform lips;

    public void Play(string expressionName)
    {
        Debug.LogFormat("Play expression '{0}'", expressionName);

        switch (expressionName)
        {
            default:
                foreach (var child in GetChildren())
                {
                    Play(child, expressionName);
                }
                break;
        }
    }

    private void Play(Transform child, string expressionName)
    {
        if (child == null)
            return;

        var animator = child.GetComponent<Animator>();
        if (animator == null)
            return;

        animator.Play(expressionName);
    }

    private IEnumerable<Transform> GetChildren()
    {
        yield return face;
        yield return leftEye;
        yield return rightEye;
        yield return lips;
    }
}
