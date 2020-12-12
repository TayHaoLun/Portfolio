#include <stdio.h>
#include<conio.h>
#include<math.h>
#include<stdlib.h>
#include<ctype.h>
// you may include other header file or define constant 


void Horoscope(int month, int date) {

	if (month == 1 && date >= 21 && date <= 31)
	{
		printf(" Your Horoscope is Aquarius\n");
	}
	else if (month == 2 && date >= 1 && date <= 19)
	{
		printf(" Your Horoscope is Aquarius\n");
	}
	else if (month == 2 && date >= 20 && date <= 28)
	{
		printf(" Your Horoscope is Pisces\n");
	}
	else if (month == 3 && date >= 1 && date <= 20)
	{
		printf(" Your Horoscope is Pisces\n");
	}
	else if (month == 3 && date >= 21 && date <= 31)
	{
		printf(" Your Horoscope is Aries\n");
	}
	else if (month == 4 && date >= 1 && date <= 20)
	{
		printf(" Your Horoscope is Aries\n");
	}
	else if (month == 4 && date >= 21 && date <= 30)
	{
		printf(" Your Horoscope is Taurus\n");
	}
	else if (month == 5 && date >= 1 && date <= 21)
	{
		printf(" Your Horoscope is Taurus\n");
	}
	else if (month == 5 && date >= 22 && date <= 31)
	{
		printf(" Your Horoscope is Gemini\n");
	}
	else if (month == 6 && date >= 1 && date <= 21)
	{
		printf(" Your Horoscope is Gemini\n");
	}
	else if (month == 6 && date >= 22 && date <= 30)
	{
		printf(" Your Horoscope is Cancer\n");
	}
	else if (month == 7 && date >= 1 && date <= 22)
	{
		printf(" Your Horoscope is Cancer\n");
	}
	else if (month == 7 && date >= 23 && date <= 31)
	{
		printf(" Your Horoscope is Leo\n");
	}
	else if (month == 8 && date >= 1 && date <= 23)
	{
		printf(" Your Horoscope is Leo\n");
	}
	else if (month == 8 && date >= 24 && date <= 31)
	{
		printf(" Your Horoscope is Virgo\n");
	}
	else if (month == 9 && date >= 1 && date <= 23)
	{
		printf(" Your Horoscope is Virgo\n");
	}
	else if (month == 9 && date >= 24 && date <= 30)
	{
		printf(" Your Horoscope is Libra\n");
	}
	else if (month == 10 && date >= 1 && date <= 23)
	{
		printf(" Your Horoscope is Libra\n");
	}
	else if (month == 10 && date >= 24 && date <= 31)
	{
		printf(" Your Horoscope is Scorpio\n");
	}
	else if (month == 11 && date >= 1 && date <= 22)
	{
		printf(" Your Horoscope is Scorpio\n");
	}
	else if (month == 11 && date >= 23 && date <= 30)
	{
		printf(" Your Horoscope is Sagittarius\n");
	}
	else if (month == 12 && date >= 1 && date <= 21)
	{
		printf(" Your Horoscope is Sagittarius\n");
	}
	else if (month == 12 && date >= 22 && date <= 31)
	{
		printf(" Your Horoscope is Capricorn\n");
	}
	else if (month == 1 && date >= 1 && date <= 19)
	{
		printf(" Your Horoscope is Capricorn\n");
	}
	else
	{
		printf(" There is no horoscope for this, try again\n");
	}
}

void Zodiac(int year) {
	int zodiac;
	zodiac = year % 12;          /* Computes remainder */

	if (zodiac == 0)
	{
		printf("Your Chinese Zodiac is the Monkey.");
	}
	else if (zodiac == 1)
	{
		printf("Your Chinese Zodiac is the Rooster.");
	}
	else if (zodiac == 2)
	{
		printf("Your Chinese Zodiac is the Dog.");
	}
	else if (zodiac == 3)
	{
		printf("Your Chinese Zodiac is the Pig.");
	}
	else if (zodiac == 4)
	{
		printf("Your Chinese Zodiac is the Rat.");
	}
	else if (zodiac == 5)
	{
		printf("\nYour Chinese Zodiac is the Ox.");
	}
	else if (zodiac == 6)
	{
		printf("Your Chinese Zodiac is the Tiger.");
	}
	else if (zodiac == 7)
	{
		printf("Your Chinese Zodiac is the Rabbit.");
	}
	else if (zodiac == 8)
	{
		printf("Your Chinese Zodiac is the Dragon.");
	}
	else if (zodiac == 9)
	{
		printf("Your Chinese Zodiac is the Snake.");
	}
	else if (zodiac == 10)
	{
		printf("Your Chinese Zodiac is the Horse.");
	}
	else if (zodiac == 11)
	{
		printf("Your Chinese Zodiac is the Goat.");
	}
}

void main(void)
{
	int count = 0, date, month, birthyear;
	int choice;
	do {
		printf("1.What your Horoscope?\n");
		printf("2.What your Zodiac?\n");
		printf("3.Exit\n");
		printf("Enter your choice:");
		scanf_s("%d", &choice);
		switch (choice)
		{
		case 1:
			printf("Enter date(1-31):");
			scanf_s("%d", &date);
			printf("Enter month(number 1-12):");
			scanf_s("%d", &month);
			Horoscope(month, date);
			break;

		case 2: printf("Enter the year you are born:");
			scanf_s("%d", &birthyear);
			Zodiac(birthyear);
			break;

		case 3:
			printf("Have a nice day!");
			exit(0);

		}
	} while (choice != 3);
}
