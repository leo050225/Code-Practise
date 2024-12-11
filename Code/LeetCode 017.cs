using System.Xml.Serialization;

public class Solution {
    public IList<string> LetterCombinations(string digits) 
    {
        if(digits.Length==0)//返回空
        {
            return res;
        }
        BackTracking(digits,0);//調用

        return res;//返回結果
    }

    public IList<string> res = new List<string>();//儲存結果

    public string s;

    //對照電話裡的數字和字母                     0   1    2      3      4      5      6       7      8      9   
    public string[] letterMap = new string[10]{"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

    public void BackTracking(string digits,int index)
    {
        if(index == digits.Length)//如果達到數量的話 加入然後返回
        {
            res.Add(s);//加入集合
            return ;//返回
        }

        int digit = digits[index] -'0';//digits第幾個數字

        string letters = letterMap[digit];//傳進數字對應的字母 2=abc

        for(int i = 0; i<letters.Length; i++)//循環
        {
            s+=letters[i];//加入當前數字的字母
            BackTracking(digits,index+1);//遞歸
            s = s.Substring(0,s.Length-1);//回朔 裁切除了最後一位的所有數字
        }

    }
}
