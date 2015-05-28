using UnityEngine;
using System.Collections;

public class EasingDemo : MonoBehaviour
{
    public EaseType type;
    public Transform begin;
    public Transform end;

    public float refreshTime;

    void Start()
    {
        Refresh();
    }
	
    void Refresh()
    {
        StartCoroutine(Ease(type, refreshTime));

        Invoke("Refresh", refreshTime * 1.2f);
    }

    IEnumerator Ease(EaseType type, float time)
    {
        var t = 0.0f;

        var trans = begin;
        begin = end;
        end = trans;

        while (true)
        {
            var res = Easing.Ease(type, begin.position.x, end.position.x, t/time);

            var pos = transform.position;
            pos.x = res;
            transform.position = pos;

            if (t == time)
                break;

            yield return null;

            t += Time.deltaTime;

            if (t > time)
                t = time;
        }
    }
}
