// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// main function
using System.Security.AccessControl;
using System.Text;

string s = "cczazcc";
int repeatLimit  = 3;

Console.WriteLine("ans: " + RepeatLimitedString(s, repeatLimit));


const int N = 26;
static string RepeatLimitedString(string s, int repeatLimit)
{
    int[] count = new int[N];
    foreach (char c in s)
    {
        // 統計每個 char 出現次數(數量)
        count[c - 'a']++;
    }

    // 輸出結果 res
    StringBuilder res = new StringBuilder();
    // 紀錄已填入 res 的 char 連續次數
    int m = 0;
    // 從字典序大的開始找, i: 當前未使用字典序最大 char, j: 當前未使用字典序次大的 char
    for (int i = N - 1, j = N - 2; i >= 0 && j >= 0;)
    {
        if (count[i] == 0)
        {
            // 最大字典序 i 回合
            // 當前 char 已經填完, 填入後面的 char, 重置 m
            m = 0;
            i--;
        }
        else if (m < repeatLimit)
        {
            // 當前 char 未超過限制
            count[i]--;
            // 轉成 char 加入 res
            res.Append((char)('a' + i));
            m++;
        }
        else if (j >= i || count[j] == 0)
        {
            // i 這邊次數達到上限, 換 j 這邊使用
            // 當前 char 已經超過限制, 查找可填入的其他 char 
            j--;
        }
        else
        {
            // 次大字典序 j 回合
            // 當前 char 已經超過限制, 填入其他 char , 並且重置 m
            count[j]--;
            // 轉成 char 加入 res
            res.Append((char)('a' + j));
            m = 0;
        }
    }

    return res.ToString();
}

