# DeckOfCards
A deck of cards application that allows users to deal between one and all of the cards and shuffle the deck

The program.cs class contains a sample use of the Deck class. 
You can instantiate a new deck. The constructor sets up the deck of cards. The deck class exposes the shuffle method and the deal method. 
Shuffle will shuffle the deck and return the list of cards. The deal method takes in the number of cards to deal and returns a return result list of cards. 
If there are not enough cards in the deck it will return an error message. 
If there are enough cards the success property will be set to true, and the cards will be returned in the data property. 