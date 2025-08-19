// Purpose: Represents a single trivia question and its data.
// 
// Responsibilities:
// 
// Stores the question text (question).
// 
// Stores the answer options (options) as a dictionary mapping A–D to strings.
// 
// Stores the correct answer prefix (answer).
// 
// Interactions:
// 
// GameEngine reads JSON files and deserializes them into a list of Question objects.
// 
// Used whenever a question is displayed or checked for correctness.
// 
// Notes:
// 
// Simple data-only class (a POCO in C#).
// 
// No methods; just stores question data for the engine to use.