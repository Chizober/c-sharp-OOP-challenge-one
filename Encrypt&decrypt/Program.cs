using System;
using System.Text;
namespace EncodeD{
class Encrypt{
 char character;
  string encryptedMessage;
  public string  Encryptor(string messages)
  {
 List<string> encrypted =new List<string>();
foreach(char message in messages.ToString().ToLower())
 {
  switch (message){
           case 'a':
            character = '£';
            break;
          case 'b':
            character = '*';
            break;
          case 'c':
            character = '%';
            break;
          case 'd':
            character = '&';
            break;
          case 'e':
            character = '>';
            break;
          case 'f':
            character = '<';
            break;
          case 'g':
            character = '!';
            break;
          case 'h':
            character = ')';
            break;
          case 'i':
            character = '@';
            break;
          case 'j':
            character = 'a';
            break;
          case 'k':
            character = 'b';
            break;
          case 'l':
            character = 'c';
            break;
          case 'm':
            character = 'd';
            break;
          case 'n':
            character = 'e';
            break;
          case 'o':
            character = 'f';
            break;
          case 'p':
            character = 'g';
            break;
          case 'q':
            character = 'h';
            break;
          case 'r':
            character = 'i';
            break;
          case 's':
            character = 'j';
            break;
          case 't':
            character = 'k';
            break;
          case 'u':
            character = 'l';
            break;
          case 'v':
            character = 'm';
            break;
          case 'w':
            character = 'n';
            break;
          case 'x':
            character = 'o';
            break;
          case 'y':
            character = 'p';
            break;
          case 'z':
            character = 'q';
            break;
          default:
            character = message;
            break; 
        }
       encrypted.Add(character.ToString());
 }
       encryptedMessage = string.Join("", encrypted);
       return encryptedMessage;  
         
 }
}

class Decrypt{
   char character;
   string decryptedMessage;
  public string  Decryptor( string messages)
  {
 List<string> decrypted =new List<string>();
foreach(char message in messages.ToString())
 {
  switch (message){
          case '£':
            character = 'a';
            break;
          case '*':
            character = 'b';
            break;
          case '%':
            character = 'c';
            break;
          case '&':
            character = 'd';
            break;
          case '>':
            character = 'e';
            break;
          case '<':
            character = 'f';
            break;
          case '!':
            character = 'g';
            break;
          case ')':
            character = 'h';
            break;
          case '@':
            character = 'i';
            break;
          case 'a':
            character = 'j';
            break;
          case 'b':
            character = 'k';
            break;
          case 'c':
            character = 'l';
            break;
          case 'd':
            character = 'm';
            break;
          case 'e':
            character = 'n';
            break;
          case 'f':
            character = 'o';
            break;
          case 'g':
            character = 'p';
            break;
          case 'h':
            character = 'q';
            break;
          case 'i':
            character = 'r';
            break;
          case 'j':
            character = 's';
            break;
          case 'k':
            character = 't';
            break;
          case 'l':
            character = 'u';
            break;
          case 'm':
            character = 'v';
            break;
          case 'n':
            character = 'w';
            break;
          case 'o':
            character = 'x';
            break;
          case 'p':
            character = 'y';
            break;
          case 'q':
            character = 'z';
            break;
          default:
            character = message;
            break;
        }
        decrypted.Add(character.ToString());
      }
       decryptedMessage = string.Join("", decrypted);
      return decryptedMessage;   
 }
 }

class Program{
  static void Main(string[] args) 
  {
    string messages;
    Console.WriteLine("Enter a word, to encrypt");
    messages = Console.ReadLine();
    // Console.ReadKey();
    Encrypt en  = new Encrypt();
    string answer = en.Encryptor(messages);
    Console.WriteLine(answer);
    Console.WriteLine("Press Enter to change back to decrpted word");
    Console.ReadKey(true);
      Decrypt de  = new Decrypt();
    string decrpted = de.Decryptor(answer);
    Console.WriteLine(decrpted);
   
}
}
}

  
