Feature: DeckLength
	In order to verify the number of decks can vary
	As a person seeking random numbers
	I want to be able to draw from multiple decks

@mytag
Scenario: Two Decks
	Given I have two decks
	When I see how many cards I have
	Then the result should be 104
