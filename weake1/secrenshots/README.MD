##screnshot1

This code is used to display a message box on the screen.
MessageBox → a Windows Forms class used to show a message box.
Show() → displays the message box.
"Welcome CA242" → the message that appears inside the box.
; → ends the statement.
Simple meaning:
When the code runs, a small pop-up window appears showing:
Welcome CA242



##screenshot 2


application.
answerlebal → the name of the Label.
.Text → represents the text displayed by the Label.
= → assigns a value to the Label.
"Jamhuriya University" → the text that will be displayed.
; → ends the statement.



##screenshot 3


private void → creates a method that does not return a value.
logobicurebox_Click → runs when we click the logo PictureBox.
object sender → identifies the object that caused the event.
EventArgs e → contains information about the event.
MessageBox.Show() → displays a message box.
"WELCOME MY FRIEND" → is the message that appears.
Result: When you click the logo, "WELCOME MY FRIEND" appears
studentpicturebox_Click → runs when we click the student picture.
studentpicturebox.Visible → controls whether the picture is visible.
= false → hides the picture.
Result: When you click the student picture, the picture disappears.



##screenshot 4

This is an event handler. It runs when the user clicks the Show button.
private → this method can only be used inside the current class.
void → the method does not return a value.
showbotton_Click → the name of the method.
object sender → represents the object that triggered the event, usually the button.
EventArgs e → contains information about the event.
2. // Sequential Execution of Statements
This is a comment. It tells us that the statements are executed one after another, from top to bottom.
3. cradbackpicture.Visible = true;
This makes the cradbackpicture visible.
Visible → controls whether the picture is shown.
true → show it.
4. cradefacepicture.Visible = false;
This makes the cradefacepicture invisible/hidden.
Visible → controls visibility.
false → hide it.




##screenshot 5
this.Close();
this.Close(); is used in C# Windows Forms to close the current form (window).
this → refers to the current form.
. → accesses a method or property of the form.
Close() → closes the current form.
; → ends the statement.