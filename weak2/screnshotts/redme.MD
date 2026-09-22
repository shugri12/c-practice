##Screenshot 1

Explanation
textBox1_TextChanged: This event runs whenever the text inside the TextBox changes.
textpractice.Text: The Text property is used to set or get text in a TextBox.
"hi guzy": This is a string value, so it can be assigned to the Text property.
The following lines clear the TextBox in different ways:
textpractice.Text = "hi guzy"; → Displays "hi guzy".
textpractice.Text = ""; → Makes the TextBox empty.
textpractice.Text = string.Empty; → Also makes the TextBox empty.
textpractice.Clear(); → Clears all text from the TextBox.



##screenshot 2

1. private void lblans_Click(...)
This is an event handler. It runs when the user clicks the lblans label.
2. string productname;
This creates a variable called productname.
string means the variable stores text.
3. productname = "laptop HP";
This assigns the text "laptop HP" to the variable productname.
4. lblans.Text = productname;
This displays the value of productname inside the lblans label.
Simple idea:
Create variable → Give it a value → Display the value
productname → "laptop HP" → lblans


# Screen 3String Concatenation

This C# code demonstrates string concatenation, which means joining two or more strings together using the + operator.

It combines "zada" and "abdullahi" into one string and displays the result in a message box.


# Screen4 Variable Data Types in C#

This code demonstrates how to declare variables using different data types:

int – stores whole numbers.

double – stores decimal numbers and integer.

decimal – stores precise decimal values, commonly used for int.


# Screen5 Explicit Conversion in 

This example demonstrates explicit type conversion using a cast operator. It converts a `decimal` value (2.3) into an `int`, resulting in 2.


##screnshot6
int hight = 170; → Creates an integer variable called hight and stores the value 170.
hight.ToString() → Converts the number 170 from an integer to a string (text).
lbll.Text = ... → Displays 170 inside the label lbll.
Result: The label shows 170.int widht = 27; → Creates an integer variable called widht and stores 27.
widht.ToString() → Converts 27 into text.
MessageBox.Show(...) → Shows the value in a message box.
Result: A message box displays 27.int cardid = 154; → Creates an integer variable called cardid and stores 154.
string ouput → Creates a string variable called ouput.
"your cardid is:" + cardid → Combines the text with the number.ToString() is used when you want to convert a number into text.



##screenshot 7
int avrage (n1 + n2) / 3; should be:
int avrage = (n1 + n2) / 3;
Explanation
try
try means: “Try to run this code.”
If an error happens, C# will go to the catch section.
int n1 = int.Parse(btt.Text);
This takes the text from btt, converts it from string to integer, and stores it in n1.
int n2 = int.Parse(btnint.Text);
This does the same thing for btnint and stores the number in n2.
int avrage = (n1 + n2) / 3;
This adds n1 and n2, then divides the result by 3, and stores the answer in avrage.
Note: If you are calculating the average of two numbers, you normally divide by 2, not 3.
MessageBox.Show(avrage.ToString());
This converts avrage to text and displays the result in a MessageBox.
catch
catch
{
    MessageBox.Show("PLEASE ENTER RIGHT INFO:");
}
If the user enters something that is not a number, int.Parse() causes an error, and catch displays:
"PLEASE ENTER RIGHT INFO"
Simple meaning
Input → Convert to number → Calculate → Show result
Also, this part:
private void btt_Click_1(object sender, EventArgs e)