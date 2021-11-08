using SimpleEncrypt;

Decrypt decrypt = new Decrypt();
Encrypt encrypt = new Encrypt();
string temp = encrypt.EncryptText("hello world");
Console.WriteLine("Encrypted: " + temp);
Console.WriteLine("Decrypted: " + decrypt.DeCryptText(temp));

Console.ReadKey();