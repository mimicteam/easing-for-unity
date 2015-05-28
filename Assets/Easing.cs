using UnityEngine;
using System;

public enum EaseType
{
    Lerp,
    QuadIn,
    QuadOut,
    QuadInOut,
    QuadOutIn,
    CubicIn,
    CubicOut,
    CubicInOut,
    CubicOutIn,
    QuartIn,
    QuartOut,
    QuartInOut,
    QuartOutIn,
    QuintIn,
    QuintOut,
    QuintInOut,
    QuintOutIn,
    SineIn,
    SineOut,
    SineInOut,
    SineOutIn,
    ExpoIn,
    ExpoOut,
    ExpoInOut,
    ExpoOutIn,
    CircIn,
    CircOut,
    CircInOut,
    CircOutIn,
    ElasticIn,
    ElasticOut,
    ElasticInOut,
    ElasticOutIn,
    BackIn,
    BackOut,
    BackInOut,
    BackOutIn,
    BounceIn,
    BounceOut,
    BounceInOut,
    BounceOutIn
}

public static class Easing
{
    #region Public Interface (Enum)

    public static float Ease(EaseType type, float from, float to, float t)
    {
        switch (type)
        {
            case EaseType.Lerp :
                return Lerp(from, to, t);
            case EaseType.QuadIn :
                return QuadIn(from, to, t);
            case EaseType.QuadOut :
                return QuadOut(from, to, t);
            case EaseType.QuadInOut :
                return QuadInOut(from, to, t);
            case EaseType.QuadOutIn :
                return QuadOutIn(from, to, t);
            case EaseType.CubicIn :
                return CubicIn(from, to, t);
            case EaseType.CubicOut :
                return CubicOut(from, to, t);
            case EaseType.CubicInOut :
                return CubicInOut(from, to, t);
            case EaseType.CubicOutIn :
                return CubicOutIn(from, to, t);
            case EaseType.QuartIn :
                return QuartIn(from, to, t);
            case EaseType.QuartOut :
                return QuartOut(from, to, t);
            case EaseType.QuartInOut :
                return QuartInOut(from, to, t);
            case EaseType.QuartOutIn :
                return QuartOutIn(from, to, t);
            case EaseType.QuintIn :
                return QuintIn(from, to, t);
            case EaseType.QuintOut :
                return QuintOut(from, to, t);
            case EaseType.QuintInOut :
                return QuintInOut(from, to, t);
            case EaseType.QuintOutIn :
                return QuintOutIn(from, to, t);
            case EaseType.SineIn :
                return SineIn(from, to, t);
            case EaseType.SineOut :
                return SineOut(from, to, t);
            case EaseType.SineInOut :
                return SineInOut(from, to, t);
            case EaseType.SineOutIn :
                return SineOutIn(from, to, t);
            case EaseType.ExpoIn :
                return ExpoIn(from, to, t);
            case EaseType.ExpoOut :
                return ExpoOut(from, to, t);
            case EaseType.ExpoInOut :
                return ExpoInOut(from, to, t);
            case EaseType.ExpoOutIn :
                return ExpoOutIn(from, to, t);
            case EaseType.CircIn :
                return CircIn(from, to, t);
            case EaseType.CircOut :
                return CircOut(from, to, t);
            case EaseType.CircInOut :
                return CircInOut(from, to, t);
            case EaseType.CircOutIn :
                return CircOutIn(from, to, t);
            case EaseType.ElasticIn :
                return ElasticIn(from, to, t);
            case EaseType.ElasticOut :
                return ElasticOut(from, to, t);
            case EaseType.ElasticInOut :
                return ElasticInOut(from, to, t);
            case EaseType.ElasticOutIn :
                return ElasticOutIn(from, to, t);
            case EaseType.BackIn :
                return BackIn(from, to, t);
            case EaseType.BackOut :
                return BackOut(from, to, t);
            case EaseType.BackInOut :
                return BackInOut(from, to, t);
            case EaseType.BackOutIn :
                return BackOutIn(from, to, t);
            case EaseType.BounceIn :
                return BounceIn(from, to, t);
            case EaseType.BounceOut :
                return BounceOut(from, to, t);
            case EaseType.BounceInOut :
                return BounceInOut(from, to, t);
            case EaseType.BounceOutIn :
                return BounceOutIn(from, to, t);
        }

        return 0.0f;
    }

