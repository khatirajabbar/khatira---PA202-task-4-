#region first task
// Ədədlər massivindəki bütün elementləri faktorialına yüksəldin (məs: {5, 4, 6} -> {120, 24, 720 })
/*long[] numbers = { 15, 4, 3 };
for (long i = 0; i < numbers.Length; i++)
{
    long eded = numbers[i]; 
    long faktorial = 1; 
    for (long j = 1; j <= eded; j++)
    {
        faktorial *= j;
    }
    
    numbers[i] = (long)faktorial; 
}

Console.Write("Netice massivi: ");
foreach (int n in numbers)
{
    Console.Write(n + ", ");
}*/
#endregion
#region second task
/*int [] numbers = { 15, 4, 3, 9, 0, 8 };
int min = numbers[0];
foreach (int n in numbers)
{
    if (n < min) min = n;
}
int[] result = new int[numbers.Length - 1];
int index = 0;

bool silindi = false;
        
foreach (int n in numbers)
 {
     if (n == min && !silindi)
            {
                silindi = true;
                continue; 
            }
            
            result[index] = n;
            index++;  }



Console.Write("Yeni massiv: ");
foreach (int item in result)
        {
            Console.Write(item + " ");
        }*/ 
#endregion
#region third task
//Verilmiş stringdə yalnız 1 dəfə işlənmiş ilk simvolu çıxışa ver. (məs: "kərtənkələ" -> 'r')=
/*string soz = "kertenkele";
char netice = ' ';
bool tapildi = false;
for (int i = 0; i < soz.Length; i++)
 { char cariHerf = soz[i];
     int count = 0;
            for (int j = 0; j < soz.Length; j++)
            {
                if (soz[j] == cariHerf)
                {
                    count++;
                }
            }
            
            if (count == 1)
            {
                netice = cariHerf;
                tapildi = true;
                break; 
            } 
 }


        if (tapildi)
        {
            Console.WriteLine("Yalnız 1 defə işlenmiş ilk simvol: " + netice);
        }
        else
        {
            Console.WriteLine("Bele bir simvol yoxdur.");
        }*/
#endregion
#region fourth task
// int n = 10;
// int m = 200;
//
// Console.WriteLine($"{n} və {m} arasindaki polindromlar:");
//
// for (int i = n; i <= m; i++)
// {
//     int orjinalEded = i;
//     int muveqqeti = i;
//     int tersEded = 0;
//     while (muveqqeti > 0)
//     {
//         int qaliq = muveqqeti % 10; 
//         tersEded = (tersEded * 10) + qaliq; 
//         muveqqeti = muveqqeti / 10; 
//     }
//     
//     if (orjinalEded == tersEded)
//     {
//         Console.Write(orjinalEded + " ");
//     }
// }
#endregion
#region fifth task
// Verilmiş stringdə ən çox təkrarlanan simvolu və neçə dəfə təkrarlandığını çıxışa verən proqram.
// string word = "proqramlasdirma";
// Console.WriteLine($"sozumuz: {word}");
// char enCoxTekrarlanan = ' ';
// int maksimumSay = 0;
// for (int i = 0; i < word.Length; i++)
// {
//     char cariHerf = word[i];
//     int count = 0;
//     for (int j = 0; j < word.Length; j++)
//     {
//         if (word[j] == cariHerf)
//         {
//             count++;
//         }
//     }
//     if (count > maksimumSay)
//     {
//         maksimumSay = count;
//         enCoxTekrarlanan = cariHerf;
//     }
// }
// Console.WriteLine($"en cox tekrarlanan simvol: '{enCoxTekrarlanan}'");
// Console.WriteLine($"tekrar sayi: {maksimumSay}");
#endregion
#region sixth task
// Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 
// string text = "bu gun qar yagir";
// string netice = "";
// for (int i = 0; i < text.Length; i++)
// {
//     if (text[i] != ' ')
//     {
//         netice += text[i];
//     }
// }
// Console.WriteLine("Orijinal: " + text);
// Console.WriteLine("Boşluqsuz: " + netice);
#endregion
#region seventh task
// Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram
// string[] words = { "sumqayit", "saray", "baki", "ceyranbatan" };
// char axtarilanHerf = 'a';
// int totalNumber = 0;
// foreach (string soz in words)
// {
//     for (int i = 0; i < words.Length; i++)
//     {
//         if (soz[i] == axtarilanHerf)
//         {
//             totalNumber++;
//         }
//
//     }
// }
// Console.WriteLine($"sözlər: {string.Join(", ", words)}");
// Console.WriteLine($"siyahida umimi {totalNumber} eded '{axtarilanHerf}' herfi var.");
#endregion

    
