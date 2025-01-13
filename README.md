<h2>Description</h2>
<p>The <strong>Number Guessing Game</strong> is a fun and interactive console-based program written in C#. It challenges the player to guess a randomly generated number between 1 and 100. The game provides feedback after each guess (“Too high” or “Too low”) and tracks the number of attempts it takes to guess correctly. Players can also view the current high score and try to beat it.</p>

<hr>

<h2>Features</h2>
<ul>
    <li><strong>Random Number Generation</strong>: The game generates a random number between 1 and 100 for each round.</li>
    <li><strong>Feedback System</strong>: Provides feedback on whether the player’s guess is too high, too low, or correct.</li>
    <li><strong>High Score Tracking</strong>: Keeps track of the lowest number of attempts required to guess correctly and displays the high score.</li>
    <li><strong>Replay Option</strong>: Players can choose to play multiple rounds.</li>
    <li><strong>Check High Score</strong>: Players can view the current high score without starting a new game.</li>
</ul>

<hr>

<h2>Prerequisites</h2>
<ul>
    <li>Visual Studio Code (VS Code)</li>
    <li>C# Extension for VS Code</li>
    <li>.NET SDK (version 5.0 or higher)</li>
</ul>

<h3>Installation</h3>
<ol>
    <li>Install <a href="https://code.visualstudio.com/">VS Code</a>.</li>
    <li>Install the C# extension in VS Code.</li>
    <li>Download and install the <a href="https://dotnet.microsoft.com/download">.NET SDK</a>.</li>
</ol>

<hr>

<h2>How to Run</h2>
<ol>
    <li>Clone or download the project to your local machine.</li>
    <li>Open the project folder in VS Code.</li>
    <li>Open the terminal and navigate to the project directory.</li>
    <li>Run the following command:
        <pre><code>dotnet run</code></pre>
    </li>
</ol>

<hr>

<h2>Usage</h2>
<ol>
    <li>Choose between playing the game or checking the high score.</li>
    <li>If you select to play, guess a number between 1 and 100.</li>
    <li>Use the feedback provided (“Too high” or “Too low”) to refine your guesses.</li>
    <li>Try to guess the number in as few attempts as possible to set a new high score.</li>
    <li>View the high score at any time during the game.</li>
    <li>Replay as many times as you like!</li>
</ol>

<hr>

<h2>Code Breakdown</h2>
<ul>
    <li><strong>Random Number Generation</strong>: Generates a target number using <code>Random.Next()</code>.</li>
    <li><strong>Input Validation</strong>: Ensures the input is a valid integer between 1 and 100.</li>
    <li><strong>Game Loop</strong>: Repeats the process until the correct number is guessed.</li>
    <li><strong>High Score Tracking</strong>: Updates the high score if the player beats the current record.</li>
    <li><strong>Replay Option</strong>: Allows players to restart the game or exit.</li>
</ul>

<hr>

<h2>Enhancements</h2>
<p>Consider adding the following features:</p>
<ul>
    <li><strong>Difficulty Levels</strong>: Adjust the range of random numbers based on selected difficulty.</li>
    <li><strong>Persistent High Score</strong>: Save and load the high score using file I/O.</li>
    <li><strong>Leaderboard</strong>: Store multiple high scores and display them.</li>
    <li><strong>User Customization</strong>: Allow players to set their name and display it with the high score.</li>
</ul>

<hr>

<h2>License</h2>
<p>This project is open-source and available under the <a href="https://opensource.org/licenses/MIT">MIT License</a>. Feel free to use, modify, and distribute it.</p>

<hr>

<h2>Acknowledgements</h2>
<p>Inspired by beginner programming exercises and built to make learning C# fun and engaging. Happy coding!</p>