    #endregion

    #region Public Interface (Functions)

    public static float Lerp(float from, float to, float t)
    {
        return In(Linear, t, from, to - from);
    }

    public static float QuadIn(float from, float to, float t)
    {
        return In(Quad, t, from, to - from);
    }

    public static float QuadOut(float from, float to, float t)
    {
        return Out(Quad, t, from, to - from);
    }

    public static float QuadInOut(float from, float to, float t)
    {
        return InOut(Quad, t, from, to - from);
    }

    public static float QuadOutIn(float from, float to, float t)
    {
        return OutIn(Quad, t, from, to - from);
    }

    public static float CubicIn(float from, float to, float t)
    {
        return In(Cubic, t, from, to - from);
    }

    public static float CubicOut(float from, float to, float t)
    {
        return Out(Cubic, t, from, to - from);
    }

    public static float CubicInOut(float from, float to, float t)
    {
        return InOut(Cubic, t, from, to - from);
    }

    public static float CubicOutIn(float from, float to, float t)
    {
        return OutIn(Cubic, t, from, to - from);
    }

    public static float QuartIn(float from, float to, float t)
    {
        return In(Quart, t, from, to - from);
    }

    public static float QuartOut(float from, float to, float t)
    {
        return Out(Quart, t, from, to - from);
    }

    public static float QuartInOut(float from, float to, float t)
    {
        return InOut(Quart, t, from, to - from);
    }

    public static float QuartOutIn(float from, float to, float t)
    {
        return OutIn(Quart, t, from, to - from);
    }

    public static float QuintIn(float from, float to, float t)
    {
        return In(Quint, t, from, to - from);
    }

    public static float QuintOut(float from, float to, float t)
    {
        return Out(Quint, t, from, to - from);
    }

    public static float QuintInOut(float from, float to, float t)
    {
        return InOut(Quint, t, from, to - from);
    }

    public static float QuintOutIn(float from, float to, float t)
    {
        return OutIn(Quint, t, from, to - from);
    }

    public static float SineIn(float from, float to, float t)
    {
        return In(Sine, t, from, to - from);
    }

    public static float SineOut(float from, float to, float t)
    {
        return Out(Sine, t, from, to - from);
    }

    public static float SineInOut(float from, float to, float t)
    {
        return InOut(Sine, t, from, to - from);
    }

    public static float SineOutIn(float from, float to, float t)
    {
        return OutIn(Sine, t, from, to - from);
    }

    public static float ExpoIn(float from, float to, float t)
    {
        return In(Expo, t, from, to - from);
    }

    public static float ExpoOut(float from, float to, float t)
    {
        return Out(Expo, t, from, to - from);
    }

    public static float ExpoInOut(float from, float to, float t)
    {
        return InOut(Expo, t, from, to - from);
    }

    public static float ExpoOutIn(float from, float to, float t)
    {
        return OutIn(Expo, t, from, to - from);
    }

    public static float CircIn(float from, float to, float t)
    {
        return In(Circ, t, from, to - from);
    }

    public static float CircOut(float from, float to, float t)
    {
        return Out(Circ, t, from, to - from);
    }

    public static float CircInOut(float from, float to, float t)
    {
        return InOut(Circ, t, from, to - from);
    }

    public static float CircOutIn(float from, float to, float t)
    {
        return OutIn(Circ, t, from, to - from);
    }

    public static float ElasticIn(float from, float to, float t)
    {
        return In(Elastic, t, from, to - from);
    }

    public static float ElasticOut(float from, float to, float t)
    {
        return Out(Elastic, t, from, to - from);
    }

    public static float ElasticInOut(float from, float to, float t)
    {
        return InOut(Elastic, t, from, to - from);
    }

    public static float ElasticOutIn(float from, float to, float t)
    {
        return OutIn(Elastic, t, from, to - from);
    }

