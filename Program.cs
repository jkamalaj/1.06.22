using System;

namespace homework1
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            
                

                //Verilmiş string variable-ın dəyərini içərisində hər söz arasında bir boşluq gələcək vəzyətə salan metod.
                //Misalçün bu metoda dəyəri " salam,      Dunya" olan string  variable göndərsək həmin metod bu variable-ın dəyərini
                //dəyişib "salam, Dunya" vəziyyətinə salmalıdır.

                string a = "    Hello, P227   ";
                string b = a.Trim();
                Console.WriteLine(b);
            

            

                //Göndərilmiş string dəyərin aşğıdaki şərtləri ödəyib ödəmədiyini (bool) qaytaran metod
                //-İçində ən az 1 rəqəm olmalıdır
                //-İçində ən az 1 böyük hərf olmalıdır
                //- İçində ən az 1 kiçik hərf olmalıdır
                string words = " Hello 227";
                int count = 0;

                for (int i = 0; i < words.Length; i++)
                {


                    if (char.IsDigit(words[i]))
                        char.IsUpper(words[i]);
                    char.IsLower(words[i]);
                    count++;



                }
                Console.WriteLine(count);
            


            
               
                //Verilmiş string deyerinin icərisindəki ilk sözü tapıq qaytaran metod

                string sentence = "Hello, Kamala";
                string[] wordArr = sentence.Split(',');
                foreach(var item in wordArr)
                {
                    Console.WriteLine(item);
                    break;
                }


             
                //Parameter olaraq integer array variable-ı (reference) və bir integer value qəbul edən və həmin
                //integer value-nu integer array-ə yəni element kimi əlavə edən metod.

                int[] Num = { 23, 45, 65, 87 };
                int[] newArr = new int[5];
                Array.Resize(ref Num, Num.Length + 1);
                Num[4] = 95;
                Console.WriteLine(Num);

                //Clone
                String r = "hello";
                String y = (String)r.Clone();
                Console.WriteLine(y);

                //Concat
                string c = "Hello";
                string d = "World";
                Console.WriteLine(string.Concat(c, d));

                //Contains
                string ab = "HelloWorld";
                string cd = "World";
                Console.WriteLine(ab.Contains(cd));


                string ba = "software";
                string dc = "java";
                Console.WriteLine(ba.Contains(dc));


                //Copy
                string g = "Hello";
                string h = string.Copy( g);
                Console.WriteLine(h);

                //Equals
                string kc = "Hello";
                string ck = "World";
                Console.WriteLine(kc.Equals(ck));

                string s = "Hello";
                string w = "Hello";
                Console.WriteLine(s.Equals(w));

                //Indexof
                string z = "Hello";
                int j = z.IndexOf('o');
                Console.WriteLine(j);

                //Insert
                string l = "Hello";
                string t = l.Insert(2, "_world_");
                Console.WriteLine(t);

                //Replace
                string q = "Hello";
                string e = q.Replace("lo", "world");
                Console.WriteLine(e);

                //Substring
                string u = "Hello";
                string o = u.Substring(2);
                Console.WriteLine(o);

                //Trim
                string f = "Hello ";
                string n = f.Trim();
                Console.WriteLine(n);




            

        }


    }
}