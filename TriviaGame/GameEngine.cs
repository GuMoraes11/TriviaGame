// Purpose: Core logic of the trivia game — handles the game loop, question selection, answer processing, and score tracking.
// 
// Responsibilities / Features:
// 
// StartGame()
// 
// Shows the main menu to the user (difficulty selection or quit).
// 
// Loops until the player quits.
// 
// Calls LoadQuestions() and PlayQuestions() for the selected difficulty.
// 
// LoadQuestions(string difficulty)
// 
// Reads the JSON file for the selected difficulty from the Data/ folder.
// 
// Deserializes the JSON into List<Question>.
// 
// Handles missing files gracefully.
// 
// PlayQuestions()
// 
// Randomly selects questions from the loaded list.
// 
// Displays the question text and options (A-D) on the console.
// 
// Accepts user input for answers.
// 
// Validates input (A-D only).
// 
// Calls answer checking logic and updates the score.
// 
// Moves to the next question until all are answered.
// 
// Answer Processing
// 
// Compares user input with the correct answer.
// 
// Displays feedback: “Correct!” or “Wrong! Correct answer was …”.
// 
// Maintains score counter.
// 
// ShowResult()
// 
// After all questions are answered:
// 
// Displays Game Over message.
// 
// Shows the player’s score (e.g., 7 / 10).
// 
// Pauses before returning to the main menu.
// 
// Interactions:
// 
// Uses Question objects for question data.
// 
// Reads JSON files from Data/ folder.
// 
// Drives the main game loop logic.
// 
// Notes:
// 
// Handles all user interactions via console.
// 
// Encapsulates all gameplay functionality.
// 
// Could be extended later for categories, multiple rounds, or timed questions.