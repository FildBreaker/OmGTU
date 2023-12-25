using System;

class MainClass {
  public static void Main (string[] args) {
    for (int i = 106732567; i <= 152673836; i++) {
      int count = 0;
      int maxDivisor = 0;
      for (int j = 2; j <= Math.Sqrt(i); j++) {
        if (i % j == 0) {
          count++;
          maxDivisor = Math.Max(j, i/j);
          if (count > 3) break;
        }
      }
      if (count == 2 && maxDivisor * maxDivisor != i) { // ensure only 3 non-trivial divisors
        Console.WriteLine(i + " " + maxDivisor);
      }
    }
  }
}