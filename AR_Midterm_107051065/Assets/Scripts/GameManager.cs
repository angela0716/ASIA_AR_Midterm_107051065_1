using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("男人")]
    public Transform man;
    [Header("女人")]
    public Transform women;
    [Header("虛擬搖桿")]
    public bl_Joystick joystick;
    [Header("旋轉速度")]
    [Range(0.1f, 15f)]
    public float turn = 0.5f;
    [Header("縮放")]
    [Range(0f, 5f)]
    public float size = 0.1f;
    [Header("男人動畫元件")]
    public Animator animan;
    [Header("女人動畫元件")]
    public Animator aniwomen;

    private void Start()
    {
        print("開始事件");
    }
    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);
        man.Rotate(0, joystick.Horizontal * turn, 0);
        women.Rotate(0, joystick.Horizontal * turn, 0);

        man.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        man.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(man.localScale.x, 0.5f, 4f);
        women.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        women.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(women.localScale.x, 0.5f, 4f);
    }
    public void run()
    {
        print("跑");
        animan.SetTrigger("跑");
        aniwomen.SetTrigger("跑");
    }
    public void PlayAnimation(string aniName)
    {
        print(aniName);
        animan.SetTrigger(aniName);
        aniwomen.SetTrigger(aniName);
}
}

