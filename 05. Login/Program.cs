// See https://aka.ms/new-console-template for more information



/*· If the password is incorrect, print "Incorrect password. Try again.".

· If the password is correct, print "User {username} logged in." and stop the program.

Keep in mind that if the password is still incorrect on the fourth attempt, you should print:
"User {username} blocked!".*/
string username = Console.ReadLine();
string password = new string(username.Reverse().ToArray());
int counter = 0;
for (int i = 1;i<=5;i++)
{string input= Console.ReadLine();
   
     counter++;
   
     if(input==password)
    { Console.WriteLine($"User {username} logged in."); break; }
     else if (counter == 4) 
    { Console.WriteLine($"User {username} blocked!");break; }
    else if (password!=input)
    { Console.WriteLine("Incorrect password. Try again."); }
}
