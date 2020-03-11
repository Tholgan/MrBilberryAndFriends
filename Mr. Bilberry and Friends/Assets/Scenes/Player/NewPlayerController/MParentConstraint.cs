using UnityEngine;
using UnityEngine.Animations.Rigging;


public class MParentConstraint : MonoBehaviour
{
    public GameObject mParentCon;

    public enum Mode
    {
        Idle,
        Ground,
        Back,
        Side,
        Mouth,
        RHand,
        LHand
    }

    public Mode m_Mode;

    public void Update()
    {
        //if (m_Mode != Mode.Idle)
        //{
            var constraint = mParentCon.GetComponent<MultiParentConstraint>();
            var sourceObjects = constraint.data.sourceObjects;

            sourceObjects.SetWeight(0, m_Mode == Mode.Ground ? 1f : 0f);
            //sourceObjects.SetWeight(1, m_Mode == Mode.Back ? 1f : 0f);
            constraint.data.constrainedObject.gameObject.SetActive(m_Mode != Mode.Back);
            sourceObjects.SetWeight(2, m_Mode == Mode.Side ? 1f : 0f);
            sourceObjects.SetWeight(3, m_Mode == Mode.Mouth ? 1f : 0f);
            sourceObjects.SetWeight(4, m_Mode == Mode.RHand ? 1f : 0f);
            sourceObjects.SetWeight(5, m_Mode == Mode.LHand ? 1f : 0f);
            constraint.data.sourceObjects = sourceObjects;


        //    m_Mode = Mode.Idle;
        //}
    }

    public void Start()
    {
        m_Mode = Mode.Back;
        Debug.Log("back");
    }

    public void Back()
    {
        m_Mode = Mode.Back;
        Debug.Log("back");
    }
    public void Side()
    {
        m_Mode = Mode.Side;
        Debug.Log("side");
    }
    public void Mouth()
    {
        m_Mode = Mode.Mouth;
        Debug.Log("mouth");
    }

    public void RHand()
    {
        m_Mode = Mode.RHand;
        Debug.Log("hand");
    }

    public void LHand()
    {
        m_Mode = Mode.LHand;
        Debug.Log("hand");
    }
}
