using UnityEngine;
public class Keypad : MonoBehaviour
{
    [SerializeField]
    private int[] password = new int[4] { 1, 2, 3, 4 };

    public int[] input { get; private set; } = new int[4] { -1, -1, -1, -1 };

    private void Initialize()
    {
        input = new int[password.Length];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = -1;
        }
    }
    public void Input(int num)
    {
        //입력 배열과 정답 배열의 크기가 다르면 초기화
        if (input.Length != password.Length)
            Initialize();

        //입력 배열에 숫자 입력
        for (int i = 0; i < input.Length; i++)
        {
            //비어있는 공간에 입력
            if (input[i] == -1)
            {
                input[i] = num;
                break;
            }
            //만약 마지막 칸까지 찼다면
            if (i == input.Length - 1)
            {
                //배열을 한칸씩 앞으로 당기고 마지막 칸에 입력
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                //마지막 칸에 입력
                input[input.Length - 1] = num;
            }
        }
    }
    public bool Check()
    {
        if (input.Length != password.Length)
        {
            Initialize();
            return false;
        }
        for (int i = 0; i < password.Length; i++) {
            if (input[i] != password[i]) 
                return false;
        }
        return true;
    }
}