using System;  
public class Taazaa
{  
    public static void Main() 
{
    string str;
    int i, len, vowel, cons;
	str = "C Sharp is a programming language";
    vowel = 0;
    cons = 0;
    len = str.Length;
    for(i=0; i<len; i++)
    {
        if(str[i] =='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u' || str[i]=='A' || str[i]=='E' || str[i]=='I' 
        || str[i]=='O' || str[i]=='U')
        {
            vowel++;
        }
        else if((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z'))
        {
            cons++;
        }
    }
   Console.WriteLine("The total number of vowel :"+vowel);
   Console.WriteLine("The total number of consonant :"+cons);
	}
}


