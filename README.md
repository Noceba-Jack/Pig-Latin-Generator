# Pig Latin Generator

This is a simple Pig Latin generator written in C#. It takes an English sentence as input and encodes it into Pig Latin.

## How It Works

1. The program splits the input sentence into words.
2. For each word:
   - If the first letter is a vowel (a, e, i, o, u), it appends 'way' to the end of the word.
   - Otherwise, it moves the first letter to the end of the word and adds 'ay'.
3. The program then joins the modified words back together to form the Pig Latin sentence.

## Example

Input: "nevermind youve got them"
Output: "evermindnay ouveyay otgay hemtay"

## Usage

1. Clone this repository.
2. Compile the C# code.
3. Run the program and input an English sentence to see the Pig Latin version.