    public static float BackIn(float from, float to, float t)
    {
        return In(Back, t, from, to - from);
    }

    public static float BackOut(float from, float to, float t)
    {
        return Out(Back, t, from, to - from);
    }

    public static float BackInOut(float from, float to, float t)
    {
        return InOut(Back, t, from, to - from);
    }

    public static float BackOutIn(float from, float to, float t)
    {
        return OutIn(Back, t, from, to - from);
    }

    public static float BounceIn(float from, float to, float t)
    {
        return In(Bounce, t, from, to - from);
    }

    public static float BounceOut(float from, float to, float t)
    {
        return Out(Bounce, t, from, to - from);
    }

    public static float BounceInOut(float from, float to, float t)
    {
        return InOut(Bounce, t, from, to - from);
    }

    public static float BounceOutIn(float from, float to, float t)
    {
        return OutIn(Bounce, t, from, to - from);
    }

    #endregion

    #region Ease Types

    private static float In(Func<float, float, float> ease_f, float t, float b, float c, float d = 1)
    {
        if (t >= d)
            return b + c;
        if (t <= 0)
            return b;

        return c * ease_f(t, d) + b;
    }

    private static float Out(Func<float, float, float> ease_f, float t, float b, float c, float d = 1)
    {
        if (t >= d)
            return b + c;
        if (t <= 0)
            return b;

        return (b + c) - c * ease_f(d - t, d);
    }

    private static float InOut(Func<float, float, float> ease_f, float t, float b, float c, float d = 1)
    {
        if (t >= d)
            return b + c;
        if (t <= 0)
            return b;

        if (t < d / 2)
            return In(ease_f, t * 2, b, c / 2, d);

        return Out(ease_f, (t * 2) - d, b + c / 2, c / 2, d);
    }

    private static float OutIn(Func<float, float, float> ease_f, float t, float b, float c, float d = 1)
    {
        if (t >= d)
            return b + c;
        if (t <= 0)
            return b;

        if (t < d / 2)
            return Out(ease_f, t * 2, b, c / 2, d);

        return In(ease_f, (t * 2) - d, b + c / 2, c / 2, d);
    }

    #endregion

    #region Equations

    private static float Linear(float t, float d = 1)
    {
        return t / d;
    }

    private static float Quad(float t, float d = 1)
    {
        return (t /= d) * t;
    }

    private static float Cubic(float t, float d = 1)
    {
        return (t /= d) * t * t;
    }

    private static float Quart(float t, float d = 1)
    {
        return (t /= d) * t * t * t;
    }

    private static float Quint(float t, float d = 1)
    {
        return (t /= d) * t * t * t * t;
    }

    private static float Sine(float t, float d = 1)
    {
        return 1 - Mathf.Cos(t / d * (Mathf.PI / 2));
    }

    private static float Expo(float t, float d = 1)
    {
        return Mathf.Pow(2, 10 * (t / d - 1));
    }

    private static float Circ(float t, float d = 1)
    {
        return -(Mathf.Sqrt(1 - (t /= d) * t) - 1);
    }

    private static float Elastic(float t, float d = 1)
    {
        t /= d;
        var p = d * .3f;
        var s = p / 4;
        return -(Mathf.Pow(2, 10 * (t -= 1)) * Mathf.Sin((t * d - s) * (2 * Mathf.PI) / p));
    }

    private static float Back(float t, float d = 1)
    {
        return (t /= d) * t * ((1.70158f + 1) * t - 1.70158f);
    }

    private static float Bounce(float t, float d = 1)
    {
        t = d - t;
        if ((t /= d) < (1 / 2.75f))
            return 1 - (7.5625f * t * t);
        else if (t < (2 / 2.75f))
            return 1 - (7.5625f * (t -= (1.5f / 2.75f)) * t + .75f);
        else if (t < (2.5f / 2.75f))
            return 1 - (7.5625f * (t -= (2.25f / 2.75f)) * t + .9375f);
        else
            return 1 - (7.5625f * (t -= (2.625f / 2.75f)) * t + .984375f);
    }

    #endregion
}
