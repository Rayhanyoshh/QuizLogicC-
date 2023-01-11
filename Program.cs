
// Quiz No.1
//Console.WriteLine("-------QUIZ NO 1----------");

//int sum = 0;

//Console.WriteLine("Enter number: ");
//string input = Console.ReadLine();
//char[] charsArray = input.ToCharArray();

//for (int i = 0; i < charsArray.Length; i++)
//{
//    sum += Convert.ToInt32(charsArray[i].ToString());
//}

//Console.WriteLine("Pertambahan dari array diatas: " + sum);


// QUIZ NO 2
//int sum = 0;
//int count = 0;

//Console.WriteLine("Enter number: ");
//string input = Console.ReadLine();
//char[] charsArray = input.ToCharArray();

//for (int i = 0; i < charsArray.Length; i++)
//{
//    sum += Convert.ToInt32(charsArray[i].ToString());
//    count++;
//}

//Console.WriteLine("Pertambahan dari array diatas: " + sum);
//Console.WriteLine("Dan Jumlah dari array diatas adalah : "+count);


//QUIZ NO 3
//Console.Write("Masukkan angka: ");
//int input = int.Parse(Console.ReadLine());

//// convert int to string, then to char array
//char[] inputArray = input.ToString().ToCharArray();

//// reverse the array
//Array.Reverse(inputArray);

//// give separate in output 
//string reversedWithSpace = string.Join(" ", inputArray);

//Console.WriteLine("Angka setelah dibalik: " + reversedWithSpace);


//QUIX NO 4
//Console.WriteLine("----------QUIZ 4-----------");
//int largest = int.MinValue;
//while (true)
//{
//    Console.WriteLine("Masukkan angka: ");
//    int num = int.Parse(Console.ReadLine());
//    if (num == 0)
//    {
//        break;
//    }
//    largest = Math.Max(largest, num);
//}
//Console.WriteLine("Angka terbesar adalah: " + largest);

//QUIZ 5
//Console.WriteLine("----------QUIZ 5-----------");
//Console.Write("Masukkan bilangan: ");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine("Angka pembagi dari " + num + " adalah:");
//for (int i = 1; i < num; i++)
//{
//    if (num % i == 0)
//    {
//        Console.Write(i + " ");
//    }
//}


// QUIZ 6
//int count = 0;
//int angkaPrima = 2;
//Console.WriteLine("Enter Limit Number: ");
//int primeCount = int.Parse(Console.ReadLine());
//Console.WriteLine($"List of Prime Number With {primeCount} limit ");
//while (count < primeCount)
//{
//    bool isPrime = true;
//    for (int i = 2; i <= Math.Sqrt(angkaPrima); i++)
//    {
//        if (angkaPrima % i == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }
//    if (isPrime)
//    {
//        Console.Write(angkaPrima + " ");
//        count++;
//    }
//    angkaPrima++;
//}


//QUIZ 7
//Console.WriteLine("Masukkan kalimat:");
//string kalimat = Console.ReadLine();
//string[] Arraykata = kalimat.Split(' ');
//for (int i = 0; i < Arraykata.Length; i++)
//{
//    if (Arraykata[i].Length > 2)
//    {
//        Arraykata[i] = Arraykata[i][0] + new string('*', Arraykata[i].Length - 2) + Arraykata[i][Arraykata[i].Length - 1];
//    }
//}
//kalimat = string.Join(" ", Arraykata);
//Console.WriteLine("Kalimat setelah diubah:");
//Console.WriteLine(kalimat);


////quiz 8
//Console.WriteLine("---------QUIZ 8------------");
//int dayOfWeek = (int)DateTime.Today.DayOfWeek;
//int daysUntilSaturday = 6 - dayOfWeek;
//DateTime nextSaturday = DateTime.Today.AddDays(daysUntilSaturday);
//Console.WriteLine($"Hari Sabtu: {nextSaturday.ToString("dd/MM/yyyy")}");
//Console.WriteLine("{0} hari lagi !", daysUntilSaturday);
//Console.WriteLine(dayOfWeek);


//QUIZ 9
//Console.Write("Input String : ");
//string text = Console.ReadLine();
//Console.Write("What String to Find : ");
//string stringToSearch = Console.ReadLine();
//int count = 0;
//int index = text.IndexOf(stringToSearch);

//while (index != -1)
//{
//    count++;
//    index = text.IndexOf(stringToSearch, index + stringToSearch.Length);
//}
//Console.WriteLine($"Total kata yang muncul : {count}, dari text : {text}");

//QUIZ 10
//int[] numbers = new int[5];
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Masukkan angka ke-" + (i + 1) + ": ");
//    numbers[i] = int.Parse(Console.ReadLine());
//}
////sort the array in descending order
//Array.Sort(numbers);
//Console.WriteLine("Second greatest number is: " + numbers[3]);


//QUIZ 11
//Console.WriteLine("-------------QUIZ 11-------------");
//bool CheckKurawal(string input)
//{
//    int count = 0;
//    for (int i = 0; i < input.Length; i++)
//    {
//        if (input[i] != '{' && input[i] != '}')
//        {
//            Console.WriteLine("Input hanya boleh berisi kurung kurawal!");
//            break;
//        }
//        if (input[i] == '{')
//            count++;
//        if (input[i] == '}')
//            count--;

//        if (count < 0)
//            return false;
//    }
//    return count == 0;
//}
//string input = Console.ReadLine();
//bool result = CheckKurawal(input);
//Console.WriteLine(result);

// QUIZ 12
//Console.WriteLine("Col=5, Row=5, Segitiga Normal");
//for (int i = 1; i <= 5; i++)
//{
//    for (int j = i; j < i + i; j++)
//    {
//        Console.Write(j + " ");
//    }
//    Console.WriteLine();
//}


//Console.WriteLine("-----Col=9, Row=5----");
//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= 5 - i; j++)
//    {
//        Console.Write("  ");
//    }
//    for (int j = i; j <= 2 * i - 1; j++)
//    {
//        Console.Write(j + " ");
//    }
//    for (int j = 2 * i - 2; j >= i; j--)
//    {
//        Console.Write(j + " ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine("----Col=5, Row=5, Segitiga Terbalik----");
//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 10; j >= 5 + i; j--)
//    {
//        Console.Write(j + " ");
//    }
//    Console.WriteLine();
//}




//Console.WriteLine("----Col= 9, Row = 5-------");
//for (int i = 1; i <= 4; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(j + " ");
//    }
//    Console.WriteLine();
//}
//for (int i = 3; i >= 1; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(j + " ");
//    }
//    Console.WriteLine();
//}

















