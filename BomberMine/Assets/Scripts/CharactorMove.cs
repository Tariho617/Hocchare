// ---------------------------------------------------------  
// CharactorMove.cs  
//   
// 作成日:  
// 作成者:  
// ---------------------------------------------------------  
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using System.Collections;

public class CharactorMove : MonoBehaviour
{
  
    #region 変数  
  
    #endregion
  
    #region プロパティ  
  
    #endregion
  
    #region メソッド  
  
     /// <summary>  
     /// 初期化処理  
     /// </summary>  
     private void Awake()
     {
     }
  
     /// <summary>  
     /// 更新前処理  
     /// </summary>  
     private void Start ()
     {
        //移動の数値が変化すると反応するようにする
        this.UpdateAsObservable()
            .Where(_ => );
     }
  
     /// <summary>  
     /// 更新処理  
     /// </summary>  
     private void Update ()
     {
     }
  
    #endregion
}
