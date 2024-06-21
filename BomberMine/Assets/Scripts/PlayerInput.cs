// ---------------------------------------------------------  
// PlayerInput.cs  
//   
// 作成日:  2024年6月21日
// 作成者:  堀田祐太
// ---------------------------------------------------------  
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class PlayerInput : MonoBehaviour
{

    #region 変数  
    private InputAction _inputAction = default;
    private InputControl _move = default;
    #endregion

    #region プロパティ  

    #endregion

    #region メソッド  

    public void OnMove(InputAction.CallbackContext callbackContext)
    {
        _move = callbackContext;
    }
    #endregion
}
