# QuizGame App
### Challenge Your Knowledge, Play and Win

🎮 Quiz Game App
Quiz Game App is a multiplayer quiz game developed using C# WinForms with Socket programming. It allows multiple players to connect over a LAN network, answer questions, and compete in real-time to test their knowledge. ✨

#  📋 Features

### 🔐 Login & Registration
- Users can sign up with their name, email, password, username, and optional avatar.
- Email validation and password confirmation are required during registration.
- Registered users can log in using their email and password.
- Forgot password? The system sends it to the registered email for easy recovery.

[![Picture1.png](https://i.postimg.cc/bY40zr1J/Picture1.png)](https://postimg.cc/JtcHx16V)
[![Picture2.png](https://i.postimg.cc/mkSFNL6x/Picture2.png)](https://postimg.cc/PvPxdjjK)
[![Picture3.png](https://i.postimg.cc/cHxWtdYt/Picture3.png)](https://postimg.cc/rdP3vXfq)


### 🎮 Join the Game
- Players can join scheduled quiz shows at specific times.
- The system will send reminders before the quiz show starts.
  
[![Picture4.png](https://i.postimg.cc/g0qXPkmx/Picture4.png)](https://postimg.cc/nsrc4xsx)

### 🧠 Answering Questions:
- Once the quiz starts, the system sends questions to all players.
- Each question has a countdown timer. Players must choose one of four answer options within the time limit.
- Incorrect or unanswered questions will result in elimination.
- Eliminated players can still view the upcoming questions but cannot participate.

[![Picture5.png](https://i.postimg.cc/jdtRGQC4/Picture5.png)](https://postimg.cc/Bt7WFFTj)
[![Picture6.png](https://i.postimg.cc/HkKDsQWK/Picture6.png)](https://postimg.cc/NK1Pd2H7)

### 💰Betting System
- Players can place bets before each question to increase the thrill and competitiveness.
- Betting options include: 2X, 75%, 50%, and 25%.
- Player scores are multiplied or reduced based on the chosen bet if the answer is correct or incorrect.

### 🏆Results Notification
- At the end of each quiz show, the system calculates and announces player results.
- Players are notified of their final score and ranking.
- The winner is determined based on the highest score.
- Rewards are announced and distributed to the winner according to the game rules.

[![Picture8.png](https://i.postimg.cc/cLDYKLPP/Picture8.png)](https://postimg.cc/21Z3Mrkx)
[![Picture9.png](https://i.postimg.cc/hGkXxzsZ/Picture9.png)](https://postimg.cc/XZgN6vT9)

## 🛠️ Technologies Used
- C# WinForms – For building the desktop user interface.
- .NET Framework – Core framework for Windows application development.
- TCP Socket Programming – Enables real-time communication between players over LAN.
- Multithreading – Manages multiple player connections simultaneously.
- JSON – For structured data exchange between client and server.
- Microsoft Visual Studio – Main development environment.
- SQL Server – Stores user accounts, quiz data, scores, and game history



## 🚀 Installation

**Requirements:**

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) with **.NET Desktop Development** workload  
- Windows OS  
- Optional: SQL Server Express (for `.mdf` database support)

**Steps to Run:**

1. Clone the repository:

    ```bash
    git clone https://github.com/daiduoq-ng/socket-quiz-game-app.git
    ```

2. Open the solution file:  
   `SourceCode/NT106.sln` using **Visual Studio 2022**

3. **Update the connection string** in the `Connection.cs` file to match your database configuration. The database file `Database1.mdf` is already included in the project and is automatically imported.

    In `Connection.cs`, find the line defining the connection string:

    ```csharp
    public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
    ```

    - The `Database1.mdf` file is already imported into the project. You don't need to do anything extra to import it.
    - Ensure that the connection string is set correctly to point to `Database1.mdf` in your project directory.

4. Build the project by pressing `Ctrl+Shift+B` or clicking **Build** > **Build Solution**

5. Press `F5` or click **Start** to run the application

### ✅ Option 2: Run the Executable

1. Navigate to:  
   `SourceCode/NT106/bin/Release/NT106.exe`  
2. Double-click to launch the app directly (no build required)
