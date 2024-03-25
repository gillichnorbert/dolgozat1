using KockaSol;

Kocka cube = new Kocka(5);

double terfogat = cube.terfogatSzamitas();
Console.WriteLine($"A kocka térfogata: {terfogat}");

double felszin = cube.felszinSzamitas();
Console.WriteLine($"A kocka felszíne: {felszin}");
