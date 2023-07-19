// int[] arr1 = new int[5];

// arr1[0] = 10;
// arr1[1] = 20;
// arr1[2] = 30;
// arr1[3] = 40;
// arr1[4] = 50;


// for(int i = 0; i < arr1.Length; i++) {
//   Console.WriteLine("Primeiro Array: {0}", arr1[i]);
// }

// int[] arr2 = new int[5];

// Array.Copy(arr1, arr2, arr1.Length);
// Array.Reverse(arr2);

// foreach(int i in arr2) {
//   Console.WriteLine("Segundo array {0}" + i);
// }


string[] arr3 = new string[5]{"John", "James", "Sara", "Pam", "Henrique"};

Console.WriteLine("Index do Henriques: {0},", Array.IndexOf(arr3, "Henrique"));
