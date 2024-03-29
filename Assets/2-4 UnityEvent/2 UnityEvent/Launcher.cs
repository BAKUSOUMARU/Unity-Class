﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 発射台を制御するコンポーネント。
/// 発射台に接触している Rigidbody を上に打ち上げる。
/// </summary>
public class Launcher : MonoBehaviour
{
    /// <summary>接触しているコライダー</summary>
     List< Collider2D> m_touchingColliders = new List<Collider2D>();
    
    /// <summary>
    /// 接触している Rigidbody を打ち上げる。
    /// 
    /// </summary>
    /// <param name="power">打ち上げる力</param>
    public void Launch(float power)
    {
        foreach (var c in m_touchingColliders)
        {
            Rigidbody2D rb = c?.GetComponent<Rigidbody2D>();
            rb?.AddForce(Vector2.up * power, ForceMode2D.Impulse);

        }
        //Rigidbody2D rb = m_touchingColliders?.GetComponent<Rigidbody2D>();
        //rb?.AddForce(Vector2.up * power, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //m_touchingCollider = collision.collider;
        m_touchingColliders.Add(collision.collider);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        
    }
    
        
        
}
