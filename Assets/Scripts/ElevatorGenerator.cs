using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorGenerator : MonoBehaviour
{
    public elevator elevator;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateElevator", 3f, 1f);
    }

    // Update is called once per frame
    void GenerateElevator()
    {
        // Instantiateの引数の挙動に注意
        // 引数が2つの場合、第二引数は親オブジェクトの親オブジェクトのtransformを指す
        // 引数が3つの場合は、引数の型に応じて
        // 第二：親オブジェクトのtransform(transform)、第三：ワールド座標(false)or親基準のローカル座標の切り替え(true)　指定しない場合true
        // 第二：生成オブジェクトのposition(Vector3), 生成オブジェクトのrotation(Quaternion)
        // を切り替える
        // よってオブジェクトの位置を初期化する場合、positionに加えrotationまで指定する必要がある
        // 親オブジェクトと同じ位置に生成したい場合、Instantiate(elevator, this.transform.position, this.transform.rotation)
        // とする方法もあるが, あらかじめPrefabのoriginalの座標を0,0に設定しておくことで、
        // Instantiate(elevator, this.transform) のように書いて実現できる
        Instantiate(elevator, this.transform);
    }
}
