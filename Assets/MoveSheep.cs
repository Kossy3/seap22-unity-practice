using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSheep : MonoBehaviour
{
    // privateのメンバ は一般にキャメルケース (最初小文字 + 大文字区切り)
    private Rigidbody2D rigidBody = null;
    private GroundCheck groundCheck = null;
    public float speed;
    public float jump;

    // Start is called before the first frame update
    void Start()
    {
        // Updateでいちいち取得すると重いので,代入して保存しておく
        rigidBody = this.GetComponent<Rigidbody2D>();
        groundCheck = this.GetComponentInChildren<GroundCheck>();

    }

    // Update is called once per frame
    void Update()
    {
        // 変数を作る (メソッド内のみで使う変数)
        // rigidbodyの物理演算を使うためにはtransformではなくrigidbodyを使って移動する必要がある。
        Vector2 pos = rigidBody.position;

        //キー入力によってposの値を変える

        // 左に移動
        if (Input.GetKey (KeyCode.A)) {
            pos += new Vector2(-speed, 0.0f);
        }
        // 右に移動
        if (Input.GetKey (KeyCode.D)) {
            pos += new Vector2(speed, 0.0f);
        }

        //ジャンプ
        if (Input.GetKeyDown (KeyCode.Space) && groundCheck.isGround) {
            //AddForceは物理演算でオブジェクトに力を加えるメソッド
            //ForceModeは力の加え方のオプション Impulseは瞬間的に力を与える
            rigidBody.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }

        // position を更新
        rigidBody.position = pos;
    }
}
