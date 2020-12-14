#include <stdio.h>
#include<conio.h>
#include<math.h>
#include<stdlib.h>
#include<ctype.h>

void Menu() {
	printf("1.Add 1 to 8 points?\n");
	printf("2.Add 4 to 7?\n");
	printf("3.Exit\n");
	printf("Goal is to reach as close to 20 points without going over.\n");
	printf("Enter your choice:");
}

void Quasar(int bet) {
	if (bet == 15) {
		printf("You have won 25 points.Would you like to stop?\n");
	}
	if (bet == 16) {
		printf("You have won 50 points.Would you like to stop?\n");
	}
	if (bet == 17) {
		printf("You have won 100 points.Would you like to stop?\n");
	}
	if (bet == 18) {
		printf("You have won 125 points.Would you like to stop?\n");
	}
	if (bet == 19) {
		printf("You have won 150 points.Would you like to stop?\n");
	}
	if (bet == 20) {
		printf("You have won 200 points.Would you like to stop?\n");
	}
	if (bet > 20) {
		printf("You lose! Would you like to play again?\n");
		Menu();
	}
}
int OnetoFive() {
	int startpts;
	startpts = rand() % 5 + 1;
	return startpts;
}

int OnetoEight() {
	int addpoint;
	addpoint = rand() % 8 + 1;
	return addpoint;
}

int FourtoSeven() {
	int addpoint1;
	addpoint1 = rand() % 7 + 4;
	return addpoint1;
}

int main(void)
{
	int points;
	int choice;
	points = OnetoFive();
	printf("Starting Points: %d\n", points);
	do {
		Menu();
		scanf_s("%d", &choice);
		switch (choice) 
		{
		case 1:points+=OnetoEight();
			printf("Current Points: %d\n", points);
			Quasar(points);
			break;

		case 2:points+=FourtoSeven();
			printf("Current Points: %d\n", points);
			Quasar(points);
			break;
		case 3:
			printf("Have a nice day!");
			exit(0);
			break;
		}
	} while (choice != 3);
}