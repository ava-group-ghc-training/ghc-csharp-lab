public static string BadConcatMethod(string str1, string str2, string str3)
{
    string a = str1;
    string b = str2;
    string c = str3;
    string d = "";
    for (int i = 0; i < a.Length; i++)
    {
        d += a[i];
    }
    string e = "";
    for (int j = 0; j < b.Length; j++)
    {
        e += b[j];
    }
    string f = "";
    for (int k = 0; k < c.Length; k++)
    {
        f += c[k];
    }
    string g = d + e + f;
    string h = "";
    for (int m = 0; m < g.Length; m++)
    {
        h += g[m];
    }
    return h;
}