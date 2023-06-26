## UC7

### Application description
The .net 6 solution to test ConvertStudents from StudentConverter and CalculateScore from PlayerAnalyzer classes.

#### ConvertStudents
The ConvertStudents function is a method in the StudentConverter class that takes a list of Student objects as input and processes it according to a set of rules, returning a modified list of Student objects.

The function uses the Select function from LINQ to loop through each Student object in the list and perform certain modifications based on the student's age and grade:

If the student's grade is above 90:

If the student's age is less than 21, the function marks the student as 'Exceptional' by setting the Exceptional property to true.
If the student's age is 21 or above, the function marks the student as being on the 'Honor Roll' by setting the HonorRoll property to true.
If the student's grade is between 71 and 90 (inclusive), the function marks the student as having 'Passed' by setting the Passed property to true.

If the student's grade is 70 or less, the function marks the student as not having 'Passed' by setting the Passed property to false.

The resulting list of modified Student objects is then returned by the function.

It's important to note that if the input list is null, the function will throw an ArgumentNullException.

#### CalculateScore
The CalculateScore function in the PlayerAnalyzer class is used to calculate a "score" or contribution for a list of players. This score is based on each player's age, experience, and their set of skills.

Here's a detailed breakdown of how the score is calculated:

It calculates an average skill value for each player by summing up all their skill values and dividing by the number of skills they have.

Then, it computes a raw contribution for each player by multiplying their age, experience, and the calculated average skill value.

It applies some additional rules based on the player's age and experience:

If a player is younger than 18 years, their contribution is reduced by half (multiplied by 0.5).
If a player has more than 10 years of experience, their contribution is increased by 20% (multiplied by 1.2).
It sums up the final contributions of all the players to get the total score.

If a player doesn't have any skills (the Skills property is null), the function throws an exception.

If the list of players is empty, the function returns a score of 0.

This calculated score can be used to evaluate or compare the overall proficiency or value of a group of players, considering their age, experience, and skills.

### Application setup
1. Install .NET 6 SDK
1. Clone the app repository with your favorite GIT client
1. Run ```dotnet test {path to TestProject1.csproj}```