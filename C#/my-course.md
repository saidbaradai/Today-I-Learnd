### 1. Ödev
---
10 elemanlı A ve B isimli iki dizi tanımlayabilirsiniz. Bu dizilere 5 ile 10 arasında rastgele sayılar atayabilirsiniz. 
Ardından C adında üçüncü bir dizi tanımlayabilir ve bu dizinin elemanları, A ve B dizilerindeki ilgili elemanların toplamı olabilir.

Son olarak, C dizisini yazdırabilirsiniz.


```c#
Random random = new Random();

// A ve B dizilerini tanımlayın ve rastgele sayılarla doldurun
int[] A = new int[10];
int[] B = new int[10];

for (int i = 0; i < 10; i++)
{
    A[i] = random.Next(5, 11); // A dizisi için 5 ile 10 arasında rastgele sayı atayın
    B[i] = random.Next(5, 11); // B dizisi için 5 ile 10 arasında rastgele sayı atayın
}

// C dizisini tanımlayın ve A ve B dizilerinin elemanlarını toplayarak doldurun
int[] C = new int[10];

for (int i = 0; i < 10; i++)
{
    C[i] = A[i] + B[i]; // C dizisinin i. elemanını A ve B dizilerinin i. elemanlarının toplamı olarak atayın
}

// C dizisini yazdırın
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("C[" + i + "] = " + C[i]); // C dizisinin i. elemanını yazdırın
}


```
