// See https://aka.ms/new-console-template for more information
using DeckOfCardsApp;
using DeckOfCardsApp.Models;

// Create an instance of the utils class. This has all of the functions required to print to the console.
// Enabling the card class to be ported to other types of applications.
var utils = new Utilities();

// Below you will find a sample usage. 
Console.WriteLine("Welcome to the deck of cards simulator.");
Console.WriteLine("");
Console.WriteLine("Creating a new Deck of cards, and printing the initial order.");
Console.WriteLine("");

var firstDeck = new Deck();
utils.Print(firstDeck.Cards, "Printing");

Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Shuffling and printing again.");
Console.WriteLine("");

utils.Print(firstDeck.Shuffle(), "Prining");

Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("Creating a new Deck of cards and dealing 1.");

Console.WriteLine("");

var secondDeck = new Deck();
utils.Print(secondDeck.Deal(1));

Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Creating a new Deck of cards and dealing all of the cards.");
Console.WriteLine("");
var thirdDeck = new Deck();
utils.Print(thirdDeck.Deal(52));


Console.WriteLine("");
Console.WriteLine("");


Console.ReadLine();






