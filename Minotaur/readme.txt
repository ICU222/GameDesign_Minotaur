ReadMe about files

 Contact me if you don't understand anything.
=======================================
How to use :
	1. download this directory[Minotaur] in Github
	2. open unity hub or unity engine
	3. open project -> click this directory
=======================================
Before we start
	- THIS FILES IS MADE IN VERSION Unity 2021.2.2f1
	- I use some unity asset : Invector-3rdPersonController ( free version )
	- But I changed many things so it will not be a matter

=======================================
How tp play << add 11/15
	- At first, you can see nothing but floor and humanoid
	- click ▶ button
	- then there will be a maze and you will be in the maze

========================================
Description of this files :

1. Project files Overview :
	[Project]
		[Project] - [Assets] - [Invector-3rdPersonController_LITE] - [ Invetor_BasicLocomotion ]

	In Invetor_BasicLocomotion, ( you can open this dir in unity )
	[Hierarchy]
		ㄴLevel				- here's a maze
		ㄴThirdPersonController_LITE	- here's a player
		ㄴThirdPersonCamera_LITE		- here's a view of camera

2. some description of other files :
	[Project]
	[Assets] - [prefabs] - cell : one cell for making a maze
	[Assets] - [scripts] - Cell.cs, Mazegenerator.cs : C# files for making a maze
	[Assets] - [prefabs] - wall2, floorgrass : texture for wall and floor << add in 11/14, 11/15

=======================================
what has been changed
	- add maze		11/13
	- add texture of wall	11/14
	- add texture of floor and change the start location of humanoid	11/15
	