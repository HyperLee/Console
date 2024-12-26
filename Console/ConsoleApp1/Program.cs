// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// main function
string s = "anagram";
string t = "nagaram";

Console.WriteLine("方法1: " + IsAnagram(s, t));
Console.WriteLine("方法2: " + IsAnagram2(s, t));

static bool IsAnagram(string s, string t)
{
    if(s.Length != t.Length)
    {
        return false;
    }

    char[] a = s.ToCharArray();
    char[] b = t.ToCharArray();

    Array.Sort(a);
    Array.Sort(b);

    if(a.SequenceEqual(b))
    {
        return true;
    }
    else
    {
        return false;
    }
}

static bool IsAnagram2(string s, string t)
{
    if(s.Length != t.Length)
    {
        return false;
    }

    Dictionary<char, int> dic = new Dictionary<char, int>();
    char[] a = s.ToCharArray();
    char[] b = t.ToCharArray();

    foreach(char c in a)
    {
        if(dic.ContainsKey(c))
        {
            dic[c]++;
        }
        else
        {
            dic.Add(c, 1);
        }
    }

    foreach(char c in b)
    {
        if(dic.ContainsKey(c))
        {
            dic[c]--;
        }
        else
        {
            return false;
        }
    }

    foreach(var item in dic)
    {
        if(item.Value != 0)
        {
            return false;
        }
    }

    return true;
}