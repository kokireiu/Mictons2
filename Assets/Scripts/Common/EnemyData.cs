using System.Collections.Generic;
using UnityEngine;

//ScriptableObjectを継承したクラス

[CreateAssetMenu]
public class EnemyData : ScriptableObject {

  //ListステータスのList
  public List<EnemyStatus> EnemyStatusList = new List<EnemyStatus>();

}

//System.Serializableを設定しないと、データを保持できない(シリアライズできない)ので注意
[System.Serializable]
public class EnemyStatus{

  //設定したいデータの変数
  public string Name   = "なまえ";
  public int    HP     = 100, SP = 50, Atk = 5, Def = 15, Spd = 99, Exp = 58;
  public bool   IsBoss = false;

}