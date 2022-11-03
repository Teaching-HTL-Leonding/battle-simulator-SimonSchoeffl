const int PIRATE = 1;
const int STONE_CHEWER = 2;
const int GHOST_WARRIOR = 3;
const int OUTWORLDER = 4;
const int MONSTER_KNIGHT = 5;
const int DARK_GOBLIN = 6;

const int PIRATE_HEALTH = 20;
const int PIRATE_ATTACK = 3;
const int PIRATE_SPEED = 3;
const int PIRATE_ARMOR = 3;

const int STONE_CHEWER_HEALTH = 50;
const int STONE_CHEWER_ATTACK = 10;
const int STONE_CHEWER_SPEED = 1;
const int STONE_CHEWER_ARMOR = 1;

const int GHOST_WARRIOR_HEALTH = 20;
const int GHOST_WARRIOR_ATTACK = 2;
const int GHOST_WARRIOR_SPEED = 5;
const int GHOST_WARRIOR_ARMOR = 2;

const int OUTWORLDER_HEALTH = 15;
const int OUTWORLDER_ATTACK = 2;
const int OUTWORLDER_SPEED = 1;
const int OUTWORLDER_ARMOR = 2;

const int MONSTER_KNIGHT_HEALTH = 15;
const int MONSTER_KNIGHT_ATTACK = 4;
const int MONSTER_KNIGHT_SPEED = 3;
const int MONSTER_KNIGHT_ARMOR = 3;

const int DARK_GOBLIN_HEALTH = 10;
const int DARK_GOBLIN_ATTACK = 1;
const int DARK_GOBLIN_SPEED = 2;
const int DARK_GOBLIN_ARMOR = 8;

Console.WriteLine("PLAYER1, which character would you like to choose PIRATE(1), STONE_CHEWER(2), GHOST_WARRIOR(3), OUTWORLDER(4), MONSTER_KNIGHT(5) or DARK_GOBLIN(6)?");
int PLAYER1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("PLAYER2, which character would you like to choose PIRATE(1), STONE_CHEWER(2), GHOST_WARRIOR(3), OUTWORLDER(4), MONSTER_KNIGHT(5) or DARK_GOBLIN(6)?");
int PLAYER2 = int.Parse(Console.ReadLine()!);

int health1 = 0;
int health2 = 0;
int attack1 = 0;
int attack2 = 0;
int speed1 = 0;
int speed2 = 0;
int armor1 = 0;
int armor2 = 0;

switch (PLAYER1)
{
    case 1: 
    health1 = PIRATE_HEALTH;
    attack1 = PIRATE_ATTACK;
    speed1 = PIRATE_SPEED;
    armor1 = PIRATE_ARMOR;
    break;

    case 2:
    health1 = STONE_CHEWER_HEALTH;
    attack1 = STONE_CHEWER_ATTACK;
    speed1 = STONE_CHEWER_SPEED;
    armor1 = STONE_CHEWER_ARMOR;
    break;

    case 3:
    health1 = GHOST_WARRIOR_HEALTH;
    attack1 = GHOST_WARRIOR_ATTACK;
    speed1 = GHOST_WARRIOR_SPEED;
    armor1 = GHOST_WARRIOR_ARMOR;
    break;

    case 4: 
    health1 = OUTWORLDER_HEALTH;
    attack1 = OUTWORLDER_ATTACK;
    speed1 = OUTWORLDER_SPEED;
    armor1 = OUTWORLDER_ARMOR;
    break;

    case 5:
    health1 = MONSTER_KNIGHT_HEALTH;
    attack1 = MONSTER_KNIGHT_ATTACK;
    speed1 = MONSTER_KNIGHT_SPEED;
    armor1 = MONSTER_KNIGHT_ARMOR;
    break;

    case 6:
    health1 = DARK_GOBLIN_HEALTH;
    attack1 = DARK_GOBLIN_ATTACK;
    speed1 = DARK_GOBLIN_SPEED;
    armor1 = DARK_GOBLIN_ARMOR;
    break;
}    

switch (PLAYER2)
{
    case 1: 
    health2 = PIRATE_HEALTH;
    attack2 = PIRATE_ATTACK;
    speed2 = PIRATE_SPEED;
    armor2 = PIRATE_ARMOR;
    break;

    case 2:
    health2 = STONE_CHEWER_HEALTH;
    attack2 = STONE_CHEWER_ATTACK;
    speed2 = STONE_CHEWER_SPEED;
    armor2 = STONE_CHEWER_ARMOR;
    break;

    case 3:
    health2 = GHOST_WARRIOR_HEALTH;
    attack2 = GHOST_WARRIOR_ATTACK;
    speed2 = GHOST_WARRIOR_SPEED;
    armor2 = GHOST_WARRIOR_ARMOR;
    break;

    case 4: 
    health2 = OUTWORLDER_HEALTH;
    attack2 = OUTWORLDER_ATTACK;
    speed2 = OUTWORLDER_SPEED;
    armor2 = OUTWORLDER_ARMOR;
    break;

    case 5:
    health2 = MONSTER_KNIGHT_HEALTH;
    attack2 = MONSTER_KNIGHT_ATTACK;
    speed2 = MONSTER_KNIGHT_SPEED;
    armor2 = MONSTER_KNIGHT_ARMOR;
    break;

    case 6:
    health2 = DARK_GOBLIN_HEALTH;
    attack2 = DARK_GOBLIN_ATTACK;
    speed2 = DARK_GOBLIN_SPEED;
    armor2 = DARK_GOBLIN_ARMOR;
    break;
}    

while (health1 > 0 && health2 > 0)
{
    health1 -= attack2 * speed2 * armor2;
    health2 -= attack1 * speed1 * armor1;
}
   
if (health1 > 0)
{
    Console.WriteLine("PLAYER1 win");
}
else if (health1 < 0)
{
    Console.WriteLine("PLAYER2 win");
}
else if (health1 ==0 && health2 == 0)
{
    Console.WriteLine("Nobody win");
}