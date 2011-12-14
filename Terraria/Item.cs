using System;
using Hooks;

namespace Terraria
{
    public class Item
    {
        public static int potionDelay = 3600;
        public static int[] headType = new int[44];
        public static int[] bodyType = new int[25];
        public static int[] legType = new int[24];
        public bool accessory;
        public bool active;
        public int alpha;
        public int ammo;
        public bool autoReuse;
        public int axe;
        public bool beingGrabbed;
        public int bodySlot = -1;
        public int buffTime;
        public int buffType;
        public bool buy;
        public bool buyOnce;
        public bool channel;
        public Color color;
        public bool consumable;
        public int createTile = -1;
        public int createWall = -1;
        public int crit;
        public int damage;
        public int defense;
        public int hammer;
        public int headSlot = -1;
        public int healLife;
        public int healMana;
        public int height;
        public int holdStyle;
        public int keepTime;
        public float knockBack;
        public bool lavaWet;
        public int legSlot = -1;
        public int lifeRegen;
        public bool magic;
        public int mana;
        public int manaIncrease;
        public bool material;
        public int maxStack;
        public bool mech;
        public bool melee;
        public string name;
        public int netID;
        public int noGrabDelay;
        public bool noMelee;
        public bool noUseGraphic;
        public bool noWet;
        public int ownIgnore = -1;
        public int ownTime;
        public int owner = 255;
        public int pick;
        public int placeStyle;
        public Vector2 position;
        public bool potion;
        public byte prefix;
        public bool ranged;
        public int rare;
        public int release;
        public int reuseDelay;
        public float scale = 1f;
        public int shoot;
        public float shootSpeed;
        public bool social;
        public int spawnTime;
        public int stack;
        public int tileBoost;
        public string toolTip;
        public string toolTip2;
        public int type;
        public int useAmmo;
        public int useAnimation;
        public int useSound;
        public int useStyle;
        public int useTime;
        public bool useTurn;
        public int value;
        public bool vanity;
        public Vector2 velocity;
        public bool wet;
        public byte wetCount;
        public int width;
        public bool wornArmor;

        public bool Prefix(int pre)
        {
            if (pre == 0 || type == 0)
            {
                return false;
            }
            int num = pre;
            float num2 = 1f;
            float num3 = 1f;
            float num4 = 1f;
            float num5 = 1f;
            float num6 = 1f;
            float num7 = 1f;
            int num8 = 0;
            bool flag = true;
            while (flag)
            {
                num2 = 1f;
                num3 = 1f;
                num4 = 1f;
                num5 = 1f;
                num6 = 1f;
                num7 = 1f;
                num8 = 0;
                flag = false;
                if (num == -1 && Main.rand.Next(4) == 0)
                {
                    num = 0;
                }
                if (pre < -1)
                {
                    num = -1;
                }
                if (num == -1 || num == -2 || num == -3)
                {
                    if (type == 1 || type == 4 || type == 6 || type == 7 || type == 10 || type == 24 || type == 45 || type == 46 || type == 103 || type == 104 || type == 121 || type == 122 || type == 155 || type == 190 || type == 196 || type == 198 || type == 199 || type == 200 || type == 201 || type == 202 || type == 203 || type == 204 || type == 213 || type == 217 || type == 273 || type == 367 || type == 368 || type == 426 || type == 482 || type == 483 || type == 484)
                    {
                        int num9 = Main.rand.Next(40);
                        if (num9 == 0)
                        {
                            num = 1;
                        }
                        if (num9 == 1)
                        {
                            num = 2;
                        }
                        if (num9 == 2)
                        {
                            num = 3;
                        }
                        if (num9 == 3)
                        {
                            num = 4;
                        }
                        if (num9 == 4)
                        {
                            num = 5;
                        }
                        if (num9 == 5)
                        {
                            num = 6;
                        }
                        if (num9 == 6)
                        {
                            num = 7;
                        }
                        if (num9 == 7)
                        {
                            num = 8;
                        }
                        if (num9 == 8)
                        {
                            num = 9;
                        }
                        if (num9 == 9)
                        {
                            num = 10;
                        }
                        if (num9 == 10)
                        {
                            num = 11;
                        }
                        if (num9 == 11)
                        {
                            num = 12;
                        }
                        if (num9 == 12)
                        {
                            num = 13;
                        }
                        if (num9 == 13)
                        {
                            num = 14;
                        }
                        if (num9 == 14)
                        {
                            num = 15;
                        }
                        if (num9 == 15)
                        {
                            num = 36;
                        }
                        if (num9 == 16)
                        {
                            num = 37;
                        }
                        if (num9 == 17)
                        {
                            num = 38;
                        }
                        if (num9 == 18)
                        {
                            num = 53;
                        }
                        if (num9 == 19)
                        {
                            num = 54;
                        }
                        if (num9 == 20)
                        {
                            num = 55;
                        }
                        if (num9 == 21)
                        {
                            num = 39;
                        }
                        if (num9 == 22)
                        {
                            num = 40;
                        }
                        if (num9 == 23)
                        {
                            num = 56;
                        }
                        if (num9 == 24)
                        {
                            num = 41;
                        }
                        if (num9 == 25)
                        {
                            num = 57;
                        }
                        if (num9 == 26)
                        {
                            num = 42;
                        }
                        if (num9 == 27)
                        {
                            num = 43;
                        }
                        if (num9 == 28)
                        {
                            num = 44;
                        }
                        if (num9 == 29)
                        {
                            num = 45;
                        }
                        if (num9 == 30)
                        {
                            num = 46;
                        }
                        if (num9 == 31)
                        {
                            num = 47;
                        }
                        if (num9 == 32)
                        {
                            num = 48;
                        }
                        if (num9 == 33)
                        {
                            num = 49;
                        }
                        if (num9 == 34)
                        {
                            num = 50;
                        }
                        if (num9 == 35)
                        {
                            num = 51;
                        }
                        if (num9 == 36)
                        {
                            num = 59;
                        }
                        if (num9 == 37)
                        {
                            num = 60;
                        }
                        if (num9 == 38)
                        {
                            num = 61;
                        }
                        if (num9 == 39)
                        {
                            num = 81;
                        }
                    }
                    else
                    {
                        if (type == 162 || type == 163 || type == 220 || type == 274 || type == 277 || type == 280 || type == 383 || type == 384 || type == 385 || type == 386 || type == 387 || type == 388 || type == 389 || type == 390 || type == 406 || type == 537 || type == 550 || type == 579)
                        {
                            int num10 = Main.rand.Next(14);
                            if (num10 == 0)
                            {
                                num = 36;
                            }
                            if (num10 == 1)
                            {
                                num = 37;
                            }
                            if (num10 == 2)
                            {
                                num = 38;
                            }
                            if (num10 == 3)
                            {
                                num = 53;
                            }
                            if (num10 == 4)
                            {
                                num = 54;
                            }
                            if (num10 == 5)
                            {
                                num = 55;
                            }
                            if (num10 == 6)
                            {
                                num = 39;
                            }
                            if (num10 == 7)
                            {
                                num = 40;
                            }
                            if (num10 == 8)
                            {
                                num = 56;
                            }
                            if (num10 == 9)
                            {
                                num = 41;
                            }
                            if (num10 == 10)
                            {
                                num = 57;
                            }
                            if (num10 == 11)
                            {
                                num = 59;
                            }
                            if (num10 == 12)
                            {
                                num = 60;
                            }
                            if (num10 == 13)
                            {
                                num = 61;
                            }
                        }
                        else
                        {
                            if (type == 39 || type == 44 || type == 95 || type == 96 || type == 98 || type == 99 || type == 120 || type == 164 || type == 197 || type == 219 || type == 266 || type == 281 || type == 434 || type == 435 || type == 436 || type == 481 || type == 506 || type == 533 || type == 534 || type == 578)
                            {
                                int num11 = Main.rand.Next(36);
                                if (num11 == 0)
                                {
                                    num = 16;
                                }
                                if (num11 == 1)
                                {
                                    num = 17;
                                }
                                if (num11 == 2)
                                {
                                    num = 18;
                                }
                                if (num11 == 3)
                                {
                                    num = 19;
                                }
                                if (num11 == 4)
                                {
                                    num = 20;
                                }
                                if (num11 == 5)
                                {
                                    num = 21;
                                }
                                if (num11 == 6)
                                {
                                    num = 22;
                                }
                                if (num11 == 7)
                                {
                                    num = 23;
                                }
                                if (num11 == 8)
                                {
                                    num = 24;
                                }
                                if (num11 == 9)
                                {
                                    num = 25;
                                }
                                if (num11 == 10)
                                {
                                    num = 58;
                                }
                                if (num11 == 11)
                                {
                                    num = 36;
                                }
                                if (num11 == 12)
                                {
                                    num = 37;
                                }
                                if (num11 == 13)
                                {
                                    num = 38;
                                }
                                if (num11 == 14)
                                {
                                    num = 53;
                                }
                                if (num11 == 15)
                                {
                                    num = 54;
                                }
                                if (num11 == 16)
                                {
                                    num = 55;
                                }
                                if (num11 == 17)
                                {
                                    num = 39;
                                }
                                if (num11 == 18)
                                {
                                    num = 40;
                                }
                                if (num11 == 19)
                                {
                                    num = 56;
                                }
                                if (num11 == 20)
                                {
                                    num = 41;
                                }
                                if (num11 == 21)
                                {
                                    num = 57;
                                }
                                if (num11 == 22)
                                {
                                    num = 42;
                                }
                                if (num11 == 23)
                                {
                                    num = 43;
                                }
                                if (num11 == 24)
                                {
                                    num = 44;
                                }
                                if (num11 == 25)
                                {
                                    num = 45;
                                }
                                if (num11 == 26)
                                {
                                    num = 46;
                                }
                                if (num11 == 27)
                                {
                                    num = 47;
                                }
                                if (num11 == 28)
                                {
                                    num = 48;
                                }
                                if (num11 == 29)
                                {
                                    num = 49;
                                }
                                if (num11 == 30)
                                {
                                    num = 50;
                                }
                                if (num11 == 31)
                                {
                                    num = 51;
                                }
                                if (num11 == 32)
                                {
                                    num = 59;
                                }
                                if (num11 == 33)
                                {
                                    num = 60;
                                }
                                if (num11 == 34)
                                {
                                    num = 61;
                                }
                                if (num11 == 35)
                                {
                                    num = 82;
                                }
                            }
                            else
                            {
                                if (type == 64 || type == 65 || type == 112 || type == 113 || type == 127 || type == 157 || type == 218 || type == 272 || type == 494 || type == 495 || type == 496 || type == 514 || type == 517 || type == 518 || type == 519)
                                {
                                    int num12 = Main.rand.Next(36);
                                    if (num12 == 0)
                                    {
                                        num = 26;
                                    }
                                    if (num12 == 1)
                                    {
                                        num = 27;
                                    }
                                    if (num12 == 2)
                                    {
                                        num = 28;
                                    }
                                    if (num12 == 3)
                                    {
                                        num = 29;
                                    }
                                    if (num12 == 4)
                                    {
                                        num = 30;
                                    }
                                    if (num12 == 5)
                                    {
                                        num = 31;
                                    }
                                    if (num12 == 6)
                                    {
                                        num = 32;
                                    }
                                    if (num12 == 7)
                                    {
                                        num = 33;
                                    }
                                    if (num12 == 8)
                                    {
                                        num = 34;
                                    }
                                    if (num12 == 9)
                                    {
                                        num = 35;
                                    }
                                    if (num12 == 10)
                                    {
                                        num = 52;
                                    }
                                    if (num12 == 11)
                                    {
                                        num = 36;
                                    }
                                    if (num12 == 12)
                                    {
                                        num = 37;
                                    }
                                    if (num12 == 13)
                                    {
                                        num = 38;
                                    }
                                    if (num12 == 14)
                                    {
                                        num = 53;
                                    }
                                    if (num12 == 15)
                                    {
                                        num = 54;
                                    }
                                    if (num12 == 16)
                                    {
                                        num = 55;
                                    }
                                    if (num12 == 17)
                                    {
                                        num = 39;
                                    }
                                    if (num12 == 18)
                                    {
                                        num = 40;
                                    }
                                    if (num12 == 19)
                                    {
                                        num = 56;
                                    }
                                    if (num12 == 20)
                                    {
                                        num = 41;
                                    }
                                    if (num12 == 21)
                                    {
                                        num = 57;
                                    }
                                    if (num12 == 22)
                                    {
                                        num = 42;
                                    }
                                    if (num12 == 23)
                                    {
                                        num = 43;
                                    }
                                    if (num12 == 24)
                                    {
                                        num = 44;
                                    }
                                    if (num12 == 25)
                                    {
                                        num = 45;
                                    }
                                    if (num12 == 26)
                                    {
                                        num = 46;
                                    }
                                    if (num12 == 27)
                                    {
                                        num = 47;
                                    }
                                    if (num12 == 28)
                                    {
                                        num = 48;
                                    }
                                    if (num12 == 29)
                                    {
                                        num = 49;
                                    }
                                    if (num12 == 30)
                                    {
                                        num = 50;
                                    }
                                    if (num12 == 31)
                                    {
                                        num = 51;
                                    }
                                    if (num12 == 32)
                                    {
                                        num = 59;
                                    }
                                    if (num12 == 33)
                                    {
                                        num = 60;
                                    }
                                    if (num12 == 34)
                                    {
                                        num = 61;
                                    }
                                    if (num12 == 35)
                                    {
                                        num = 83;
                                    }
                                }
                                else
                                {
                                    if (type == 55 || type == 119 || type == 191 || type == 284)
                                    {
                                        int num13 = Main.rand.Next(14);
                                        if (num13 == 0)
                                        {
                                            num = 36;
                                        }
                                        if (num13 == 1)
                                        {
                                            num = 37;
                                        }
                                        if (num13 == 2)
                                        {
                                            num = 38;
                                        }
                                        if (num13 == 3)
                                        {
                                            num = 53;
                                        }
                                        if (num13 == 4)
                                        {
                                            num = 54;
                                        }
                                        if (num13 == 5)
                                        {
                                            num = 55;
                                        }
                                        if (num13 == 6)
                                        {
                                            num = 39;
                                        }
                                        if (num13 == 7)
                                        {
                                            num = 40;
                                        }
                                        if (num13 == 8)
                                        {
                                            num = 56;
                                        }
                                        if (num13 == 9)
                                        {
                                            num = 41;
                                        }
                                        if (num13 == 10)
                                        {
                                            num = 57;
                                        }
                                        if (num13 == 11)
                                        {
                                            num = 59;
                                        }
                                        if (num13 == 12)
                                        {
                                            num = 60;
                                        }
                                        if (num13 == 13)
                                        {
                                            num = 61;
                                        }
                                    }
                                    else
                                    {
                                        if (!accessory || type == 267 || type == 562 || type == 563 || type == 564 || type == 565 || type == 566 || type == 567 || type == 568 || type == 569 || type == 570 || type == 571 || type == 572 || type == 573 || type == 574 || type == 576)
                                        {
                                            return false;
                                        }
                                        num = Main.rand.Next(62, 81);
                                    }
                                }
                            }
                        }
                    }
                }
                if (pre == -3)
                {
                    return true;
                }
                if (pre == -1 && (num == 7 || num == 8 || num == 9 || num == 10 || num == 11 || num == 22 || num == 23 || num == 24 || num == 29 || num == 30 || num == 31 || num == 39 || num == 40 || num == 56 || num == 41 || num == 47 || num == 48 || num == 49) && Main.rand.Next(3) != 0)
                {
                    num = 0;
                }
                if (num == 1)
                {
                    num5 = 1.12f;
                }
                else
                {
                    if (num == 2)
                    {
                        num5 = 1.18f;
                    }
                    else
                    {
                        if (num == 3)
                        {
                            num2 = 1.05f;
                            num8 = 2;
                            num5 = 1.05f;
                        }
                        else
                        {
                            if (num == 4)
                            {
                                num2 = 1.1f;
                                num5 = 1.1f;
                                num3 = 1.1f;
                            }
                            else
                            {
                                if (num == 5)
                                {
                                    num2 = 1.15f;
                                }
                                else
                                {
                                    if (num == 6)
                                    {
                                        num2 = 1.1f;
                                    }
                                    else
                                    {
                                        if (num == 81)
                                        {
                                            num3 = 1.15f;
                                            num2 = 1.15f;
                                            num8 = 5;
                                            num4 = 0.9f;
                                            num5 = 1.1f;
                                        }
                                        else
                                        {
                                            if (num == 7)
                                            {
                                                num5 = 0.82f;
                                            }
                                            else
                                            {
                                                if (num == 8)
                                                {
                                                    num3 = 0.85f;
                                                    num2 = 0.85f;
                                                    num5 = 0.87f;
                                                }
                                                else
                                                {
                                                    if (num == 9)
                                                    {
                                                        num5 = 0.9f;
                                                    }
                                                    else
                                                    {
                                                        if (num == 10)
                                                        {
                                                            num2 = 0.85f;
                                                        }
                                                        else
                                                        {
                                                            if (num == 11)
                                                            {
                                                                num4 = 1.1f;
                                                                num3 = 0.9f;
                                                                num5 = 0.9f;
                                                            }
                                                            else
                                                            {
                                                                if (num == 12)
                                                                {
                                                                    num3 = 1.1f;
                                                                    num2 = 1.05f;
                                                                    num5 = 1.1f;
                                                                    num4 = 1.15f;
                                                                }
                                                                else
                                                                {
                                                                    if (num == 13)
                                                                    {
                                                                        num3 = 0.8f;
                                                                        num2 = 0.9f;
                                                                        num5 = 1.1f;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (num == 14)
                                                                        {
                                                                            num3 = 1.15f;
                                                                            num4 = 1.1f;
                                                                        }
                                                                        else
                                                                        {
                                                                            if (num == 15)
                                                                            {
                                                                                num3 = 0.9f;
                                                                                num4 = 0.85f;
                                                                            }
                                                                            else
                                                                            {
                                                                                if (num == 16)
                                                                                {
                                                                                    num2 = 1.1f;
                                                                                    num8 = 3;
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (num == 17)
                                                                                    {
                                                                                        num4 = 0.85f;
                                                                                        num6 = 1.1f;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if (num == 18)
                                                                                        {
                                                                                            num4 = 0.9f;
                                                                                            num6 = 1.15f;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            if (num == 19)
                                                                                            {
                                                                                                num3 = 1.15f;
                                                                                                num6 = 1.05f;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                if (num == 20)
                                                                                                {
                                                                                                    num3 = 1.05f;
                                                                                                    num6 = 1.05f;
                                                                                                    num2 = 1.1f;
                                                                                                    num4 = 0.95f;
                                                                                                    num8 = 2;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    if (num == 21)
                                                                                                    {
                                                                                                        num3 = 1.15f;
                                                                                                        num2 = 1.1f;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        if (num == 82)
                                                                                                        {
                                                                                                            num3 = 1.15f;
                                                                                                            num2 = 1.15f;
                                                                                                            num8 = 5;
                                                                                                            num4 = 0.9f;
                                                                                                            num6 = 1.1f;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            if (num == 22)
                                                                                                            {
                                                                                                                num3 = 0.9f;
                                                                                                                num6 = 0.9f;
                                                                                                                num2 = 0.85f;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                if (num == 23)
                                                                                                                {
                                                                                                                    num4 = 1.15f;
                                                                                                                    num6 = 0.9f;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    if (num == 24)
                                                                                                                    {
                                                                                                                        num4 = 1.1f;
                                                                                                                        num3 = 0.8f;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        if (num == 25)
                                                                                                                        {
                                                                                                                            num4 = 1.1f;
                                                                                                                            num2 = 1.15f;
                                                                                                                            num8 = 1;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            if (num == 58)
                                                                                                                            {
                                                                                                                                num4 = 0.85f;
                                                                                                                                num2 = 0.85f;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                if (num == 26)
                                                                                                                                {
                                                                                                                                    num7 = 0.85f;
                                                                                                                                    num2 = 1.1f;
                                                                                                                                }
                                                                                                                                else
                                                                                                                                {
                                                                                                                                    if (num == 27)
                                                                                                                                    {
                                                                                                                                        num7 = 0.85f;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        if (num == 28)
                                                                                                                                        {
                                                                                                                                            num7 = 0.85f;
                                                                                                                                            num2 = 1.15f;
                                                                                                                                            num3 = 1.05f;
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                        {
                                                                                                                                            if (num == 83)
                                                                                                                                            {
                                                                                                                                                num3 = 1.15f;
                                                                                                                                                num2 = 1.15f;
                                                                                                                                                num8 = 5;
                                                                                                                                                num4 = 0.9f;
                                                                                                                                                num7 = 0.9f;
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                            {
                                                                                                                                                if (num == 29)
                                                                                                                                                {
                                                                                                                                                    num7 = 1.1f;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    if (num == 30)
                                                                                                                                                    {
                                                                                                                                                        num7 = 1.2f;
                                                                                                                                                        num2 = 0.9f;
                                                                                                                                                    }
                                                                                                                                                    else
                                                                                                                                                    {
                                                                                                                                                        if (num == 31)
                                                                                                                                                        {
                                                                                                                                                            num3 = 0.9f;
                                                                                                                                                            num2 = 0.9f;
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                        {
                                                                                                                                                            if (num == 32)
                                                                                                                                                            {
                                                                                                                                                                num7 = 1.15f;
                                                                                                                                                                num2 = 1.1f;
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                            {
                                                                                                                                                                if (num == 33)
                                                                                                                                                                {
                                                                                                                                                                    num7 = 1.1f;
                                                                                                                                                                    num3 = 1.1f;
                                                                                                                                                                    num4 = 0.9f;
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                {
                                                                                                                                                                    if (num == 34)
                                                                                                                                                                    {
                                                                                                                                                                        num7 = 0.9f;
                                                                                                                                                                        num3 = 1.1f;
                                                                                                                                                                        num4 = 1.1f;
                                                                                                                                                                        num2 = 1.1f;
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                    {
                                                                                                                                                                        if (num == 35)
                                                                                                                                                                        {
                                                                                                                                                                            num7 = 1.2f;
                                                                                                                                                                            num2 = 1.15f;
                                                                                                                                                                            num3 = 1.15f;
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                        {
                                                                                                                                                                            if (num == 52)
                                                                                                                                                                            {
                                                                                                                                                                                num7 = 0.9f;
                                                                                                                                                                                num2 = 0.9f;
                                                                                                                                                                                num4 = 0.9f;
                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                            {
                                                                                                                                                                                if (num == 36)
                                                                                                                                                                                {
                                                                                                                                                                                    num8 = 3;
                                                                                                                                                                                }
                                                                                                                                                                                else
                                                                                                                                                                                {
                                                                                                                                                                                    if (num == 37)
                                                                                                                                                                                    {
                                                                                                                                                                                        num2 = 1.1f;
                                                                                                                                                                                        num8 = 3;
                                                                                                                                                                                        num3 = 1.1f;
                                                                                                                                                                                    }
                                                                                                                                                                                    else
                                                                                                                                                                                    {
                                                                                                                                                                                        if (num == 38)
                                                                                                                                                                                        {
                                                                                                                                                                                            num3 = 1.15f;
                                                                                                                                                                                        }
                                                                                                                                                                                        else
                                                                                                                                                                                        {
                                                                                                                                                                                            if (num == 53)
                                                                                                                                                                                            {
                                                                                                                                                                                                num2 = 1.1f;
                                                                                                                                                                                            }
                                                                                                                                                                                            else
                                                                                                                                                                                            {
                                                                                                                                                                                                if (num == 54)
                                                                                                                                                                                                {
                                                                                                                                                                                                    num3 = 1.15f;
                                                                                                                                                                                                }
                                                                                                                                                                                                else
                                                                                                                                                                                                {
                                                                                                                                                                                                    if (num == 55)
                                                                                                                                                                                                    {
                                                                                                                                                                                                        num3 = 1.15f;
                                                                                                                                                                                                        num2 = 1.05f;
                                                                                                                                                                                                    }
                                                                                                                                                                                                    else
                                                                                                                                                                                                    {
                                                                                                                                                                                                        if (num == 59)
                                                                                                                                                                                                        {
                                                                                                                                                                                                            num3 = 1.15f;
                                                                                                                                                                                                            num2 = 1.15f;
                                                                                                                                                                                                            num8 = 5;
                                                                                                                                                                                                        }
                                                                                                                                                                                                        else
                                                                                                                                                                                                        {
                                                                                                                                                                                                            if (num == 60)
                                                                                                                                                                                                            {
                                                                                                                                                                                                                num2 = 1.15f;
                                                                                                                                                                                                                num8 = 5;
                                                                                                                                                                                                            }
                                                                                                                                                                                                            else
                                                                                                                                                                                                            {
                                                                                                                                                                                                                if (num == 61)
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    num8 = 5;
                                                                                                                                                                                                                }
                                                                                                                                                                                                                else
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    if (num == 39)
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        num2 = 0.7f;
                                                                                                                                                                                                                        num3 = 0.8f;
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    else
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        if (num == 40)
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            num2 = 0.85f;
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                        else
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            if (num == 56)
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                num3 = 0.8f;
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            else
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                if (num == 41)
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    num3 = 0.85f;
                                                                                                                                                                                                                                    num2 = 0.9f;
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    if (num == 57)
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        num3 = 0.9f;
                                                                                                                                                                                                                                        num2 = 1.18f;
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        if (num == 42)
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            num4 = 0.9f;
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            if (num == 43)
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                num2 = 1.1f;
                                                                                                                                                                                                                                                num4 = 0.9f;
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                if (num == 44)
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    num4 = 0.9f;
                                                                                                                                                                                                                                                    num8 = 3;
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    if (num == 45)
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        num4 = 0.95f;
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        if (num == 46)
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            num8 = 3;
                                                                                                                                                                                                                                                            num4 = 0.94f;
                                                                                                                                                                                                                                                            num2 = 1.07f;
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            if (num == 47)
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                num4 = 1.15f;
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                if (num == 48)
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    num4 = 1.2f;
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    if (num == 49)
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        num4 = 1.08f;
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        if (num == 50)
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            num2 = 0.8f;
                                                                                                                                                                                                                                                                            num4 = 1.15f;
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            if (num == 51)
                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                num3 = 0.9f;
                                                                                                                                                                                                                                                                                num4 = 0.9f;
                                                                                                                                                                                                                                                                                num2 = 1.05f;
                                                                                                                                                                                                                                                                                num8 = 2;
                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                }
                                                                                                                                                                                                            }
                                                                                                                                                                                                        }
                                                                                                                                                                                                    }
                                                                                                                                                                                                }
                                                                                                                                                                                            }
                                                                                                                                                                                        }
                                                                                                                                                                                    }
                                                                                                                                                                                }
                                                                                                                                                                            }
                                                                                                                                                                        }
                                                                                                                                                                    }
                                                                                                                                                                }
                                                                                                                                                            }
                                                                                                                                                        }
                                                                                                                                                    }
                                                                                                                                                }
                                                                                                                                            }
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (num2 != 1f && Math.Round((damage*num2)) == damage)
                {
                    flag = true;
                    num = -1;
                }
                if (num4 != 1f && Math.Round((useAnimation*num4)) == useAnimation)
                {
                    flag = true;
                    num = -1;
                }
                if (num7 != 1f && Math.Round((mana*num7)) == mana)
                {
                    flag = true;
                    num = -1;
                }
                if (num3 != 1f && knockBack == 0f)
                {
                    flag = true;
                    num = -1;
                }
                if (pre == -2 && num == 0)
                {
                    num = -1;
                    flag = true;
                }
            }
            damage = (int) Math.Round((damage*num2));
            useAnimation = (int) Math.Round((useAnimation*num4));
            useTime = (int) Math.Round((useTime*num4));
            reuseDelay = (int) Math.Round((reuseDelay*num4));
            mana = (int) Math.Round((mana*num7));
            knockBack *= num3;
            scale *= num5;
            shootSpeed *= num6;
            crit += num8;
            float num14 = 1f*num2*(2f - num4)*(2f - num7)*num5*num3*num6*(1f + crit*0.02f);
            if (num == 62 || num == 69 || num == 73 || num == 77)
            {
                num14 *= 1.05f;
            }
            if (num == 63 || num == 70 || num == 74 || num == 78 || num == 67)
            {
                num14 *= 1.1f;
            }
            if (num == 64 || num == 71 || num == 75 || num == 79 || num == 66)
            {
                num14 *= 1.15f;
            }
            if (num == 65 || num == 72 || num == 76 || num == 80 || num == 68)
            {
                num14 *= 1.2f;
            }
            if (num14 >= 1.2)
            {
                rare += 2;
            }
            else
            {
                if (num14 >= 1.05)
                {
                    rare++;
                }
                else
                {
                    if (num14 <= 0.8)
                    {
                        rare -= 2;
                    }
                    else
                    {
                        if (num14 <= 0.95)
                        {
                            rare--;
                        }
                    }
                }
            }
            if (rare < -1)
            {
                rare = -1;
            }
            if (rare > 6)
            {
                rare = 6;
            }
            num14 *= num14;
            value = (int) (value*num14);
            prefix = (byte) num;
            return true;
        }

        public string AffixName()
        {
            string text = "";
            if (prefix == 1)
            {
                text = "Large";
            }
            if (prefix == 2)
            {
                text = "Massive";
            }
            if (prefix == 3)
            {
                text = "Dangerous";
            }
            if (prefix == 4)
            {
                text = "Savage";
            }
            if (prefix == 5)
            {
                text = "Sharp";
            }
            if (prefix == 6)
            {
                text = "Pointy";
            }
            if (prefix == 7)
            {
                text = "Tiny";
            }
            if (prefix == 8)
            {
                text = "Terrible";
            }
            if (prefix == 9)
            {
                text = "Small";
            }
            if (prefix == 10)
            {
                text = "Dull";
            }
            if (prefix == 11)
            {
                text = "Unhappy";
            }
            if (prefix == 12)
            {
                text = "Bulky";
            }
            if (prefix == 13)
            {
                text = "Shameful";
            }
            if (prefix == 14)
            {
                text = "Heavy";
            }
            if (prefix == 15)
            {
                text = "Light";
            }
            if (prefix == 16)
            {
                text = "Sighted";
            }
            if (prefix == 17)
            {
                text = "Rapid";
            }
            if (prefix == 18)
            {
                text = "Hasty";
            }
            if (prefix == 19)
            {
                text = "Intimidating";
            }
            if (prefix == 20)
            {
                text = "Deadly";
            }
            if (prefix == 21)
            {
                text = "Staunch";
            }
            if (prefix == 22)
            {
                text = "Awful";
            }
            if (prefix == 23)
            {
                text = "Lethargic";
            }
            if (prefix == 24)
            {
                text = "Awkward";
            }
            if (prefix == 25)
            {
                text = "Powerful";
            }
            if (prefix == 58)
            {
                text = "Frenzying";
            }
            if (prefix == 26)
            {
                text = "Mystic";
            }
            if (prefix == 27)
            {
                text = "Adept";
            }
            if (prefix == 28)
            {
                text = "Masterful";
            }
            if (prefix == 29)
            {
                text = "Inept";
            }
            if (prefix == 30)
            {
                text = "Ignorant";
            }
            if (prefix == 31)
            {
                text = "Deranged";
            }
            if (prefix == 32)
            {
                text = "Intense";
            }
            if (prefix == 33)
            {
                text = "Taboo";
            }
            if (prefix == 34)
            {
                text = "Celestial";
            }
            if (prefix == 35)
            {
                text = "Furious";
            }
            if (prefix == 52)
            {
                text = "Manic";
            }
            if (prefix == 36)
            {
                text = "Keen";
            }
            if (prefix == 37)
            {
                text = "Superior";
            }
            if (prefix == 38)
            {
                text = "Forceful";
            }
            if (prefix == 53)
            {
                text = "Hurtful";
            }
            if (prefix == 54)
            {
                text = "Strong";
            }
            if (prefix == 55)
            {
                text = "Unpleasant";
            }
            if (prefix == 39)
            {
                text = "Broken";
            }
            if (prefix == 40)
            {
                text = "Damaged";
            }
            if (prefix == 56)
            {
                text = "Weak";
            }
            if (prefix == 41)
            {
                text = "Shoddy";
            }
            if (prefix == 57)
            {
                text = "Ruthless";
            }
            if (prefix == 42)
            {
                text = "Quick";
            }
            if (prefix == 43)
            {
                text = "Deadly";
            }
            if (prefix == 44)
            {
                text = "Agile";
            }
            if (prefix == 45)
            {
                text = "Nimble";
            }
            if (prefix == 46)
            {
                text = "Murderous";
            }
            if (prefix == 47)
            {
                text = "Slow";
            }
            if (prefix == 48)
            {
                text = "Sluggish";
            }
            if (prefix == 49)
            {
                text = "Lazy";
            }
            if (prefix == 50)
            {
                text = "Annoying";
            }
            if (prefix == 51)
            {
                text = "Nasty";
            }
            if (prefix == 59)
            {
                text = "Godly";
            }
            if (prefix == 60)
            {
                text = "Demonic";
            }
            if (prefix == 61)
            {
                text = "Zealous";
            }
            if (prefix == 62)
            {
                text = "Hard";
            }
            if (prefix == 63)
            {
                text = "Guarding";
            }
            if (prefix == 64)
            {
                text = "Armored";
            }
            if (prefix == 65)
            {
                text = "Warding";
            }
            if (prefix == 66)
            {
                text = "Arcane";
            }
            if (prefix == 67)
            {
                text = "Precise";
            }
            if (prefix == 68)
            {
                text = "Lucky";
            }
            if (prefix == 69)
            {
                text = "Jagged";
            }
            if (prefix == 70)
            {
                text = "Spiked";
            }
            if (prefix == 71)
            {
                text = "Angry";
            }
            if (prefix == 72)
            {
                text = "Menacing";
            }
            if (prefix == 73)
            {
                text = "Brisk";
            }
            if (prefix == 74)
            {
                text = "Fleeting";
            }
            if (prefix == 75)
            {
                text = "Hasty";
            }
            if (prefix == 76)
            {
                text = "Quick";
            }
            if (prefix == 77)
            {
                text = "Wild";
            }
            if (prefix == 78)
            {
                text = "Rash";
            }
            if (prefix == 79)
            {
                text = "Intrepid";
            }
            if (prefix == 80)
            {
                text = "Violent";
            }
            if (prefix == 81)
            {
                text = "Legendary";
            }
            if (prefix == 82)
            {
                text = "Unreal";
            }
            if (prefix == 83)
            {
                text = "Mythical";
            }
            string result = name;
            if (text != "")
            {
                result = text + " " + name;
            }
            return result;
        }

        public void RealSetDefaults(string ItemName)
        {
            name = "";
            bool flag = false;
            switch (ItemName)
            {
                case "Gold Pickaxe":
                    SetDefaults(1, false);
                    color = new Color(210, 190, 0, 100);
                    useTime = 17;
                    pick = 55;
                    useAnimation = 20;
                    scale = 1.05f;
                    damage = 6;
                    value = 10000;
                    toolTip = "Can mine Meteorite";
                    netID = -1;
                    break;
                case "Gold Broadsword":
                    SetDefaults(4, false);
                    color = new Color(210, 190, 0, 100);
                    useAnimation = 20;
                    damage = 13;
                    scale = 1.05f;
                    value = 9000;
                    netID = -2;
                    break;
                case "Gold Shortsword":
                    SetDefaults(6, false);
                    color = new Color(210, 190, 0, 100);
                    damage = 11;
                    useAnimation = 11;
                    scale = 0.95f;
                    value = 7000;
                    netID = -3;
                    break;
                case "Gold Axe":
                    SetDefaults(10, false);
                    color = new Color(210, 190, 0, 100);
                    useTime = 18;
                    axe = 11;
                    useAnimation = 26;
                    scale = 1.15f;
                    damage = 7;
                    value = 8000;
                    netID = -4;
                    break;
                case "Gold Hammer":
                    SetDefaults(7, false);
                    color = new Color(210, 190, 0, 100);
                    useAnimation = 28;
                    useTime = 23;
                    scale = 1.25f;
                    damage = 9;
                    hammer = 55;
                    value = 8000;
                    netID = -5;
                    break;
                case "Gold Bow":
                    SetDefaults(99, false);
                    useAnimation = 26;
                    useTime = 26;
                    color = new Color(210, 190, 0, 100);
                    damage = 11;
                    value = 7000;
                    netID = -6;
                    break;
                case "Silver Pickaxe":
                    SetDefaults(1, false);
                    color = new Color(180, 180, 180, 100);
                    useTime = 11;
                    pick = 45;
                    useAnimation = 19;
                    scale = 1.05f;
                    damage = 6;
                    value = 5000;
                    netID = -7;
                    break;
                case "Silver Broadsword":
                    SetDefaults(4, false);
                    color = new Color(180, 180, 180, 100);
                    useAnimation = 21;
                    damage = 11;
                    value = 4500;
                    netID = -8;
                    break;
                case "Silver Shortsword":
                    SetDefaults(6, false);
                    color = new Color(180, 180, 180, 100);
                    damage = 9;
                    useAnimation = 12;
                    scale = 0.95f;
                    value = 3500;
                    netID = -9;
                    break;
                case "Silver Axe":
                    SetDefaults(10, false);
                    color = new Color(180, 180, 180, 100);
                    useTime = 18;
                    axe = 10;
                    useAnimation = 26;
                    scale = 1.15f;
                    damage = 6;
                    value = 4000;
                    netID = -10;
                    break;
                case "Silver Hammer":
                    SetDefaults(7, false);
                    color = new Color(180, 180, 180, 100);
                    useAnimation = 29;
                    useTime = 19;
                    scale = 1.25f;
                    damage = 9;
                    hammer = 45;
                    value = 4000;
                    netID = -11;
                    break;
                case "Silver Bow":
                    SetDefaults(99, false);
                    useAnimation = 27;
                    useTime = 27;
                    color = new Color(180, 180, 180, 100);
                    damage = 9;
                    value = 3500;
                    netID = -12;
                    break;
                case "Copper Pickaxe":
                    SetDefaults(1, false);
                    color = new Color(180, 100, 45, 80);
                    useTime = 15;
                    pick = 35;
                    useAnimation = 23;
                    damage = 4;
                    scale = 0.9f;
                    tileBoost = -1;
                    value = 500;
                    netID = -13;
                    break;
                case "Copper Broadsword":
                    SetDefaults(4, false);
                    color = new Color(180, 100, 45, 80);
                    useAnimation = 23;
                    damage = 8;
                    value = 450;
                    netID = -14;
                    break;
                case "Copper Shortsword":
                    SetDefaults(6, false);
                    color = new Color(180, 100, 45, 80);
                    damage = 5;
                    useAnimation = 13;
                    scale = 0.8f;
                    value = 350;
                    netID = -15;
                    break;
                case "Copper Axe":
                    SetDefaults(10, false);
                    color = new Color(180, 100, 45, 80);
                    useTime = 21;
                    axe = 7;
                    useAnimation = 30;
                    scale = 1f;
                    damage = 3;
                    tileBoost = -1;
                    value = 400;
                    netID = -16;
                    break;
                case "Copper Hammer":
                    SetDefaults(7, false);
                    color = new Color(180, 100, 45, 80);
                    useAnimation = 33;
                    useTime = 23;
                    scale = 1.1f;
                    damage = 4;
                    hammer = 35;
                    tileBoost = -1;
                    value = 400;
                    netID = -17;
                    break;
                case "Copper Bow":
                    SetDefaults(99, false);
                    useAnimation = 29;
                    useTime = 29;
                    color = new Color(180, 100, 45, 80);
                    damage = 6;
                    value = 350;
                    netID = -18;
                    break;
                case "Blue Phasesaber":
                    SetDefaults(198, false);
                    damage = 41;
                    scale = 1.15f;
                    flag = true;
                    autoReuse = true;
                    useTurn = true;
                    rare = 4;
                    netID = -19;
                    break;
                case "Red Phasesaber":
                    SetDefaults(199, false);
                    damage = 41;
                    scale = 1.15f;
                    flag = true;
                    autoReuse = true;
                    useTurn = true;
                    rare = 4;
                    netID = -20;
                    break;
                case "Green Phasesaber":
                    SetDefaults(200, false);
                    damage = 41;
                    scale = 1.15f;
                    flag = true;
                    autoReuse = true;
                    useTurn = true;
                    rare = 4;
                    netID = -21;
                    break;
                case "Purple Phasesaber":
                    SetDefaults(201, false);
                    damage = 41;
                    scale = 1.15f;
                    flag = true;
                    autoReuse = true;
                    useTurn = true;
                    rare = 4;
                    netID = -22;
                    break;
                case "White Phasesaber":
                    SetDefaults(202, false);
                    damage = 41;
                    scale = 1.15f;
                    flag = true;
                    autoReuse = true;
                    useTurn = true;
                    rare = 4;
                    netID = -23;
                    break;
                case "Yellow Phasesaber":
                    SetDefaults(203, false);
                    damage = 41;
                    scale = 1.15f;
                    flag = true;
                    autoReuse = true;
                    useTurn = true;
                    rare = 4;
                    netID = -24;
                    break;
                default:
                    if (ItemName != "")
                    {
                        for (int i = 0; i < 586; i++)
                        {
                            if (Main.itemName[i] == ItemName)
                            {
                                SetDefaults(i, false);
                                checkMat();
                                return;
                            }
                        }
                        name = "";
                        stack = 0;
                        type = 0;
                    }
                    break;
            }
            if (type != 0)
            {
                if (flag)
                {
                    material = false;
                }
                else
                {
                    checkMat();
                }
                name = ItemName;
            }
        }

        public bool checkMat()
        {
            if (type >= 71 && type <= 74)
            {
                material = false;
                return false;
            }
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                int num = 0;
                while (Main.recipe[i].requiredItem[num].type > 0)
                {
                    if (name == Main.recipe[i].requiredItem[num].name)
                    {
                        material = true;
                        return true;
                    }
                    num++;
                }
            }
            material = false;
            return false;
        }

        public void RealnetDefaults(int type)
        {
            if (type < 0)
            {
                if (type == -1)
                {
                    SetDefaults("Gold Pickaxe");
                    return;
                }
                if (type == -2)
                {
                    SetDefaults("Gold Broadsword");
                    return;
                }
                if (type == -3)
                {
                    SetDefaults("Gold Shortsword");
                    return;
                }
                if (type == -4)
                {
                    SetDefaults("Gold Axe");
                    return;
                }
                if (type == -5)
                {
                    SetDefaults("Gold Hammer");
                    return;
                }
                if (type == -6)
                {
                    SetDefaults("Gold Bow");
                    return;
                }
                if (type == -7)
                {
                    SetDefaults("Silver Pickaxe");
                    return;
                }
                if (type == -8)
                {
                    SetDefaults("Silver Broadsword");
                    return;
                }
                if (type == -9)
                {
                    SetDefaults("Silver Shortsword");
                    return;
                }
                if (type == -10)
                {
                    SetDefaults("Silver Axe");
                    return;
                }
                if (type == -11)
                {
                    SetDefaults("Silver Hammer");
                    return;
                }
                if (type == -12)
                {
                    SetDefaults("Silver Bow");
                    return;
                }
                if (type == -13)
                {
                    SetDefaults("Copper Pickaxe");
                    return;
                }
                if (type == -14)
                {
                    SetDefaults("Copper Broadsword");
                    return;
                }
                if (type == -15)
                {
                    SetDefaults("Copper Shortsword");
                    return;
                }
                if (type == -16)
                {
                    SetDefaults("Copper Axe");
                    return;
                }
                if (type == -17)
                {
                    SetDefaults("Copper Hammer");
                    return;
                }
                if (type == -18)
                {
                    SetDefaults("Copper Bow");
                    return;
                }
                if (type == -19)
                {
                    SetDefaults("Blue Phasesaber");
                    return;
                }
                if (type == -20)
                {
                    SetDefaults("Red Phasesaber");
                    return;
                }
                if (type == -21)
                {
                    SetDefaults("Green Phasesaber");
                    return;
                }
                if (type == -22)
                {
                    SetDefaults("Purple Phasesaber");
                    return;
                }
                if (type == -23)
                {
                    SetDefaults("White Phasesaber");
                    return;
                }
                if (type == -24)
                {
                    SetDefaults("Yellow Phasesaber");
                    return;
                }
            }
            else
            {
                SetDefaults(type, false);
            }
        }

        public void RealSetDefaults(int Type, bool noMatCheck = false)
        {
            if (Main.netMode == 1 || Main.netMode == 2)
            {
                owner = 255;
            }
            else
            {
                owner = Main.myPlayer;
            }
            netID = 0;
            prefix = 0;
            crit = 0;
            mech = false;
            reuseDelay = 0;
            melee = false;
            magic = false;
            ranged = false;
            placeStyle = 0;
            buffTime = 0;
            buffType = 0;
            material = false;
            noWet = false;
            vanity = false;
            mana = 0;
            wet = false;
            wetCount = 0;
            lavaWet = false;
            channel = false;
            manaIncrease = 0;
            release = 0;
            noMelee = false;
            noUseGraphic = false;
            lifeRegen = 0;
            shootSpeed = 0f;
            active = true;
            alpha = 0;
            ammo = 0;
            useAmmo = 0;
            autoReuse = false;
            accessory = false;
            axe = 0;
            healMana = 0;
            bodySlot = -1;
            legSlot = -1;
            headSlot = -1;
            potion = false;
            color = default(Color);
            consumable = false;
            createTile = -1;
            createWall = -1;
            damage = -1;
            defense = 0;
            hammer = 0;
            healLife = 0;
            holdStyle = 0;
            knockBack = 0f;
            maxStack = 1;
            pick = 0;
            rare = 0;
            scale = 1f;
            shoot = 0;
            stack = 1;
            toolTip = null;
            toolTip2 = null;
            tileBoost = 0;
            type = Type;
            useStyle = 0;
            useSound = 0;
            useTime = 100;
            useAnimation = 100;
            value = 0;
            useTurn = false;
            buy = false;
            switch (type)
            {
                case 0:
                    name = "";
                    stack = 0;
                    break;
                case 1:
                    name = "Iron Pickaxe";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 20;
                    useTime = 13;
                    autoReuse = true;
                    width = 24;
                    height = 28;
                    damage = 5;
                    pick = 40;
                    useSound = 1;
                    knockBack = 2f;
                    value = 2000;
                    melee = true;
                    break;
                case 2:
                    name = "Dirt Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 0;
                    width = 12;
                    height = 12;
                    break;
                case 3:
                    name = "Stone Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 1;
                    width = 12;
                    height = 12;
                    break;
                case 4:
                    name = "Iron Broadsword";
                    useStyle = 1;
                    useTurn = false;
                    useAnimation = 21;
                    useTime = 21;
                    width = 24;
                    height = 28;
                    damage = 10;
                    knockBack = 5f;
                    useSound = 1;
                    scale = 1f;
                    value = 1800;
                    melee = true;
                    break;
                case 5:
                    name = "Mushroom";
                    useStyle = 2;
                    useSound = 2;
                    useTurn = false;
                    useAnimation = 17;
                    useTime = 17;
                    width = 16;
                    height = 18;
                    healLife = 15;
                    maxStack = 99;
                    consumable = true;
                    potion = true;
                    value = 25;
                    break;
                case 6:
                    name = "Iron Shortsword";
                    useStyle = 3;
                    useTurn = false;
                    useAnimation = 12;
                    useTime = 12;
                    width = 24;
                    height = 28;
                    damage = 8;
                    knockBack = 4f;
                    scale = 0.9f;
                    useSound = 1;
                    useTurn = true;
                    value = 1400;
                    melee = true;
                    break;
                case 7:
                    name = "Iron Hammer";
                    autoReuse = true;
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 30;
                    useTime = 20;
                    hammer = 45;
                    width = 24;
                    height = 28;
                    damage = 7;
                    knockBack = 5.5f;
                    scale = 1.2f;
                    useSound = 1;
                    value = 1600;
                    melee = true;
                    break;
                case 8:
                    noWet = true;
                    name = "Torch";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    holdStyle = 1;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 4;
                    width = 10;
                    height = 12;
                    toolTip = "Provides light";
                    value = 50;
                    break;
                case 9:
                    name = "Wood";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 30;
                    width = 8;
                    height = 10;
                    break;
                case 10:
                    name = "Iron Axe";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 27;
                    knockBack = 4.5f;
                    useTime = 19;
                    autoReuse = true;
                    width = 24;
                    height = 28;
                    damage = 5;
                    axe = 9;
                    scale = 1.1f;
                    useSound = 1;
                    value = 1600;
                    melee = true;
                    break;
                case 11:
                    name = "Iron Ore";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 6;
                    width = 12;
                    height = 12;
                    value = 500;
                    break;
                case 12:
                    name = "Copper Ore";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 7;
                    width = 12;
                    height = 12;
                    value = 250;
                    break;
                case 13:
                    name = "Gold Ore";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 8;
                    width = 12;
                    height = 12;
                    value = 2000;
                    break;
                case 14:
                    name = "Silver Ore";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 9;
                    width = 12;
                    height = 12;
                    value = 1000;
                    break;
                case 15:
                    name = "Copper Watch";
                    width = 24;
                    height = 28;
                    accessory = true;
                    toolTip = "Tells the time";
                    value = 1000;
                    break;
                case 16:
                    name = "Silver Watch";
                    width = 24;
                    height = 28;
                    accessory = true;
                    toolTip = "Tells the time";
                    value = 5000;
                    break;
                case 17:
                    name = "Gold Watch";
                    width = 24;
                    height = 28;
                    accessory = true;
                    rare = 1;
                    toolTip = "Tells the time";
                    value = 10000;
                    break;
                case 18:
                    name = "Depth Meter";
                    width = 24;
                    height = 18;
                    accessory = true;
                    rare = 1;
                    toolTip = "Shows depth";
                    value = 10000;
                    break;
                case 19:
                    name = "Gold Bar";
                    width = 20;
                    height = 20;
                    maxStack = 99;
                    value = 6000;
                    break;
                case 20:
                    name = "Copper Bar";
                    width = 20;
                    height = 20;
                    maxStack = 99;
                    value = 750;
                    break;
                case 21:
                    name = "Silver Bar";
                    width = 20;
                    height = 20;
                    maxStack = 99;
                    value = 3000;
                    break;
                case 22:
                    name = "Iron Bar";
                    width = 20;
                    height = 20;
                    maxStack = 99;
                    value = 1500;
                    break;
                case 23:
                    name = "Gel";
                    width = 10;
                    height = 12;
                    maxStack = 250;
                    alpha = 175;
                    ammo = 23;
                    color = new Color(0, 80, 255, 100);
                    toolTip = "'Both tasty and flammable'";
                    value = 5;
                    break;
                case 24:
                    name = "Wooden Sword";
                    useStyle = 1;
                    useTurn = false;
                    useAnimation = 25;
                    width = 24;
                    height = 28;
                    damage = 7;
                    knockBack = 4f;
                    scale = 0.95f;
                    useSound = 1;
                    value = 100;
                    melee = true;
                    break;
                case 25:
                    name = "Wooden Door";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 10;
                    width = 14;
                    height = 28;
                    value = 200;
                    break;
                case 26:
                    name = "Stone Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 1;
                    width = 12;
                    height = 12;
                    break;
                case 27:
                    name = "Acorn";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 20;
                    width = 18;
                    height = 18;
                    value = 10;
                    break;
                case 28:
                    name = "Lesser Healing Potion";
                    useSound = 3;
                    healLife = 50;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    potion = true;
                    value = 300;
                    break;
                case 29:
                    name = "Life Crystal";
                    maxStack = 99;
                    consumable = true;
                    width = 18;
                    height = 18;
                    useStyle = 4;
                    useTime = 30;
                    useSound = 4;
                    useAnimation = 30;
                    toolTip = "Permanently increases maximum life by 20";
                    rare = 2;
                    value = 75000;
                    break;
                case 30:
                    name = "Dirt Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 16;
                    width = 12;
                    height = 12;
                    break;
                case 31:
                    name = "Bottle";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 13;
                    width = 16;
                    height = 24;
                    value = 20;
                    break;
                case 32:
                    name = "Wooden Table";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 14;
                    width = 26;
                    height = 20;
                    value = 300;
                    break;
                case 33:
                    name = "Furnace";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 17;
                    width = 26;
                    height = 24;
                    value = 300;
                    toolTip = "Used for smelting ore";
                    break;
                case 34:
                    name = "Wooden Chair";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 15;
                    width = 12;
                    height = 30;
                    value = 150;
                    break;
                case 35:
                    name = "Iron Anvil";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 16;
                    width = 28;
                    height = 14;
                    value = 5000;
                    toolTip = "Used to craft items from metal bars";
                    break;
                case 36:
                    name = "Work Bench";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 18;
                    width = 28;
                    height = 14;
                    value = 150;
                    toolTip = "Used for basic crafting";
                    break;
                case 37:
                    name = "Goggles";
                    width = 28;
                    height = 12;
                    defense = 1;
                    headSlot = 10;
                    rare = 1;
                    value = 1000;
                    break;
                case 38:
                    name = "Lens";
                    width = 12;
                    height = 20;
                    maxStack = 99;
                    value = 500;
                    break;
                case 39:
                    useStyle = 5;
                    useAnimation = 30;
                    useTime = 30;
                    name = "Wooden Bow";
                    width = 12;
                    height = 28;
                    shoot = 1;
                    useAmmo = 1;
                    useSound = 5;
                    damage = 4;
                    shootSpeed = 6.1f;
                    noMelee = true;
                    value = 100;
                    ranged = true;
                    break;
                case 40:
                    name = "Wooden Arrow";
                    shootSpeed = 3f;
                    shoot = 1;
                    damage = 4;
                    width = 10;
                    height = 28;
                    maxStack = 250;
                    consumable = true;
                    ammo = 1;
                    knockBack = 2f;
                    value = 10;
                    ranged = true;
                    break;
                case 41:
                    name = "Flaming Arrow";
                    shootSpeed = 3.5f;
                    shoot = 2;
                    damage = 6;
                    width = 10;
                    height = 28;
                    maxStack = 250;
                    consumable = true;
                    ammo = 1;
                    knockBack = 2f;
                    value = 15;
                    ranged = true;
                    break;
                case 42:
                    useStyle = 1;
                    name = "Shuriken";
                    shootSpeed = 9f;
                    shoot = 3;
                    damage = 10;
                    width = 18;
                    height = 20;
                    maxStack = 250;
                    consumable = true;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noUseGraphic = true;
                    noMelee = true;
                    value = 20;
                    ranged = true;
                    break;
                case 43:
                    useStyle = 4;
                    name = "Suspicious Looking Eye";
                    width = 22;
                    height = 14;
                    consumable = true;
                    useAnimation = 45;
                    useTime = 45;
                    maxStack = 20;
                    toolTip = "Summons the Eye of Cthulhu";
                    break;
                case 44:
                    useStyle = 5;
                    useAnimation = 25;
                    useTime = 25;
                    name = "Demon Bow";
                    width = 12;
                    height = 28;
                    shoot = 1;
                    useAmmo = 1;
                    useSound = 5;
                    damage = 14;
                    shootSpeed = 6.7f;
                    knockBack = 1f;
                    alpha = 30;
                    rare = 1;
                    noMelee = true;
                    value = 18000;
                    ranged = true;
                    break;
                case 45:
                    name = "War Axe of the Night";
                    autoReuse = true;
                    useStyle = 1;
                    useAnimation = 30;
                    knockBack = 6f;
                    useTime = 15;
                    width = 24;
                    height = 28;
                    damage = 20;
                    axe = 15;
                    scale = 1.2f;
                    useSound = 1;
                    rare = 1;
                    value = 13500;
                    melee = true;
                    break;
                case 46:
                    name = "Light's Bane";
                    useStyle = 1;
                    useAnimation = 20;
                    knockBack = 5f;
                    width = 24;
                    height = 28;
                    damage = 17;
                    scale = 1.1f;
                    useSound = 1;
                    rare = 1;
                    value = 13500;
                    melee = true;
                    break;
                case 47:
                    name = "Unholy Arrow";
                    shootSpeed = 3.4f;
                    shoot = 4;
                    damage = 8;
                    width = 10;
                    height = 28;
                    maxStack = 250;
                    consumable = true;
                    ammo = 1;
                    knockBack = 3f;
                    alpha = 30;
                    rare = 1;
                    value = 40;
                    ranged = true;
                    break;
                case 48:
                    name = "Chest";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 21;
                    width = 26;
                    height = 22;
                    value = 500;
                    break;
                case 49:
                    name = "Band of Regeneration";
                    width = 22;
                    height = 22;
                    accessory = true;
                    lifeRegen = 1;
                    rare = 1;
                    toolTip = "Slowly regenerates life";
                    value = 50000;
                    break;
                case 50:
                    mana = 20;
                    name = "Magic Mirror";
                    useTurn = true;
                    width = 20;
                    height = 20;
                    useStyle = 4;
                    useTime = 90;
                    useSound = 6;
                    useAnimation = 90;
                    toolTip = "Gaze in the mirror to return home";
                    rare = 1;
                    value = 50000;
                    break;
                case 51:
                    name = "Jester's Arrow";
                    shootSpeed = 0.5f;
                    shoot = 5;
                    damage = 9;
                    width = 10;
                    height = 28;
                    maxStack = 250;
                    consumable = true;
                    ammo = 1;
                    knockBack = 4f;
                    rare = 1;
                    value = 100;
                    ranged = true;
                    break;
                case 52:
                    name = "Angel Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 1;
                    break;
                case 53:
                    name = "Cloud in a Bottle";
                    width = 16;
                    height = 24;
                    accessory = true;
                    rare = 1;
                    toolTip = "Allows the holder to double jump";
                    value = 50000;
                    break;
                case 54:
                    name = "Hermes Boots";
                    width = 28;
                    height = 24;
                    accessory = true;
                    rare = 1;
                    toolTip = "The wearer can run super fast";
                    value = 50000;
                    break;
                case 55:
                    noMelee = true;
                    useStyle = 1;
                    name = "Enchanted Boomerang";
                    shootSpeed = 10f;
                    shoot = 6;
                    damage = 13;
                    knockBack = 8f;
                    width = 14;
                    height = 28;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noUseGraphic = true;
                    rare = 1;
                    value = 50000;
                    melee = true;
                    break;
                case 56:
                    name = "Demonite Ore";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 22;
                    width = 12;
                    height = 12;
                    rare = 1;
                    toolTip = "'Pulsing with dark energy'";
                    value = 4000;
                    break;
                case 57:
                    name = "Demonite Bar";
                    width = 20;
                    height = 20;
                    maxStack = 99;
                    rare = 1;
                    toolTip = "'Pulsing with dark energy'";
                    value = 16000;
                    break;
                case 58:
                    name = "Heart";
                    width = 12;
                    height = 12;
                    break;
                case 59:
                    name = "Corrupt Seeds";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 23;
                    width = 14;
                    height = 14;
                    value = 500;
                    break;
                case 60:
                    name = "Vile Mushroom";
                    width = 16;
                    height = 18;
                    maxStack = 99;
                    value = 50;
                    break;
                case 61:
                    name = "Ebonstone Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 25;
                    width = 12;
                    height = 12;
                    break;
                case 62:
                    name = "Grass Seeds";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 2;
                    width = 14;
                    height = 14;
                    value = 20;
                    break;
                case 63:
                    name = "Sunflower";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 27;
                    width = 26;
                    height = 26;
                    value = 200;
                    break;
                case 64:
                    mana = 12;
                    damage = 8;
                    useStyle = 1;
                    name = "Vilethorn";
                    shootSpeed = 32f;
                    shoot = 7;
                    width = 26;
                    height = 28;
                    useSound = 8;
                    useAnimation = 30;
                    useTime = 30;
                    rare = 1;
                    noMelee = true;
                    knockBack = 1f;
                    toolTip = "Summons a vile thorn";
                    value = 10000;
                    magic = true;
                    break;
                case 65:
                    autoReuse = true;
                    mana = 16;
                    knockBack = 5f;
                    alpha = 100;
                    color = new Color(150, 150, 150, 0);
                    damage = 16;
                    useStyle = 1;
                    scale = 1.15f;
                    name = "Starfury";
                    shootSpeed = 12f;
                    shoot = 9;
                    width = 14;
                    height = 28;
                    useSound = 9;
                    useAnimation = 25;
                    useTime = 10;
                    rare = 1;
                    toolTip = "Causes stars to rain from the sky";
                    toolTip2 = "'Forged with the fury of heaven'";
                    value = 50000;
                    magic = true;
                    break;
                case 66:
                    useStyle = 1;
                    name = "Purification Powder";
                    shootSpeed = 4f;
                    shoot = 10;
                    width = 16;
                    height = 24;
                    maxStack = 99;
                    consumable = true;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noMelee = true;
                    toolTip = "Cleanses the corruption";
                    value = 75;
                    break;
                case 67:
                    damage = 0;
                    useStyle = 1;
                    name = "Vile Powder";
                    shootSpeed = 4f;
                    shoot = 11;
                    width = 16;
                    height = 24;
                    maxStack = 99;
                    consumable = true;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noMelee = true;
                    value = 100;
                    toolTip = "Removes the Hallow";
                    break;
                case 68:
                    name = "Rotten Chunk";
                    width = 18;
                    height = 20;
                    maxStack = 99;
                    toolTip = "'Looks tasty!'";
                    value = 10;
                    break;
                case 69:
                    name = "Worm Tooth";
                    width = 8;
                    height = 20;
                    maxStack = 99;
                    value = 100;
                    break;
                case 70:
                    useStyle = 4;
                    consumable = true;
                    useAnimation = 45;
                    useTime = 45;
                    name = "Worm Food";
                    width = 28;
                    height = 28;
                    maxStack = 20;
                    toolTip = "Summons the Eater of Worlds";
                    break;
                case 71:
                    name = "Copper Coin";
                    width = 10;
                    height = 12;
                    maxStack = 100;
                    value = 5;
                    break;
                case 72:
                    name = "Silver Coin";
                    width = 10;
                    height = 12;
                    maxStack = 100;
                    value = 500;
                    break;
                case 73:
                    name = "Gold Coin";
                    width = 10;
                    height = 12;
                    maxStack = 100;
                    value = 50000;
                    break;
                case 74:
                    name = "Platinum Coin";
                    width = 10;
                    height = 12;
                    maxStack = 100;
                    value = 5000000;
                    break;
                case 75:
                    name = "Fallen Star";
                    width = 18;
                    height = 20;
                    maxStack = 100;
                    alpha = 75;
                    ammo = 15;
                    toolTip = "Disappears after the sunrise";
                    value = 500;
                    useStyle = 4;
                    useSound = 4;
                    useTurn = false;
                    useAnimation = 17;
                    useTime = 17;
                    consumable = true;
                    rare = 1;
                    break;
                case 76:
                    name = "Copper Greaves";
                    width = 18;
                    height = 18;
                    defense = 1;
                    legSlot = 1;
                    value = 750;
                    break;
                case 77:
                    name = "Iron Greaves";
                    width = 18;
                    height = 18;
                    defense = 2;
                    legSlot = 2;
                    value = 3000;
                    break;
                case 78:
                    name = "Silver Greaves";
                    width = 18;
                    height = 18;
                    defense = 3;
                    legSlot = 3;
                    value = 7500;
                    break;
                case 79:
                    name = "Gold Greaves";
                    width = 18;
                    height = 18;
                    defense = 4;
                    legSlot = 4;
                    value = 15000;
                    break;
                case 80:
                    name = "Copper Chainmail";
                    width = 18;
                    height = 18;
                    defense = 2;
                    bodySlot = 1;
                    value = 1000;
                    break;
                case 81:
                    name = "Iron Chainmail";
                    width = 18;
                    height = 18;
                    defense = 3;
                    bodySlot = 2;
                    value = 4000;
                    break;
                case 82:
                    name = "Silver Chainmail";
                    width = 18;
                    height = 18;
                    defense = 4;
                    bodySlot = 3;
                    value = 10000;
                    break;
                case 83:
                    name = "Gold Chainmail";
                    width = 18;
                    height = 18;
                    defense = 5;
                    bodySlot = 4;
                    value = 20000;
                    break;
                case 84:
                    noUseGraphic = true;
                    damage = 0;
                    knockBack = 7f;
                    useStyle = 5;
                    name = "Grappling Hook";
                    shootSpeed = 11f;
                    shoot = 13;
                    width = 18;
                    height = 28;
                    useSound = 1;
                    useAnimation = 20;
                    useTime = 20;
                    rare = 1;
                    noMelee = true;
                    value = 20000;
                    toolTip = "'Get over here!'";
                    break;
                case 85:
                    name = "Iron Chain";
                    width = 14;
                    height = 20;
                    maxStack = 99;
                    value = 1000;
                    break;
                case 86:
                    name = "Shadow Scale";
                    width = 14;
                    height = 18;
                    maxStack = 99;
                    rare = 1;
                    value = 500;
                    break;
                case 87:
                    name = "Piggy Bank";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 29;
                    width = 20;
                    height = 12;
                    value = 10000;
                    break;
                case 88:
                    name = "Mining Helmet";
                    width = 22;
                    height = 16;
                    defense = 1;
                    headSlot = 11;
                    rare = 1;
                    value = 80000;
                    toolTip = "Provides light when worn";
                    break;
                case 89:
                    name = "Copper Helmet";
                    width = 18;
                    height = 18;
                    defense = 1;
                    headSlot = 1;
                    value = 1250;
                    break;
                case 90:
                    name = "Iron Helmet";
                    width = 18;
                    height = 18;
                    defense = 2;
                    headSlot = 2;
                    value = 5000;
                    break;
                case 91:
                    name = "Silver Helmet";
                    width = 18;
                    height = 18;
                    defense = 3;
                    headSlot = 3;
                    value = 12500;
                    break;
                case 92:
                    name = "Gold Helmet";
                    width = 18;
                    height = 18;
                    defense = 4;
                    headSlot = 4;
                    value = 25000;
                    break;
                case 93:
                    name = "Wood Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 4;
                    width = 12;
                    height = 12;
                    break;
                case 94:
                    name = "Wood Platform";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 19;
                    width = 8;
                    height = 10;
                    break;
                case 95:
                    useStyle = 5;
                    useAnimation = 16;
                    useTime = 16;
                    name = "Flintlock Pistol";
                    width = 24;
                    height = 28;
                    shoot = 14;
                    useAmmo = 14;
                    useSound = 11;
                    damage = 10;
                    shootSpeed = 5f;
                    noMelee = true;
                    value = 50000;
                    scale = 0.9f;
                    rare = 1;
                    ranged = true;
                    break;
                case 96:
                    useStyle = 5;
                    autoReuse = true;
                    useAnimation = 43;
                    useTime = 43;
                    name = "Musket";
                    width = 44;
                    height = 14;
                    shoot = 10;
                    useAmmo = 14;
                    useSound = 11;
                    damage = 23;
                    shootSpeed = 8f;
                    noMelee = true;
                    value = 100000;
                    knockBack = 4f;
                    rare = 1;
                    ranged = true;
                    break;
                case 97:
                    name = "Musket Ball";
                    shootSpeed = 4f;
                    shoot = 14;
                    damage = 7;
                    width = 8;
                    height = 8;
                    maxStack = 250;
                    consumable = true;
                    ammo = 14;
                    knockBack = 2f;
                    value = 7;
                    ranged = true;
                    break;
                case 98:
                    useStyle = 5;
                    autoReuse = true;
                    useAnimation = 8;
                    useTime = 8;
                    name = "Minishark";
                    width = 50;
                    height = 18;
                    shoot = 10;
                    useAmmo = 14;
                    useSound = 11;
                    damage = 6;
                    shootSpeed = 7f;
                    noMelee = true;
                    value = 350000;
                    rare = 2;
                    toolTip = "33% chance to not consume ammo";
                    toolTip2 = "'Half shark, half gun, completely awesome.'";
                    ranged = true;
                    break;
                case 99:
                    useStyle = 5;
                    useAnimation = 28;
                    useTime = 28;
                    name = "Iron Bow";
                    width = 12;
                    height = 28;
                    shoot = 1;
                    useAmmo = 1;
                    useSound = 5;
                    damage = 8;
                    shootSpeed = 6.6f;
                    noMelee = true;
                    value = 1400;
                    ranged = true;
                    break;
                case 100:
                    name = "Shadow Greaves";
                    width = 18;
                    height = 18;
                    defense = 6;
                    legSlot = 5;
                    rare = 1;
                    value = 22500;
                    toolTip = "7% increased melee speed";
                    break;
                case 101:
                    name = "Shadow Scalemail";
                    width = 18;
                    height = 18;
                    defense = 7;
                    bodySlot = 5;
                    rare = 1;
                    value = 30000;
                    toolTip = "7% increased melee speed";
                    break;
                case 102:
                    name = "Shadow Helmet";
                    width = 18;
                    height = 18;
                    defense = 6;
                    headSlot = 5;
                    rare = 1;
                    value = 37500;
                    toolTip = "7% increased melee speed";
                    break;
                case 103:
                    name = "Nightmare Pickaxe";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 20;
                    useTime = 15;
                    autoReuse = true;
                    width = 24;
                    height = 28;
                    damage = 9;
                    pick = 65;
                    useSound = 1;
                    knockBack = 3f;
                    rare = 1;
                    value = 18000;
                    scale = 1.15f;
                    toolTip = "Able to mine Hellstone";
                    melee = true;
                    break;
                case 104:
                    name = "The Breaker";
                    autoReuse = true;
                    useStyle = 1;
                    useAnimation = 45;
                    useTime = 19;
                    hammer = 55;
                    width = 24;
                    height = 28;
                    damage = 24;
                    knockBack = 6f;
                    scale = 1.3f;
                    useSound = 1;
                    rare = 1;
                    value = 15000;
                    melee = true;
                    break;
                case 105:
                    noWet = true;
                    name = "Candle";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 33;
                    width = 8;
                    height = 18;
                    holdStyle = 1;
                    break;
                case 106:
                    name = "Copper Chandelier";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 34;
                    width = 26;
                    height = 26;
                    break;
                case 107:
                    name = "Silver Chandelier";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 35;
                    width = 26;
                    height = 26;
                    break;
                case 108:
                    name = "Gold Chandelier";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 36;
                    width = 26;
                    height = 26;
                    break;
                case 109:
                    name = "Mana Crystal";
                    maxStack = 99;
                    consumable = true;
                    width = 18;
                    height = 18;
                    useStyle = 4;
                    useTime = 30;
                    useSound = 29;
                    useAnimation = 30;
                    toolTip = "Permanently increases maximum mana by 20";
                    rare = 2;
                    break;
                case 110:
                    name = "Lesser Mana Potion";
                    useSound = 3;
                    healMana = 50;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 20;
                    consumable = true;
                    width = 14;
                    height = 24;
                    value = 100;
                    break;
                case 111:
                    name = "Band of Starpower";
                    width = 22;
                    height = 22;
                    accessory = true;
                    rare = 1;
                    toolTip = "Increases maximum mana by 20";
                    value = 50000;
                    break;
                case 112:
                    mana = 17;
                    damage = 44;
                    useStyle = 1;
                    name = "Flower of Fire";
                    shootSpeed = 6f;
                    shoot = 15;
                    width = 26;
                    height = 28;
                    useSound = 20;
                    useAnimation = 20;
                    useTime = 20;
                    rare = 3;
                    noMelee = true;
                    knockBack = 5.5f;
                    toolTip = "Throws balls of fire";
                    value = 10000;
                    magic = true;
                    break;
                case 113:
                    mana = 10;
                    channel = true;
                    damage = 22;
                    useStyle = 1;
                    name = "Magic Missile";
                    shootSpeed = 6f;
                    shoot = 16;
                    width = 26;
                    height = 28;
                    useSound = 9;
                    useAnimation = 17;
                    useTime = 17;
                    rare = 2;
                    noMelee = true;
                    knockBack = 5f;
                    toolTip = "Casts a controllable missile";
                    value = 10000;
                    magic = true;
                    break;
                case 114:
                    mana = 5;
                    channel = true;
                    damage = 0;
                    useStyle = 1;
                    name = "Dirt Rod";
                    shoot = 17;
                    width = 26;
                    height = 28;
                    useSound = 8;
                    useAnimation = 20;
                    useTime = 20;
                    rare = 1;
                    noMelee = true;
                    knockBack = 5f;
                    toolTip = "Magically moves dirt";
                    value = 200000;
                    break;
                case 115:
                    mana = 40;
                    channel = true;
                    damage = 0;
                    useStyle = 4;
                    name = "Orb of Light";
                    shoot = 18;
                    width = 24;
                    height = 24;
                    useSound = 8;
                    useAnimation = 20;
                    useTime = 20;
                    rare = 1;
                    noMelee = true;
                    toolTip = "Creates a magical orb of light";
                    value = 10000;
                    buffType = 19;
                    buffTime = 18000;
                    break;
                case 116:
                    name = "Meteorite";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 37;
                    width = 12;
                    height = 12;
                    value = 1000;
                    break;
                case 117:
                    name = "Meteorite Bar";
                    width = 20;
                    height = 20;
                    maxStack = 99;
                    rare = 1;
                    toolTip = "'Warm to the touch'";
                    value = 7000;
                    break;
                case 118:
                    name = "Hook";
                    maxStack = 99;
                    width = 18;
                    height = 18;
                    value = 1000;
                    toolTip = "Sometimes dropped by Skeletons and Piranha";
                    break;
                case 119:
                    noMelee = true;
                    useStyle = 1;
                    name = "Flamarang";
                    shootSpeed = 11f;
                    shoot = 19;
                    damage = 32;
                    knockBack = 8f;
                    width = 14;
                    height = 28;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noUseGraphic = true;
                    rare = 3;
                    value = 100000;
                    melee = true;
                    break;
                case 120:
                    useStyle = 5;
                    useAnimation = 25;
                    useTime = 25;
                    name = "Molten Fury";
                    width = 14;
                    height = 32;
                    shoot = 1;
                    useAmmo = 1;
                    useSound = 5;
                    damage = 29;
                    shootSpeed = 8f;
                    knockBack = 2f;
                    alpha = 30;
                    rare = 3;
                    noMelee = true;
                    scale = 1.1f;
                    value = 27000;
                    toolTip = "Lights wooden arrows ablaze";
                    ranged = true;
                    break;
                case 121:
                    name = "Fiery Greatsword";
                    useStyle = 1;
                    useAnimation = 34;
                    knockBack = 6.5f;
                    width = 24;
                    height = 28;
                    damage = 36;
                    scale = 1.3f;
                    useSound = 1;
                    rare = 3;
                    value = 27000;
                    toolTip = "'It's made out of fire!'";
                    melee = true;
                    break;
                case 122:
                    name = "Molten Pickaxe";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 25;
                    useTime = 25;
                    autoReuse = true;
                    width = 24;
                    height = 28;
                    damage = 12;
                    pick = 100;
                    scale = 1.15f;
                    useSound = 1;
                    knockBack = 2f;
                    rare = 3;
                    value = 27000;
                    melee = true;
                    break;
                case 123:
                    name = "Meteor Helmet";
                    width = 18;
                    height = 18;
                    defense = 3;
                    headSlot = 6;
                    rare = 1;
                    value = 45000;
                    toolTip = "5% increased magic damage";
                    break;
                case 124:
                    name = "Meteor Suit";
                    width = 18;
                    height = 18;
                    defense = 4;
                    bodySlot = 6;
                    rare = 1;
                    value = 30000;
                    toolTip = "5% increased magic damage";
                    break;
                case 125:
                    name = "Meteor Leggings";
                    width = 18;
                    height = 18;
                    defense = 3;
                    legSlot = 6;
                    rare = 1;
                    value = 30000;
                    toolTip = "5% increased magic damage";
                    break;
                case 126:
                    name = "Bottled Water";
                    useSound = 3;
                    healLife = 20;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    potion = true;
                    value = 20;
                    break;
                case 127:
                    autoReuse = true;
                    useStyle = 5;
                    useAnimation = 19;
                    useTime = 19;
                    name = "Space Gun";
                    width = 24;
                    height = 28;
                    shoot = 20;
                    mana = 8;
                    useSound = 12;
                    knockBack = 0.5f;
                    damage = 17;
                    shootSpeed = 10f;
                    noMelee = true;
                    scale = 0.8f;
                    rare = 1;
                    magic = true;
                    break;
                case 128:
                    name = "Rocket Boots";
                    width = 28;
                    height = 24;
                    accessory = true;
                    rare = 3;
                    toolTip = "Allows flight";
                    value = 50000;
                    break;
                case 129:
                    name = "Gray Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 38;
                    width = 12;
                    height = 12;
                    break;
                case 130:
                    name = "Gray Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 5;
                    width = 12;
                    height = 12;
                    break;
                case 131:
                    name = "Red Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 39;
                    width = 12;
                    height = 12;
                    break;
                case 132:
                    name = "Red Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 6;
                    width = 12;
                    height = 12;
                    break;
                case 133:
                    name = "Clay Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 40;
                    width = 12;
                    height = 12;
                    break;
                case 134:
                    name = "Blue Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 41;
                    width = 12;
                    height = 12;
                    break;
                case 135:
                    name = "Blue Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 17;
                    width = 12;
                    height = 12;
                    break;
                case 136:
                    name = "Chain Lantern";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 42;
                    width = 12;
                    height = 28;
                    break;
                case 137:
                    name = "Green Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 43;
                    width = 12;
                    height = 12;
                    break;
                case 138:
                    name = "Green Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 18;
                    width = 12;
                    height = 12;
                    break;
                case 139:
                    name = "Pink Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 44;
                    width = 12;
                    height = 12;
                    break;
                case 140:
                    name = "Pink Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 19;
                    width = 12;
                    height = 12;
                    break;
                case 141:
                    name = "Gold Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 45;
                    width = 12;
                    height = 12;
                    break;
                case 142:
                    name = "Gold Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 10;
                    width = 12;
                    height = 12;
                    break;
                case 143:
                    name = "Silver Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 46;
                    width = 12;
                    height = 12;
                    break;
                case 144:
                    name = "Silver Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 11;
                    width = 12;
                    height = 12;
                    break;
                case 145:
                    name = "Copper Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 47;
                    width = 12;
                    height = 12;
                    break;
                case 146:
                    name = "Copper Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 12;
                    width = 12;
                    height = 12;
                    break;
                case 147:
                    name = "Spike";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 48;
                    width = 12;
                    height = 12;
                    break;
                case 148:
                    noWet = true;
                    name = "Water Candle";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 49;
                    width = 8;
                    height = 18;
                    holdStyle = 1;
                    toolTip = "Holding this may attract unwanted attention";
                    break;
                case 149:
                    name = "Book";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 50;
                    width = 24;
                    height = 28;
                    toolTip = "'It contains strange symbols'";
                    break;
                case 150:
                    name = "Cobweb";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 51;
                    width = 20;
                    height = 24;
                    alpha = 100;
                    break;
                case 151:
                    name = "Necro Helmet";
                    width = 18;
                    height = 18;
                    defense = 5;
                    headSlot = 7;
                    rare = 2;
                    value = 45000;
                    toolTip = "4% increased ranged damage.";
                    break;
                case 152:
                    name = "Necro Breastplate";
                    width = 18;
                    height = 18;
                    defense = 6;
                    bodySlot = 7;
                    rare = 2;
                    value = 30000;
                    toolTip = "4% increased ranged damage.";
                    break;
                case 153:
                    name = "Necro Greaves";
                    width = 18;
                    height = 18;
                    defense = 5;
                    legSlot = 7;
                    rare = 2;
                    value = 30000;
                    toolTip = "4% increased ranged damage.";
                    break;
                case 154:
                    name = "Bone";
                    maxStack = 99;
                    consumable = true;
                    width = 12;
                    height = 14;
                    value = 50;
                    useAnimation = 12;
                    useTime = 12;
                    useStyle = 1;
                    useSound = 1;
                    shootSpeed = 8f;
                    noUseGraphic = true;
                    damage = 22;
                    knockBack = 4f;
                    shoot = 21;
                    ranged = true;
                    break;
                case 155:
                    autoReuse = true;
                    useTurn = true;
                    name = "Muramasa";
                    useStyle = 1;
                    useAnimation = 20;
                    width = 40;
                    height = 40;
                    damage = 18;
                    scale = 1.1f;
                    useSound = 1;
                    rare = 2;
                    value = 27000;
                    knockBack = 1f;
                    melee = true;
                    break;
                case 156:
                    name = "Cobalt Shield";
                    width = 24;
                    height = 28;
                    rare = 2;
                    value = 27000;
                    accessory = true;
                    defense = 1;
                    toolTip = "Grants immunity to knockback";
                    break;
                case 157:
                    mana = 7;
                    autoReuse = true;
                    name = "Aqua Scepter";
                    useStyle = 5;
                    useAnimation = 16;
                    useTime = 8;
                    knockBack = 5f;
                    width = 38;
                    height = 10;
                    damage = 14;
                    scale = 1f;
                    shoot = 22;
                    shootSpeed = 11f;
                    useSound = 13;
                    rare = 2;
                    value = 27000;
                    toolTip = "Sprays out a shower of water";
                    magic = true;
                    break;
                case 158:
                    name = "Lucky Horseshoe";
                    width = 20;
                    height = 22;
                    rare = 1;
                    value = 27000;
                    accessory = true;
                    toolTip = "Negates fall damage";
                    break;
                case 159:
                    name = "Shiny Red Balloon";
                    width = 14;
                    height = 28;
                    rare = 1;
                    value = 27000;
                    accessory = true;
                    toolTip = "Increases jump height";
                    break;
                case 160:
                    autoReuse = true;
                    name = "Harpoon";
                    useStyle = 5;
                    useAnimation = 30;
                    useTime = 30;
                    knockBack = 6f;
                    width = 30;
                    height = 10;
                    damage = 25;
                    scale = 1.1f;
                    shoot = 23;
                    shootSpeed = 11f;
                    useSound = 10;
                    rare = 2;
                    value = 27000;
                    ranged = true;
                    break;
                case 161:
                    useStyle = 1;
                    name = "Spiky Ball";
                    shootSpeed = 5f;
                    shoot = 24;
                    knockBack = 1f;
                    damage = 15;
                    width = 10;
                    height = 10;
                    maxStack = 250;
                    consumable = true;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noUseGraphic = true;
                    noMelee = true;
                    value = 80;
                    ranged = true;
                    break;
                case 162:
                    name = "Ball O' Hurt";
                    useStyle = 5;
                    useAnimation = 45;
                    useTime = 45;
                    knockBack = 6.5f;
                    width = 30;
                    height = 10;
                    damage = 15;
                    scale = 1.1f;
                    noUseGraphic = true;
                    shoot = 25;
                    shootSpeed = 12f;
                    useSound = 1;
                    rare = 1;
                    value = 27000;
                    melee = true;
                    channel = true;
                    noMelee = true;
                    break;
                case 163:
                    name = "Blue Moon";
                    useStyle = 5;
                    useAnimation = 45;
                    useTime = 45;
                    knockBack = 7f;
                    width = 30;
                    height = 10;
                    damage = 23;
                    scale = 1.1f;
                    noUseGraphic = true;
                    shoot = 26;
                    shootSpeed = 12f;
                    useSound = 1;
                    rare = 2;
                    value = 27000;
                    melee = true;
                    channel = true;
                    break;
                case 164:
                    autoReuse = false;
                    useStyle = 5;
                    useAnimation = 12;
                    useTime = 12;
                    name = "Handgun";
                    width = 24;
                    height = 24;
                    shoot = 14;
                    knockBack = 3f;
                    useAmmo = 14;
                    useSound = 11;
                    damage = 14;
                    shootSpeed = 10f;
                    noMelee = true;
                    value = 50000;
                    scale = 0.75f;
                    rare = 2;
                    ranged = true;
                    break;
                case 165:
                    autoReuse = true;
                    rare = 2;
                    mana = 14;
                    useSound = 21;
                    name = "Water Bolt";
                    useStyle = 5;
                    damage = 17;
                    useAnimation = 17;
                    useTime = 17;
                    width = 24;
                    height = 28;
                    shoot = 27;
                    scale = 0.9f;
                    shootSpeed = 4.5f;
                    knockBack = 5f;
                    toolTip = "Casts a slow moving bolt of water";
                    magic = true;
                    value = 50000;
                    break;
                case 166:
                    useStyle = 1;
                    name = "Bomb";
                    shootSpeed = 5f;
                    shoot = 28;
                    width = 20;
                    height = 20;
                    maxStack = 50;
                    consumable = true;
                    useSound = 1;
                    useAnimation = 25;
                    useTime = 25;
                    noUseGraphic = true;
                    noMelee = true;
                    value = 500;
                    damage = 0;
                    toolTip = "A small explosion that will destroy some tiles";
                    break;
                case 167:
                    useStyle = 1;
                    name = "Dynamite";
                    shootSpeed = 4f;
                    shoot = 29;
                    width = 8;
                    height = 28;
                    maxStack = 5;
                    consumable = true;
                    useSound = 1;
                    useAnimation = 40;
                    useTime = 40;
                    noUseGraphic = true;
                    noMelee = true;
                    value = 5000;
                    rare = 1;
                    toolTip = "A large explosion that will destroy most tiles";
                    break;
                case 168:
                    useStyle = 5;
                    name = "Grenade";
                    shootSpeed = 5.5f;
                    shoot = 30;
                    width = 20;
                    height = 20;
                    maxStack = 99;
                    consumable = true;
                    useSound = 1;
                    useAnimation = 45;
                    useTime = 45;
                    noUseGraphic = true;
                    noMelee = true;
                    value = 400;
                    damage = 60;
                    knockBack = 8f;
                    toolTip = "A small explosion that will not destroy tiles";
                    ranged = true;
                    break;
                case 169:
                    name = "Sand Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 53;
                    width = 12;
                    height = 12;
                    ammo = 42;
                    break;
                case 170:
                    name = "Glass";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 54;
                    width = 12;
                    height = 12;
                    break;
                case 171:
                    name = "Sign";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 55;
                    width = 28;
                    height = 28;
                    break;
                case 172:
                    name = "Ash Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 57;
                    width = 12;
                    height = 12;
                    break;
                case 173:
                    name = "Obsidian";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 56;
                    width = 12;
                    height = 12;
                    break;
                case 174:
                    name = "Hellstone";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 58;
                    width = 12;
                    height = 12;
                    rare = 2;
                    break;
                case 175:
                    name = "Hellstone Bar";
                    width = 20;
                    height = 20;
                    maxStack = 99;
                    rare = 2;
                    toolTip = "'Hot to the touch'";
                    value = 20000;
                    break;
                case 176:
                    name = "Mud Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 59;
                    width = 12;
                    height = 12;
                    break;
                case 181:
                    name = "Amethyst";
                    maxStack = 99;
                    alpha = 50;
                    width = 10;
                    height = 14;
                    value = 1875;
                    break;
                case 180:
                    name = "Topaz";
                    maxStack = 99;
                    alpha = 50;
                    width = 10;
                    height = 14;
                    value = 3750;
                    break;
                case 177:
                    name = "Sapphire";
                    maxStack = 99;
                    alpha = 50;
                    width = 10;
                    height = 14;
                    value = 5625;
                    break;
                case 179:
                    name = "Emerald";
                    maxStack = 99;
                    alpha = 50;
                    width = 10;
                    height = 14;
                    value = 7500;
                    break;
                case 178:
                    name = "Ruby";
                    maxStack = 99;
                    alpha = 50;
                    width = 10;
                    height = 14;
                    value = 11250;
                    break;
                case 182:
                    name = "Diamond";
                    maxStack = 99;
                    alpha = 50;
                    width = 10;
                    height = 14;
                    value = 15000;
                    break;
                case 183:
                    name = "Glowing Mushroom";
                    useStyle = 2;
                    useSound = 2;
                    useTurn = false;
                    useAnimation = 17;
                    useTime = 17;
                    width = 16;
                    height = 18;
                    healLife = 25;
                    maxStack = 99;
                    consumable = true;
                    potion = true;
                    value = 50;
                    break;
                case 184:
                    name = "Star";
                    width = 12;
                    height = 12;
                    break;
                case 185:
                    noUseGraphic = true;
                    damage = 0;
                    knockBack = 7f;
                    useStyle = 5;
                    name = "Ivy Whip";
                    shootSpeed = 13f;
                    shoot = 32;
                    width = 18;
                    height = 28;
                    useSound = 1;
                    useAnimation = 20;
                    useTime = 20;
                    rare = 3;
                    noMelee = true;
                    value = 20000;
                    break;
                case 186:
                    name = "Breathing Reed";
                    width = 44;
                    height = 44;
                    rare = 1;
                    value = 10000;
                    holdStyle = 2;
                    toolTip = "'Because not drowning is kinda nice'";
                    break;
                case 187:
                    name = "Flipper";
                    width = 28;
                    height = 28;
                    rare = 1;
                    value = 10000;
                    accessory = true;
                    toolTip = "Grants the ability to swim";
                    break;
                case 188:
                    name = "Healing Potion";
                    useSound = 3;
                    healLife = 100;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    rare = 1;
                    potion = true;
                    value = 1000;
                    break;
                case 189:
                    name = "Mana Potion";
                    useSound = 3;
                    healMana = 100;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 50;
                    consumable = true;
                    width = 14;
                    height = 24;
                    rare = 1;
                    value = 250;
                    break;
                case 190:
                    name = "Blade of Grass";
                    useStyle = 1;
                    useAnimation = 30;
                    knockBack = 3f;
                    width = 40;
                    height = 40;
                    damage = 28;
                    scale = 1.4f;
                    useSound = 1;
                    rare = 3;
                    value = 27000;
                    melee = true;
                    break;
                case 191:
                    noMelee = true;
                    useStyle = 1;
                    name = "Thorn Chakram";
                    shootSpeed = 11f;
                    shoot = 33;
                    damage = 25;
                    knockBack = 8f;
                    width = 14;
                    height = 28;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noUseGraphic = true;
                    rare = 3;
                    value = 50000;
                    melee = true;
                    break;
                case 192:
                    name = "Obsidian Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 75;
                    width = 12;
                    height = 12;
                    break;
                case 193:
                    name = "Obsidian Skull";
                    width = 20;
                    height = 22;
                    rare = 2;
                    value = 27000;
                    accessory = true;
                    defense = 1;
                    toolTip = "Grants immunity to fire blocks";
                    break;
                case 194:
                    name = "Mushroom Grass Seeds";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 70;
                    width = 14;
                    height = 14;
                    value = 150;
                    break;
                case 195:
                    name = "Jungle Grass Seeds";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 60;
                    width = 14;
                    height = 14;
                    value = 150;
                    break;
                case 196:
                    name = "Wooden Hammer";
                    autoReuse = true;
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 37;
                    useTime = 25;
                    hammer = 25;
                    width = 24;
                    height = 28;
                    damage = 2;
                    knockBack = 5.5f;
                    scale = 1.2f;
                    useSound = 1;
                    tileBoost = -1;
                    value = 50;
                    melee = true;
                    break;
                case 197:
                    autoReuse = true;
                    useStyle = 5;
                    useAnimation = 10;
                    useTime = 10;
                    name = "Star Cannon";
                    width = 50;
                    height = 18;
                    shoot = 12;
                    useAmmo = 15;
                    useSound = 9;
                    damage = 60;
                    shootSpeed = 14f;
                    noMelee = true;
                    value = 500000;
                    rare = 2;
                    toolTip = "Shoots fallen stars";
                    ranged = true;
                    break;
                case 198:
                    name = "Blue Phaseblade";
                    useStyle = 1;
                    useAnimation = 25;
                    knockBack = 3f;
                    width = 40;
                    height = 40;
                    damage = 21;
                    scale = 1f;
                    useSound = 15;
                    rare = 1;
                    value = 27000;
                    melee = true;
                    break;
                case 199:
                    name = "Red Phaseblade";
                    useStyle = 1;
                    useAnimation = 25;
                    knockBack = 3f;
                    width = 40;
                    height = 40;
                    damage = 21;
                    scale = 1f;
                    useSound = 15;
                    rare = 1;
                    value = 27000;
                    melee = true;
                    break;
                case 200:
                    name = "Green Phaseblade";
                    useStyle = 1;
                    useAnimation = 25;
                    knockBack = 3f;
                    width = 40;
                    height = 40;
                    damage = 21;
                    scale = 1f;
                    useSound = 15;
                    rare = 1;
                    value = 27000;
                    melee = true;
                    break;
                case 201:
                    name = "Purple Phaseblade";
                    useStyle = 1;
                    useAnimation = 25;
                    knockBack = 3f;
                    width = 40;
                    height = 40;
                    damage = 21;
                    scale = 1f;
                    useSound = 15;
                    rare = 1;
                    value = 27000;
                    melee = true;
                    break;
                case 202:
                    name = "White Phaseblade";
                    useStyle = 1;
                    useAnimation = 25;
                    knockBack = 3f;
                    width = 40;
                    height = 40;
                    damage = 21;
                    scale = 1f;
                    useSound = 15;
                    rare = 1;
                    value = 27000;
                    melee = true;
                    break;
                case 203:
                    name = "Yellow Phaseblade";
                    useStyle = 1;
                    useAnimation = 25;
                    knockBack = 3f;
                    width = 40;
                    height = 40;
                    damage = 21;
                    scale = 1f;
                    useSound = 15;
                    rare = 1;
                    value = 27000;
                    melee = true;
                    break;
                case 204:
                    name = "Meteor Hamaxe";
                    useTurn = true;
                    autoReuse = true;
                    useStyle = 1;
                    useAnimation = 30;
                    useTime = 16;
                    hammer = 60;
                    axe = 20;
                    width = 24;
                    height = 28;
                    damage = 20;
                    knockBack = 7f;
                    scale = 1.2f;
                    useSound = 1;
                    rare = 1;
                    value = 15000;
                    melee = true;
                    break;
                case 205:
                    name = "Empty Bucket";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    width = 20;
                    height = 20;
                    headSlot = 13;
                    defense = 1;
                    break;
                case 206:
                    name = "Water Bucket";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    width = 20;
                    height = 20;
                    break;
                case 207:
                    name = "Lava Bucket";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    width = 20;
                    height = 20;
                    break;
                case 208:
                    name = "Jungle Rose";
                    width = 20;
                    height = 20;
                    value = 100;
                    headSlot = 23;
                    toolTip = "'It's pretty, oh so pretty'";
                    vanity = true;
                    break;
                case 209:
                    name = "Stinger";
                    width = 16;
                    height = 18;
                    maxStack = 99;
                    value = 200;
                    break;
                case 210:
                    name = "Vine";
                    width = 14;
                    height = 20;
                    maxStack = 99;
                    value = 1000;
                    break;
                case 211:
                    name = "Feral Claws";
                    width = 20;
                    height = 20;
                    accessory = true;
                    rare = 3;
                    toolTip = "12% increased melee speed";
                    value = 50000;
                    break;
                case 212:
                    name = "Anklet of the Wind";
                    width = 20;
                    height = 20;
                    accessory = true;
                    rare = 3;
                    toolTip = "10% increased movement speed";
                    value = 50000;
                    break;
                case 213:
                    name = "Staff of Regrowth";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 25;
                    useTime = 13;
                    autoReuse = true;
                    width = 24;
                    height = 28;
                    damage = 7;
                    createTile = 2;
                    scale = 1.2f;
                    useSound = 1;
                    knockBack = 3f;
                    rare = 3;
                    value = 2000;
                    toolTip = "Creates grass on dirt";
                    melee = true;
                    break;
                case 214:
                    name = "Hellstone Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 76;
                    width = 12;
                    height = 12;
                    break;
                case 215:
                    name = "Whoopie Cushion";
                    width = 18;
                    height = 18;
                    useTurn = true;
                    useTime = 30;
                    useAnimation = 30;
                    noUseGraphic = true;
                    useStyle = 10;
                    useSound = 16;
                    rare = 2;
                    toolTip = "'May annoy others'";
                    value = 100;
                    break;
                case 216:
                    name = "Shackle";
                    width = 20;
                    height = 20;
                    rare = 1;
                    value = 1500;
                    accessory = true;
                    defense = 1;
                    break;
                case 217:
                    name = "Molten Hamaxe";
                    useTurn = true;
                    autoReuse = true;
                    useStyle = 1;
                    useAnimation = 27;
                    useTime = 14;
                    hammer = 70;
                    axe = 30;
                    width = 24;
                    height = 28;
                    damage = 20;
                    knockBack = 7f;
                    scale = 1.4f;
                    useSound = 1;
                    rare = 3;
                    value = 15000;
                    melee = true;
                    break;
                case 218:
                    mana = 16;
                    channel = true;
                    damage = 34;
                    useStyle = 1;
                    name = "Flamelash";
                    shootSpeed = 6f;
                    shoot = 34;
                    width = 26;
                    height = 28;
                    useSound = 20;
                    useAnimation = 20;
                    useTime = 20;
                    rare = 3;
                    noMelee = true;
                    knockBack = 6.5f;
                    toolTip = "Summons a controllable ball of fire";
                    value = 10000;
                    magic = true;
                    break;
                case 219:
                    autoReuse = false;
                    useStyle = 5;
                    useAnimation = 11;
                    useTime = 11;
                    name = "Phoenix Blaster";
                    width = 24;
                    height = 22;
                    shoot = 14;
                    knockBack = 2f;
                    useAmmo = 14;
                    useSound = 11;
                    damage = 23;
                    shootSpeed = 13f;
                    noMelee = true;
                    value = 50000;
                    scale = 0.75f;
                    rare = 3;
                    ranged = true;
                    break;
                case 220:
                    name = "Sunfury";
                    noMelee = true;
                    useStyle = 5;
                    useAnimation = 45;
                    useTime = 45;
                    knockBack = 7f;
                    width = 30;
                    height = 10;
                    damage = 33;
                    scale = 1.1f;
                    noUseGraphic = true;
                    shoot = 35;
                    shootSpeed = 12f;
                    useSound = 1;
                    rare = 3;
                    value = 27000;
                    melee = true;
                    channel = true;
                    break;
                case 221:
                    name = "Hellforge";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 77;
                    width = 26;
                    height = 24;
                    value = 3000;
                    break;
                case 222:
                    name = "Clay Pot";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 78;
                    width = 14;
                    height = 14;
                    value = 100;
                    toolTip = "Grows plants";
                    break;
                case 223:
                    name = "Nature's Gift";
                    width = 20;
                    height = 22;
                    rare = 3;
                    value = 27000;
                    accessory = true;
                    toolTip = "6% reduced mana usage";
                    break;
                case 224:
                    name = "Bed";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 79;
                    width = 28;
                    height = 20;
                    value = 2000;
                    break;
                case 225:
                    name = "Silk";
                    maxStack = 99;
                    width = 22;
                    height = 22;
                    value = 1000;
                    break;
                case 226:
                    name = "Lesser Restoration Potion";
                    useSound = 3;
                    healMana = 50;
                    healLife = 50;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 20;
                    consumable = true;
                    width = 14;
                    height = 24;
                    potion = true;
                    value = 2000;
                    break;
                case 227:
                    name = "Restoration Potion";
                    useSound = 3;
                    healMana = 100;
                    healLife = 100;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 20;
                    consumable = true;
                    width = 14;
                    height = 24;
                    potion = true;
                    value = 4000;
                    break;
                case 228:
                    name = "Jungle Hat";
                    width = 18;
                    height = 18;
                    defense = 4;
                    headSlot = 8;
                    rare = 3;
                    value = 45000;
                    toolTip = "Increases maximum mana by 20";
                    toolTip2 = "3% increased magic critical strike chance";
                    break;
                case 229:
                    name = "Jungle Shirt";
                    width = 18;
                    height = 18;
                    defense = 5;
                    bodySlot = 8;
                    rare = 3;
                    value = 30000;
                    toolTip = "Increases maximum mana by 20";
                    toolTip2 = "3% increased magic critical strike chance";
                    break;
                case 230:
                    name = "Jungle Pants";
                    width = 18;
                    height = 18;
                    defense = 4;
                    legSlot = 8;
                    rare = 3;
                    value = 30000;
                    toolTip = "Increases maximum mana by 20";
                    toolTip2 = "3% increased magic critical strike chance";
                    break;
                case 231:
                    name = "Molten Helmet";
                    width = 18;
                    height = 18;
                    defense = 8;
                    headSlot = 9;
                    rare = 3;
                    value = 45000;
                    break;
                case 232:
                    name = "Molten Breastplate";
                    width = 18;
                    height = 18;
                    defense = 9;
                    bodySlot = 9;
                    rare = 3;
                    value = 30000;
                    break;
                case 233:
                    name = "Molten Greaves";
                    width = 18;
                    height = 18;
                    defense = 8;
                    legSlot = 9;
                    rare = 3;
                    value = 30000;
                    break;
                case 234:
                    name = "Meteor Shot";
                    shootSpeed = 3f;
                    shoot = 36;
                    damage = 9;
                    width = 8;
                    height = 8;
                    maxStack = 250;
                    consumable = true;
                    ammo = 14;
                    knockBack = 1f;
                    value = 8;
                    rare = 1;
                    ranged = true;
                    break;
                case 235:
                    useStyle = 1;
                    name = "Sticky Bomb";
                    shootSpeed = 5f;
                    shoot = 37;
                    width = 20;
                    height = 20;
                    maxStack = 50;
                    consumable = true;
                    useSound = 1;
                    useAnimation = 25;
                    useTime = 25;
                    noUseGraphic = true;
                    noMelee = true;
                    value = 500;
                    damage = 0;
                    toolTip = "'Tossing may be difficult.'";
                    break;
                case 236:
                    name = "Black Lens";
                    width = 12;
                    height = 20;
                    maxStack = 99;
                    value = 5000;
                    break;
                case 237:
                    name = "Sunglasses";
                    width = 28;
                    height = 12;
                    headSlot = 12;
                    rare = 2;
                    value = 10000;
                    toolTip = "'Makes you look cool!'";
                    vanity = true;
                    break;
                case 238:
                    name = "Wizard Hat";
                    width = 28;
                    height = 20;
                    headSlot = 14;
                    rare = 2;
                    value = 10000;
                    defense = 2;
                    toolTip = "15% increased magic damage";
                    break;
                case 239:
                    name = "Top Hat";
                    width = 18;
                    height = 18;
                    headSlot = 15;
                    value = 10000;
                    vanity = true;
                    break;
                case 240:
                    name = "Tuxedo Shirt";
                    width = 18;
                    height = 18;
                    bodySlot = 10;
                    value = 5000;
                    vanity = true;
                    break;
                case 241:
                    name = "Tuxedo Pants";
                    width = 18;
                    height = 18;
                    legSlot = 10;
                    value = 5000;
                    vanity = true;
                    break;
                case 242:
                    name = "Summer Hat";
                    width = 18;
                    height = 18;
                    headSlot = 16;
                    value = 10000;
                    vanity = true;
                    break;
                case 243:
                    name = "Bunny Hood";
                    width = 18;
                    height = 18;
                    headSlot = 17;
                    value = 20000;
                    vanity = true;
                    break;
                case 244:
                    name = "Plumber's Hat";
                    width = 18;
                    height = 12;
                    headSlot = 18;
                    value = 10000;
                    vanity = true;
                    break;
                case 245:
                    name = "Plumber's Shirt";
                    width = 18;
                    height = 18;
                    bodySlot = 11;
                    value = 250000;
                    vanity = true;
                    break;
                case 246:
                    name = "Plumber's Pants";
                    width = 18;
                    height = 18;
                    legSlot = 11;
                    value = 250000;
                    vanity = true;
                    break;
                case 247:
                    name = "Hero's Hat";
                    width = 18;
                    height = 12;
                    headSlot = 19;
                    value = 10000;
                    vanity = true;
                    break;
                case 248:
                    name = "Hero's Shirt";
                    width = 18;
                    height = 18;
                    bodySlot = 12;
                    value = 5000;
                    vanity = true;
                    break;
                case 249:
                    name = "Hero's Pants";
                    width = 18;
                    height = 18;
                    legSlot = 12;
                    value = 5000;
                    vanity = true;
                    break;
                case 250:
                    name = "Fish Bowl";
                    width = 18;
                    height = 18;
                    headSlot = 20;
                    value = 10000;
                    vanity = true;
                    break;
                case 251:
                    name = "Archaeologist's Hat";
                    width = 18;
                    height = 12;
                    headSlot = 21;
                    value = 10000;
                    vanity = true;
                    break;
                case 252:
                    name = "Archaeologist's Jacket";
                    width = 18;
                    height = 18;
                    bodySlot = 13;
                    value = 5000;
                    vanity = true;
                    break;
                case 253:
                    name = "Archaeologist's Pants";
                    width = 18;
                    height = 18;
                    legSlot = 13;
                    value = 5000;
                    vanity = true;
                    break;
                case 254:
                    name = "Black Dye";
                    maxStack = 99;
                    width = 12;
                    height = 20;
                    value = 10000;
                    break;
                case 255:
                    name = "Green Dye";
                    maxStack = 99;
                    width = 12;
                    height = 20;
                    value = 2000;
                    break;
                case 256:
                    name = "Ninja Hood";
                    width = 18;
                    height = 12;
                    headSlot = 22;
                    value = 10000;
                    vanity = true;
                    break;
                case 257:
                    name = "Ninja Shirt";
                    width = 18;
                    height = 18;
                    bodySlot = 14;
                    value = 5000;
                    vanity = true;
                    break;
                case 258:
                    name = "Ninja Pants";
                    width = 18;
                    height = 18;
                    legSlot = 14;
                    value = 5000;
                    vanity = true;
                    break;
                case 259:
                    name = "Leather";
                    width = 18;
                    height = 20;
                    maxStack = 99;
                    value = 50;
                    break;
                case 260:
                    name = "Red Hat";
                    width = 18;
                    height = 14;
                    headSlot = 24;
                    value = 1000;
                    vanity = true;
                    break;
                case 261:
                    name = "Goldfish";
                    useStyle = 2;
                    useSound = 2;
                    useTurn = false;
                    useAnimation = 17;
                    useTime = 17;
                    width = 20;
                    height = 10;
                    maxStack = 99;
                    healLife = 20;
                    consumable = true;
                    value = 1000;
                    potion = true;
                    toolTip = "'It's smiling, might be a good snack'";
                    break;
                case 262:
                    name = "Robe";
                    width = 18;
                    height = 14;
                    bodySlot = 15;
                    value = 2000;
                    vanity = true;
                    break;
                case 263:
                    name = "Robot Hat";
                    width = 18;
                    height = 18;
                    headSlot = 25;
                    value = 10000;
                    vanity = true;
                    break;
                case 264:
                    name = "Gold Crown";
                    width = 18;
                    height = 18;
                    headSlot = 26;
                    value = 10000;
                    vanity = true;
                    break;
                case 265:
                    name = "Hellfire Arrow";
                    shootSpeed = 6.5f;
                    shoot = 41;
                    damage = 10;
                    width = 10;
                    height = 28;
                    maxStack = 250;
                    consumable = true;
                    ammo = 1;
                    knockBack = 8f;
                    value = 100;
                    rare = 2;
                    ranged = true;
                    break;
                case 266:
                    useStyle = 5;
                    useAnimation = 16;
                    useTime = 16;
                    autoReuse = true;
                    name = "Sandgun";
                    width = 40;
                    height = 20;
                    shoot = 42;
                    useAmmo = 42;
                    useSound = 11;
                    damage = 30;
                    shootSpeed = 12f;
                    noMelee = true;
                    knockBack = 5f;
                    value = 10000;
                    rare = 2;
                    toolTip = "'This is a good idea!'";
                    ranged = true;
                    break;
                case 267:
                    accessory = true;
                    name = "Guide Voodoo Doll";
                    width = 14;
                    height = 26;
                    value = 1000;
                    toolTip = "'You are a terrible person.'";
                    break;
                case 268:
                    headSlot = 27;
                    defense = 2;
                    name = "Diving Helmet";
                    width = 20;
                    height = 20;
                    value = 1000;
                    rare = 2;
                    toolTip = "Greatly extends underwater breathing";
                    break;
                case 269:
                    name = "Familiar Shirt";
                    bodySlot = 0;
                    width = 20;
                    height = 20;
                    value = 10000;
                    color = Main.player[Main.myPlayer].shirtColor;
                    break;
                case 270:
                    name = "Familiar Pants";
                    legSlot = 0;
                    width = 20;
                    height = 20;
                    value = 10000;
                    color = Main.player[Main.myPlayer].pantsColor;
                    break;
                case 271:
                    name = "Familiar Wig";
                    headSlot = 0;
                    width = 20;
                    height = 20;
                    value = 10000;
                    color = Main.player[Main.myPlayer].hairColor;
                    break;
                case 272:
                    mana = 14;
                    damage = 35;
                    useStyle = 5;
                    name = "Demon Scythe";
                    shootSpeed = 0.2f;
                    shoot = 45;
                    width = 26;
                    height = 28;
                    useSound = 8;
                    useAnimation = 20;
                    useTime = 20;
                    rare = 3;
                    noMelee = true;
                    knockBack = 5f;
                    scale = 0.9f;
                    toolTip = "Casts a demon scythe";
                    value = 10000;
                    magic = true;
                    break;
                case 273:
                    name = "Night's Edge";
                    useStyle = 1;
                    useAnimation = 27;
                    useTime = 27;
                    knockBack = 4.5f;
                    width = 40;
                    height = 40;
                    damage = 42;
                    scale = 1.15f;
                    useSound = 1;
                    rare = 3;
                    value = 27000;
                    melee = true;
                    break;
                case 274:
                    name = "Dark Lance";
                    useStyle = 5;
                    useAnimation = 25;
                    useTime = 25;
                    shootSpeed = 5f;
                    knockBack = 4f;
                    width = 40;
                    height = 40;
                    damage = 27;
                    scale = 1.1f;
                    useSound = 1;
                    shoot = 46;
                    rare = 3;
                    value = 27000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    break;
                case 275:
                    name = "Coral";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 81;
                    width = 20;
                    height = 22;
                    value = 400;
                    break;
                case 276:
                    name = "Cactus";
                    maxStack = 250;
                    width = 12;
                    height = 12;
                    value = 10;
                    break;
                case 277:
                    name = "Trident";
                    useStyle = 5;
                    useAnimation = 31;
                    useTime = 31;
                    shootSpeed = 4f;
                    knockBack = 5f;
                    width = 40;
                    height = 40;
                    damage = 10;
                    scale = 1.1f;
                    useSound = 1;
                    shoot = 47;
                    rare = 1;
                    value = 10000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    break;
                case 278:
                    name = "Silver Bullet";
                    shootSpeed = 4.5f;
                    shoot = 14;
                    damage = 9;
                    width = 8;
                    height = 8;
                    maxStack = 250;
                    consumable = true;
                    ammo = 14;
                    knockBack = 3f;
                    value = 15;
                    ranged = true;
                    break;
                case 279:
                    useStyle = 1;
                    name = "Throwing Knife";
                    shootSpeed = 10f;
                    shoot = 48;
                    damage = 12;
                    width = 18;
                    height = 20;
                    maxStack = 250;
                    consumable = true;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noUseGraphic = true;
                    noMelee = true;
                    value = 50;
                    knockBack = 2f;
                    ranged = true;
                    break;
                case 280:
                    name = "Spear";
                    useStyle = 5;
                    useAnimation = 31;
                    useTime = 31;
                    shootSpeed = 3.7f;
                    knockBack = 6.5f;
                    width = 32;
                    height = 32;
                    damage = 8;
                    scale = 1f;
                    useSound = 1;
                    shoot = 49;
                    value = 1000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    break;
                case 281:
                    useStyle = 5;
                    autoReuse = true;
                    useAnimation = 45;
                    useTime = 45;
                    name = "Blowpipe";
                    width = 38;
                    height = 6;
                    shoot = 10;
                    useAmmo = 51;
                    useSound = 5;
                    damage = 9;
                    shootSpeed = 11f;
                    noMelee = true;
                    value = 10000;
                    knockBack = 4f;
                    useAmmo = 51;
                    toolTip = "Allows the collection of seeds for ammo";
                    ranged = true;
                    break;
                case 282:
                    useStyle = 1;
                    name = "Glowstick";
                    shootSpeed = 6f;
                    shoot = 50;
                    width = 12;
                    height = 12;
                    maxStack = 99;
                    consumable = true;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noMelee = true;
                    value = 10;
                    holdStyle = 1;
                    toolTip = "Works when wet";
                    break;
                case 283:
                    name = "Seed";
                    shoot = 51;
                    width = 8;
                    height = 8;
                    maxStack = 250;
                    ammo = 51;
                    toolTip = "For use with Blowpipe";
                    break;
                case 284:
                    noMelee = true;
                    useStyle = 1;
                    name = "Wooden Boomerang";
                    shootSpeed = 6.5f;
                    shoot = 52;
                    damage = 7;
                    knockBack = 5f;
                    width = 14;
                    height = 28;
                    useSound = 1;
                    useAnimation = 16;
                    useTime = 16;
                    noUseGraphic = true;
                    value = 5000;
                    melee = true;
                    break;
                case 285:
                    name = "Aglet";
                    width = 24;
                    height = 8;
                    accessory = true;
                    toolTip = "5% increased movement speed";
                    value = 5000;
                    break;
                case 286:
                    useStyle = 1;
                    name = "Sticky Glowstick";
                    shootSpeed = 6f;
                    shoot = 53;
                    width = 12;
                    height = 12;
                    maxStack = 99;
                    consumable = true;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noMelee = true;
                    value = 20;
                    holdStyle = 1;
                    break;
                case 287:
                    useStyle = 1;
                    name = "Poisoned Knife";
                    shootSpeed = 11f;
                    shoot = 54;
                    damage = 13;
                    width = 18;
                    height = 20;
                    maxStack = 250;
                    consumable = true;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noUseGraphic = true;
                    noMelee = true;
                    value = 60;
                    knockBack = 2f;
                    ranged = true;
                    break;
                case 288:
                    name = "Obsidian Skin Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 1;
                    buffTime = 14400;
                    toolTip = "Provides immunity to lava";
                    value = 1000;
                    rare = 1;
                    break;
                case 289:
                    name = "Regeneration Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 2;
                    buffTime = 18000;
                    toolTip = "Provides life regeneration";
                    value = 1000;
                    rare = 1;
                    break;
                case 290:
                    name = "Swiftness Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 3;
                    buffTime = 14400;
                    toolTip = "25% increased movement speed";
                    value = 1000;
                    rare = 1;
                    break;
                case 291:
                    name = "Gills Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 4;
                    buffTime = 7200;
                    toolTip = "Breathe water instead of air";
                    value = 1000;
                    rare = 1;
                    break;
                case 292:
                    name = "Ironskin Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 5;
                    buffTime = 18000;
                    toolTip = "Increase defense by 8";
                    value = 1000;
                    rare = 1;
                    break;
                case 293:
                    name = "Mana Regeneration Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 6;
                    buffTime = 7200;
                    toolTip = "Increased mana regeneration";
                    value = 1000;
                    rare = 1;
                    break;
                case 294:
                    name = "Magic Power Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 7;
                    buffTime = 7200;
                    toolTip = "20% increased magic damage";
                    value = 1000;
                    rare = 1;
                    break;
                case 295:
                    name = "Featherfall Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 8;
                    buffTime = 18000;
                    toolTip = "Slows falling speed";
                    value = 1000;
                    rare = 1;
                    break;
                case 296:
                    name = "Spelunker Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 9;
                    buffTime = 18000;
                    toolTip = "Shows the location of treasure and ore";
                    value = 1000;
                    rare = 1;
                    break;
                case 297:
                    name = "Invisibility Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 10;
                    buffTime = 7200;
                    toolTip = "Grants invisibility";
                    value = 1000;
                    rare = 1;
                    break;
                case 298:
                    name = "Shine Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 11;
                    buffTime = 18000;
                    toolTip = "Emits an aura of light";
                    value = 1000;
                    rare = 1;
                    break;
                case 299:
                    name = "Night Owl Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 12;
                    buffTime = 14400;
                    toolTip = "Increases night vision";
                    value = 1000;
                    rare = 1;
                    break;
                case 300:
                    name = "Battle Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 13;
                    buffTime = 25200;
                    toolTip = "Increases enemy spawn rate";
                    value = 1000;
                    rare = 1;
                    break;
                case 301:
                    name = "Thorns Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 14;
                    buffTime = 7200;
                    toolTip = "Attackers also take damage";
                    value = 1000;
                    rare = 1;
                    break;
                case 302:
                    name = "Water Walking Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 15;
                    buffTime = 18000;
                    toolTip = "Allows the ability to walk on water";
                    value = 1000;
                    rare = 1;
                    break;
                case 303:
                    name = "Archery Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 16;
                    buffTime = 14400;
                    toolTip = "20% increased arrow speed and damage";
                    value = 1000;
                    rare = 1;
                    break;
                case 304:
                    name = "Hunter Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 17;
                    buffTime = 18000;
                    toolTip = "Shows the location of enemies";
                    value = 1000;
                    rare = 1;
                    break;
                case 305:
                    name = "Gravitation Potion";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    buffType = 18;
                    buffTime = 10800;
                    toolTip = "Allows the control of gravity";
                    value = 1000;
                    rare = 1;
                    break;
                case 306:
                    name = "Gold Chest";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 21;
                    placeStyle = 1;
                    width = 26;
                    height = 22;
                    value = 5000;
                    break;
                case 307:
                    name = "Daybloom Seeds";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 82;
                    placeStyle = 0;
                    width = 12;
                    height = 14;
                    value = 80;
                    break;
                case 308:
                    name = "Moonglow Seeds";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 82;
                    placeStyle = 1;
                    width = 12;
                    height = 14;
                    value = 80;
                    break;
                case 309:
                    name = "Blinkroot Seeds";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 82;
                    placeStyle = 2;
                    width = 12;
                    height = 14;
                    value = 80;
                    break;
                case 310:
                    name = "Deathweed Seeds";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 82;
                    placeStyle = 3;
                    width = 12;
                    height = 14;
                    value = 80;
                    break;
                case 311:
                    name = "Waterleaf Seeds";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 82;
                    placeStyle = 4;
                    width = 12;
                    height = 14;
                    value = 80;
                    break;
                case 312:
                    name = "Fireblossom Seeds";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 82;
                    placeStyle = 5;
                    width = 12;
                    height = 14;
                    value = 80;
                    break;
                case 313:
                    name = "Daybloom";
                    maxStack = 99;
                    width = 12;
                    height = 14;
                    value = 100;
                    break;
                case 314:
                    name = "Moonglow";
                    maxStack = 99;
                    width = 12;
                    height = 14;
                    value = 100;
                    break;
                case 315:
                    name = "Blinkroot";
                    maxStack = 99;
                    width = 12;
                    height = 14;
                    value = 100;
                    break;
                case 316:
                    name = "Deathweed";
                    maxStack = 99;
                    width = 12;
                    height = 14;
                    value = 100;
                    break;
                case 317:
                    name = "Waterleaf";
                    maxStack = 99;
                    width = 12;
                    height = 14;
                    value = 100;
                    break;
                case 318:
                    name = "Fireblossom";
                    maxStack = 99;
                    width = 12;
                    height = 14;
                    value = 100;
                    break;
                case 319:
                    name = "Shark Fin";
                    maxStack = 99;
                    width = 16;
                    height = 14;
                    value = 200;
                    break;
                case 320:
                    name = "Feather";
                    maxStack = 99;
                    width = 16;
                    height = 14;
                    value = 50;
                    break;
                case 321:
                    name = "Tombstone";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 85;
                    width = 20;
                    height = 20;
                    break;
                case 322:
                    name = "Mime Mask";
                    headSlot = 28;
                    width = 20;
                    height = 20;
                    value = 20000;
                    break;
                case 323:
                    name = "Antlion Mandible";
                    width = 10;
                    height = 20;
                    maxStack = 99;
                    value = 50;
                    break;
                case 324:
                    name = "Illegal Gun Parts";
                    width = 10;
                    height = 20;
                    maxStack = 99;
                    value = 750000;
                    toolTip = "'Banned in most places'";
                    break;
                case 325:
                    name = "The Doctor's Shirt";
                    width = 18;
                    height = 18;
                    bodySlot = 16;
                    value = 200000;
                    vanity = true;
                    break;
                case 326:
                    name = "The Doctor's Pants";
                    width = 18;
                    height = 18;
                    legSlot = 15;
                    value = 200000;
                    vanity = true;
                    break;
                case 327:
                    name = "Golden Key";
                    width = 14;
                    height = 20;
                    maxStack = 99;
                    toolTip = "Opens one Gold Chest";
                    break;
                case 328:
                    name = "Shadow Chest";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 21;
                    placeStyle = 3;
                    width = 26;
                    height = 22;
                    value = 5000;
                    break;
                case 329:
                    name = "Shadow Key";
                    width = 14;
                    height = 20;
                    maxStack = 1;
                    toolTip = "Opens all Shadow Chests";
                    value = 75000;
                    break;
                case 330:
                    name = "Obsidian Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 20;
                    width = 12;
                    height = 12;
                    break;
                case 331:
                    name = "Jungle Spores";
                    width = 18;
                    height = 16;
                    maxStack = 99;
                    value = 100;
                    break;
                case 332:
                    name = "Loom";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 86;
                    width = 20;
                    height = 20;
                    value = 300;
                    toolTip = "Used for crafting cloth";
                    break;
                case 333:
                    name = "Piano";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 87;
                    width = 20;
                    height = 20;
                    value = 300;
                    break;
                case 334:
                    name = "Dresser";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 88;
                    width = 20;
                    height = 20;
                    value = 300;
                    break;
                case 335:
                    name = "Bench";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 89;
                    width = 20;
                    height = 20;
                    value = 300;
                    break;
                case 336:
                    name = "Bathtub";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 90;
                    width = 20;
                    height = 20;
                    value = 300;
                    break;
                case 337:
                    name = "Red Banner";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 91;
                    placeStyle = 0;
                    width = 10;
                    height = 24;
                    value = 500;
                    break;
                case 338:
                    name = "Green Banner";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 91;
                    placeStyle = 1;
                    width = 10;
                    height = 24;
                    value = 500;
                    break;
                case 339:
                    name = "Blue Banner";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 91;
                    placeStyle = 2;
                    width = 10;
                    height = 24;
                    value = 500;
                    break;
                case 340:
                    name = "Yellow Banner";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 91;
                    placeStyle = 3;
                    width = 10;
                    height = 24;
                    value = 500;
                    break;
                case 341:
                    name = "Lamp Post";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 92;
                    width = 10;
                    height = 24;
                    value = 500;
                    break;
                case 342:
                    name = "Tiki Torch";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 93;
                    width = 10;
                    height = 24;
                    value = 500;
                    break;
                case 343:
                    name = "Barrel";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 21;
                    placeStyle = 5;
                    width = 20;
                    height = 20;
                    value = 500;
                    break;
                case 344:
                    name = "Chinese Lantern";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 95;
                    width = 20;
                    height = 20;
                    value = 500;
                    break;
                case 345:
                    name = "Cooking Pot";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 96;
                    width = 20;
                    height = 20;
                    value = 500;
                    break;
                case 346:
                    name = "Safe";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 97;
                    width = 20;
                    height = 20;
                    value = 500000;
                    break;
                case 347:
                    name = "Skull Lantern";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 98;
                    width = 20;
                    height = 20;
                    value = 500;
                    break;
                case 348:
                    name = "Trash Can";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 21;
                    placeStyle = 6;
                    width = 20;
                    height = 20;
                    value = 1000;
                    break;
                case 349:
                    name = "Candelabra";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 100;
                    width = 20;
                    height = 20;
                    value = 1500;
                    break;
                case 350:
                    name = "Pink Vase";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 13;
                    placeStyle = 3;
                    width = 16;
                    height = 24;
                    value = 70;
                    break;
                case 351:
                    name = "Mug";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 13;
                    placeStyle = 4;
                    width = 16;
                    height = 24;
                    value = 20;
                    break;
                case 352:
                    name = "Keg";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 94;
                    width = 24;
                    height = 24;
                    value = 600;
                    toolTip = "Used for brewing ale";
                    break;
                case 353:
                    name = "Ale";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 10;
                    height = 10;
                    buffType = 25;
                    buffTime = 7200;
                    value = 100;
                    break;
                case 354:
                    name = "Bookcase";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 101;
                    width = 20;
                    height = 20;
                    value = 300;
                    break;
                case 355:
                    name = "Throne";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 102;
                    width = 20;
                    height = 20;
                    value = 300;
                    break;
                case 356:
                    name = "Bowl";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 103;
                    width = 16;
                    height = 24;
                    value = 20;
                    break;
                case 357:
                    name = "Bowl of Soup";
                    useSound = 3;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 10;
                    height = 10;
                    buffType = 26;
                    buffTime = 36000;
                    rare = 1;
                    toolTip = "Minor improvements to all stats";
                    value = 1000;
                    break;
                case 358:
                    name = "Toilet";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 15;
                    placeStyle = 1;
                    width = 12;
                    height = 30;
                    value = 150;
                    break;
                case 359:
                    name = "Grandfather Clock";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 104;
                    width = 20;
                    height = 20;
                    value = 300;
                    break;
                case 360:
                    name = "Armor Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    break;
                case 361:
                    useStyle = 4;
                    consumable = true;
                    useAnimation = 45;
                    useTime = 45;
                    name = "Goblin Battle Standard";
                    width = 28;
                    height = 28;
                    toolTip = "Summons a Goblin Army";
                    break;
                case 362:
                    name = "Tattered Cloth";
                    maxStack = 99;
                    width = 24;
                    height = 24;
                    value = 30;
                    break;
                case 363:
                    name = "Sawmill";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 106;
                    width = 20;
                    height = 20;
                    value = 300;
                    toolTip = "Used for advanced wood crafting";
                    break;
                case 364:
                    name = "Cobalt Ore";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 107;
                    width = 12;
                    height = 12;
                    value = 3500;
                    rare = 3;
                    break;
                case 365:
                    name = "Mythril Ore";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 108;
                    width = 12;
                    height = 12;
                    value = 5500;
                    rare = 3;
                    break;
                case 366:
                    name = "Adamantite Ore";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 111;
                    width = 12;
                    height = 12;
                    value = 7500;
                    rare = 3;
                    break;
                case 367:
                    name = "Pwnhammer";
                    useTurn = true;
                    autoReuse = true;
                    useStyle = 1;
                    useAnimation = 27;
                    useTime = 14;
                    hammer = 80;
                    width = 24;
                    height = 28;
                    damage = 26;
                    knockBack = 7.5f;
                    scale = 1.2f;
                    useSound = 1;
                    rare = 4;
                    value = 39000;
                    melee = true;
                    toolTip = "Strong enough to destroy Demon Altars";
                    break;
                case 368:
                    autoReuse = true;
                    name = "Excalibur";
                    useStyle = 1;
                    useAnimation = 25;
                    useTime = 25;
                    knockBack = 4.5f;
                    width = 40;
                    height = 40;
                    damage = 47;
                    scale = 1.15f;
                    useSound = 1;
                    rare = 5;
                    value = 230000;
                    melee = true;
                    break;
                case 369:
                    name = "Hallowed Seeds";
                    useTurn = true;
                    useStyle = 1;
                    useAnimation = 15;
                    useTime = 10;
                    maxStack = 99;
                    consumable = true;
                    createTile = 109;
                    width = 14;
                    height = 14;
                    value = 2000;
                    rare = 3;
                    break;
                case 370:
                    name = "Ebonsand Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 112;
                    width = 12;
                    height = 12;
                    ammo = 42;
                    break;
                case 371:
                    name = "Cobalt Hat";
                    width = 18;
                    height = 18;
                    defense = 2;
                    headSlot = 29;
                    rare = 4;
                    value = 75000;
                    toolTip = "Increases maximum mana by 40";
                    toolTip2 = "9% increased magic critical strike chance";
                    break;
                case 372:
                    name = "Cobalt Helmet";
                    width = 18;
                    height = 18;
                    defense = 11;
                    headSlot = 30;
                    rare = 4;
                    value = 75000;
                    toolTip = "7% increased movement speed";
                    toolTip2 = "12% increased melee speed";
                    break;
                case 373:
                    name = "Cobalt Mask";
                    width = 18;
                    height = 18;
                    defense = 4;
                    headSlot = 31;
                    rare = 4;
                    value = 75000;
                    toolTip = "10% increased ranged damage";
                    toolTip2 = "6% increased ranged critical strike chance";
                    break;
                case 374:
                    name = "Cobalt Breastplate";
                    width = 18;
                    height = 18;
                    defense = 8;
                    bodySlot = 17;
                    rare = 4;
                    value = 60000;
                    toolTip2 = "3% increased critical strike chance";
                    break;
                case 375:
                    name = "Cobalt Leggings";
                    width = 18;
                    height = 18;
                    defense = 7;
                    legSlot = 16;
                    rare = 4;
                    value = 45000;
                    toolTip2 = "10% increased movement speed";
                    break;
                case 376:
                    name = "Mythril Hood";
                    width = 18;
                    height = 18;
                    defense = 3;
                    headSlot = 32;
                    rare = 4;
                    value = 112500;
                    toolTip = "Increases maximum mana by 60";
                    toolTip2 = "15% increased magic damage";
                    break;
                case 377:
                    name = "Mythril Helmet";
                    width = 18;
                    height = 18;
                    defense = 16;
                    headSlot = 33;
                    rare = 4;
                    value = 112500;
                    toolTip = "5% increased melee critical strike chance";
                    toolTip2 = "10% increased melee damage";
                    break;
                case 378:
                    name = "Mythril Hat";
                    width = 18;
                    height = 18;
                    defense = 6;
                    headSlot = 34;
                    rare = 4;
                    value = 112500;
                    toolTip = "12% increased ranged damage";
                    toolTip2 = "7% increased ranged critical strike chance";
                    break;
                case 379:
                    name = "Mythril Chainmail";
                    width = 18;
                    height = 18;
                    defense = 12;
                    bodySlot = 18;
                    rare = 4;
                    value = 90000;
                    toolTip2 = "5% increased damage";
                    break;
                case 380:
                    name = "Mythril Greaves";
                    width = 18;
                    height = 18;
                    defense = 9;
                    legSlot = 17;
                    rare = 4;
                    value = 67500;
                    toolTip2 = "3% increased critical strike chance";
                    break;
                case 381:
                    name = "Cobalt Bar";
                    width = 20;
                    height = 20;
                    maxStack = 99;
                    value = 10500;
                    rare = 3;
                    break;
                case 382:
                    name = "Mythril Bar";
                    width = 20;
                    height = 20;
                    maxStack = 99;
                    value = 22000;
                    rare = 3;
                    break;
                case 383:
                    name = "Cobalt Chainsaw";
                    useStyle = 5;
                    useAnimation = 25;
                    useTime = 8;
                    shootSpeed = 40f;
                    knockBack = 2.75f;
                    width = 20;
                    height = 12;
                    damage = 23;
                    axe = 14;
                    useSound = 23;
                    shoot = 57;
                    rare = 4;
                    value = 54000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    channel = true;
                    break;
                case 384:
                    name = "Mythril Chainsaw";
                    useStyle = 5;
                    useAnimation = 25;
                    useTime = 8;
                    shootSpeed = 40f;
                    knockBack = 3f;
                    width = 20;
                    height = 12;
                    damage = 29;
                    axe = 17;
                    useSound = 23;
                    shoot = 58;
                    rare = 4;
                    value = 81000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    channel = true;
                    break;
                case 385:
                    name = "Cobalt Drill";
                    useStyle = 5;
                    useAnimation = 25;
                    useTime = 13;
                    shootSpeed = 32f;
                    knockBack = 0f;
                    width = 20;
                    height = 12;
                    damage = 10;
                    pick = 110;
                    useSound = 23;
                    shoot = 59;
                    rare = 4;
                    value = 54000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    channel = true;
                    toolTip = "Can mine Mythril";
                    break;
                case 386:
                    name = "Mythril Drill";
                    useStyle = 5;
                    useAnimation = 25;
                    useTime = 10;
                    shootSpeed = 32f;
                    knockBack = 0f;
                    width = 20;
                    height = 12;
                    damage = 15;
                    pick = 150;
                    useSound = 23;
                    shoot = 60;
                    rare = 4;
                    value = 81000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    channel = true;
                    toolTip = "Can mine Adamantite";
                    break;
                case 387:
                    name = "Adamantite Chainsaw";
                    useStyle = 5;
                    useAnimation = 25;
                    useTime = 6;
                    shootSpeed = 40f;
                    knockBack = 4.5f;
                    width = 20;
                    height = 12;
                    damage = 33;
                    axe = 20;
                    useSound = 23;
                    shoot = 61;
                    rare = 4;
                    value = 108000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    channel = true;
                    break;
                case 388:
                    name = "Adamantite Drill";
                    useStyle = 5;
                    useAnimation = 25;
                    useTime = 7;
                    shootSpeed = 32f;
                    knockBack = 0f;
                    width = 20;
                    height = 12;
                    damage = 20;
                    pick = 180;
                    useSound = 23;
                    shoot = 62;
                    rare = 4;
                    value = 108000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    channel = true;
                    break;
                case 389:
                    name = "Dao of Pow";
                    noMelee = true;
                    useStyle = 5;
                    useAnimation = 45;
                    useTime = 45;
                    knockBack = 7f;
                    width = 30;
                    height = 10;
                    damage = 49;
                    scale = 1.1f;
                    noUseGraphic = true;
                    shoot = 63;
                    shootSpeed = 15f;
                    useSound = 1;
                    rare = 5;
                    value = 144000;
                    melee = true;
                    channel = true;
                    toolTip = "Has a chance to confuse";
                    toolTip2 = "'Find you inner pieces'";
                    break;
                case 390:
                    name = "Mythril Halberd";
                    useStyle = 5;
                    useAnimation = 26;
                    useTime = 26;
                    shootSpeed = 4.5f;
                    knockBack = 5f;
                    width = 40;
                    height = 40;
                    damage = 35;
                    scale = 1.1f;
                    useSound = 1;
                    shoot = 64;
                    rare = 4;
                    value = 67500;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    break;
                case 391:
                    name = "Adamantite Bar";
                    width = 20;
                    height = 20;
                    maxStack = 99;
                    value = 37500;
                    rare = 3;
                    break;
                case 392:
                    name = "Glass Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 21;
                    width = 12;
                    height = 12;
                    break;
                case 393:
                    name = "Compass";
                    width = 24;
                    height = 28;
                    rare = 3;
                    value = 100000;
                    accessory = true;
                    toolTip = "Shows horizontal position";
                    break;
                case 394:
                    name = "Diving Gear";
                    width = 24;
                    height = 28;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    toolTip = "Grants the ability to swim";
                    toolTip2 = "Greatly extends underwater breathing";
                    break;
                case 395:
                    name = "GPS";
                    width = 24;
                    height = 28;
                    rare = 4;
                    value = 150000;
                    accessory = true;
                    toolTip = "Shows position";
                    toolTip2 = "Tells the time";
                    break;
                case 396:
                    name = "Obsidian Horseshoe";
                    width = 24;
                    height = 28;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    toolTip = "Negates fall damage";
                    toolTip2 = "Grants immunity to fire blocks";
                    break;
                case 397:
                    name = "Obsidian Shield";
                    width = 24;
                    height = 28;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    defense = 2;
                    toolTip = "Grants immunity to knockback";
                    toolTip2 = "Grants immunity to fire blocks";
                    break;
                case 398:
                    name = "Tinkerer's Workshop";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 114;
                    width = 26;
                    height = 20;
                    value = 100000;
                    toolTip = "Allows the combining of some accessories";
                    break;
                case 399:
                    name = "Cloud in a Balloon";
                    width = 14;
                    height = 28;
                    rare = 4;
                    value = 150000;
                    accessory = true;
                    toolTip = "Allows the holder to double jump";
                    toolTip2 = "Increases jump height";
                    break;
                case 400:
                    name = "Adamantite Headgear";
                    width = 18;
                    height = 18;
                    defense = 4;
                    headSlot = 35;
                    rare = 4;
                    value = 150000;
                    toolTip = "Increases maximum mana by 80";
                    toolTip2 = "11% increased magic damage and critical strike chance";
                    break;
                case 401:
                    name = "Adamantite Helmet";
                    width = 18;
                    height = 18;
                    defense = 22;
                    headSlot = 36;
                    rare = 4;
                    value = 150000;
                    toolTip = "7% increased melee critical strike chance";
                    toolTip2 = "14% increased melee damage";
                    break;
                case 402:
                    name = "Adamantite Mask";
                    width = 18;
                    height = 18;
                    defense = 8;
                    headSlot = 37;
                    rare = 4;
                    value = 150000;
                    toolTip = "14% increased ranged damage";
                    toolTip2 = "8% increased ranged critical strike chance";
                    break;
                case 403:
                    name = "Adamantite Breastplate";
                    width = 18;
                    height = 18;
                    defense = 14;
                    bodySlot = 19;
                    rare = 4;
                    value = 120000;
                    toolTip = "6% increased damage";
                    break;
                case 404:
                    name = "Adamantite Leggings";
                    width = 18;
                    height = 18;
                    defense = 10;
                    legSlot = 18;
                    rare = 4;
                    value = 90000;
                    toolTip = "4% increased critical strike chance";
                    toolTip2 = "5% increased movement speed";
                    break;
                case 405:
                    name = "Spectre Boots";
                    width = 28;
                    height = 24;
                    accessory = true;
                    rare = 4;
                    toolTip = "Allows flight";
                    toolTip2 = "The wearer can run super fast";
                    value = 100000;
                    break;
                case 406:
                    name = "Adamantite Glaive";
                    useStyle = 5;
                    useAnimation = 25;
                    useTime = 25;
                    shootSpeed = 5f;
                    knockBack = 6f;
                    width = 40;
                    height = 40;
                    damage = 38;
                    scale = 1.1f;
                    useSound = 1;
                    shoot = 66;
                    rare = 4;
                    value = 90000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    break;
                case 407:
                    name = "Toolbelt";
                    width = 28;
                    height = 24;
                    accessory = true;
                    rare = 3;
                    toolTip = "Increases block placement range";
                    value = 100000;
                    break;
                case 408:
                    name = "Pearlsand Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 116;
                    width = 12;
                    height = 12;
                    ammo = 42;
                    break;
                case 409:
                    name = "Pearlstone Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 117;
                    width = 12;
                    height = 12;
                    break;
                case 410:
                    name = "Mining Shirt";
                    width = 18;
                    height = 18;
                    defense = 1;
                    bodySlot = 20;
                    value = 5000;
                    rare = 1;
                    break;
                case 411:
                    name = "Mining Pants";
                    width = 18;
                    height = 18;
                    defense = 1;
                    legSlot = 19;
                    value = 5000;
                    rare = 1;
                    break;
                case 412:
                    name = "Pearlstone Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 118;
                    width = 12;
                    height = 12;
                    break;
                case 413:
                    name = "Iridescent Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 119;
                    width = 12;
                    height = 12;
                    break;
                case 414:
                    name = "Mudstone Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 120;
                    width = 12;
                    height = 12;
                    break;
                case 415:
                    name = "Cobalt Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 121;
                    width = 12;
                    height = 12;
                    break;
                case 416:
                    name = "Mythril Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 122;
                    width = 12;
                    height = 12;
                    break;
                case 417:
                    name = "Pearlstone Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 22;
                    width = 12;
                    height = 12;
                    break;
                case 418:
                    name = "Iridescent Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 23;
                    width = 12;
                    height = 12;
                    break;
                case 419:
                    name = "Mudstone Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 24;
                    width = 12;
                    height = 12;
                    break;
                case 420:
                    name = "Cobalt Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 25;
                    width = 12;
                    height = 12;
                    break;
                case 421:
                    name = "Mythril Brick Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 26;
                    width = 12;
                    height = 12;
                    break;
                case 422:
                    useStyle = 1;
                    name = "Holy Water";
                    shootSpeed = 9f;
                    rare = 3;
                    damage = 20;
                    shoot = 69;
                    width = 18;
                    height = 20;
                    maxStack = 250;
                    consumable = true;
                    knockBack = 3f;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noUseGraphic = true;
                    noMelee = true;
                    value = 200;
                    toolTip = "Spreads the Hallow to some blocks";
                    break;
                case 423:
                    useStyle = 1;
                    name = "Unholy Water";
                    shootSpeed = 9f;
                    rare = 3;
                    damage = 20;
                    shoot = 70;
                    width = 18;
                    height = 20;
                    maxStack = 250;
                    consumable = true;
                    knockBack = 3f;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noUseGraphic = true;
                    noMelee = true;
                    value = 200;
                    toolTip = "Spreads the corruption to some blocks";
                    break;
                case 424:
                    name = "Silt Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 123;
                    width = 12;
                    height = 12;
                    break;
                case 425:
                    mana = 40;
                    channel = true;
                    damage = 0;
                    useStyle = 1;
                    name = "Fairy Bell";
                    shoot = 72;
                    width = 24;
                    height = 24;
                    useSound = 25;
                    useAnimation = 20;
                    useTime = 20;
                    rare = 5;
                    noMelee = true;
                    toolTip = "Summons a magical fairy";
                    value = (value = 250000);
                    buffType = 27;
                    buffTime = 18000;
                    break;
                case 426:
                    name = "Breaker Blade";
                    useStyle = 1;
                    useAnimation = 30;
                    knockBack = 8f;
                    width = 60;
                    height = 70;
                    damage = 39;
                    scale = 1.05f;
                    useSound = 1;
                    rare = 4;
                    value = 150000;
                    melee = true;
                    break;
                case 427:
                    noWet = true;
                    name = "Blue Torch";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    holdStyle = 1;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 4;
                    placeStyle = 1;
                    width = 10;
                    height = 12;
                    value = 200;
                    break;
                case 428:
                    noWet = true;
                    name = "Red Torch";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    holdStyle = 1;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 4;
                    placeStyle = 2;
                    width = 10;
                    height = 12;
                    value = 200;
                    break;
                case 429:
                    noWet = true;
                    name = "Green Torch";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    holdStyle = 1;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 4;
                    placeStyle = 3;
                    width = 10;
                    height = 12;
                    value = 200;
                    break;
                case 430:
                    noWet = true;
                    name = "Purple Torch";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    holdStyle = 1;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 4;
                    placeStyle = 4;
                    width = 10;
                    height = 12;
                    value = 200;
                    break;
                case 431:
                    noWet = true;
                    name = "White Torch";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    holdStyle = 1;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 4;
                    placeStyle = 5;
                    width = 10;
                    height = 12;
                    value = 500;
                    break;
                case 432:
                    noWet = true;
                    name = "Yellow Torch";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    holdStyle = 1;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 4;
                    placeStyle = 6;
                    width = 10;
                    height = 12;
                    value = 200;
                    break;
                case 433:
                    noWet = true;
                    name = "Demon Torch";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    holdStyle = 1;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 4;
                    placeStyle = 7;
                    width = 10;
                    height = 12;
                    value = 300;
                    break;
                case 434:
                    autoReuse = true;
                    useStyle = 5;
                    useAnimation = 12;
                    useTime = 4;
                    reuseDelay = 14;
                    name = "Clockwork Assault Rifle";
                    width = 50;
                    height = 18;
                    shoot = 10;
                    useAmmo = 14;
                    useSound = 31;
                    damage = 19;
                    shootSpeed = 7.75f;
                    noMelee = true;
                    value = 150000;
                    rare = 4;
                    ranged = true;
                    toolTip = "Three round burst";
                    toolTip2 = "Only the first shot consumes ammo";
                    break;
                case 435:
                    useStyle = 5;
                    autoReuse = true;
                    useAnimation = 25;
                    useTime = 25;
                    name = "Cobalt Repeater";
                    width = 50;
                    height = 18;
                    shoot = 1;
                    useAmmo = 1;
                    useSound = 5;
                    damage = 30;
                    shootSpeed = 9f;
                    noMelee = true;
                    value = 60000;
                    ranged = true;
                    rare = 4;
                    knockBack = 1.5f;
                    break;
                case 436:
                    useStyle = 5;
                    autoReuse = true;
                    useAnimation = 23;
                    useTime = 23;
                    name = "Mythril Repeater";
                    width = 50;
                    height = 18;
                    shoot = 1;
                    useAmmo = 1;
                    useSound = 5;
                    damage = 34;
                    shootSpeed = 9.5f;
                    noMelee = true;
                    value = 90000;
                    ranged = true;
                    rare = 4;
                    knockBack = 2f;
                    break;
                case 437:
                    noUseGraphic = true;
                    damage = 0;
                    knockBack = 7f;
                    useStyle = 5;
                    name = "Dual Hook";
                    shootSpeed = 14f;
                    shoot = 73;
                    width = 18;
                    height = 28;
                    useSound = 1;
                    useAnimation = 20;
                    useTime = 20;
                    rare = 4;
                    noMelee = true;
                    value = 200000;
                    break;
                case 438:
                    name = "Star Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 2;
                    break;
                case 439:
                    name = "Sword Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 3;
                    break;
                case 440:
                    name = "Slime Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 4;
                    break;
                case 441:
                    name = "Goblin Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 5;
                    break;
                case 442:
                    name = "Shield Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 6;
                    break;
                case 443:
                    name = "Bat Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 7;
                    break;
                case 444:
                    name = "Fish Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 8;
                    break;
                case 445:
                    name = "Bunny Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 9;
                    break;
                case 446:
                    name = "Skeleton Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 10;
                    break;
                case 447:
                    name = "Reaper Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 11;
                    break;
                case 448:
                    name = "Woman Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 12;
                    break;
                case 449:
                    name = "Imp Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 13;
                    break;
                case 450:
                    name = "Gargoyle Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 14;
                    break;
                case 451:
                    name = "Gloom Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 15;
                    break;
                case 452:
                    name = "Hornet Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 16;
                    break;
                case 453:
                    name = "Bomb Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 17;
                    break;
                case 454:
                    name = "Crab Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 18;
                    break;
                case 455:
                    name = "Hammer Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 19;
                    break;
                case 456:
                    name = "Potion Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 20;
                    break;
                case 457:
                    name = "Spear Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 21;
                    break;
                case 458:
                    name = "Cross Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 22;
                    break;
                case 459:
                    name = "Jellyfish Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 23;
                    break;
                case 460:
                    name = "Bow Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 24;
                    break;
                case 461:
                    name = "Boomerang Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 25;
                    break;
                case 462:
                    name = "Boot Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 26;
                    break;
                case 463:
                    name = "Chest Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 27;
                    break;
                case 464:
                    name = "Bird Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 28;
                    break;
                case 465:
                    name = "Axe Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 29;
                    break;
                case 466:
                    name = "Corrupt Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 30;
                    break;
                case 467:
                    name = "Tree Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 31;
                    break;
                case 468:
                    name = "Anvil Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 32;
                    break;
                case 469:
                    name = "Pickaxe Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 33;
                    break;
                case 470:
                    name = "Mushroom Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 34;
                    break;
                case 471:
                    name = "Eyeball Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 35;
                    break;
                case 472:
                    name = "Pillar Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 36;
                    break;
                case 473:
                    name = "Heart Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 37;
                    break;
                case 474:
                    name = "Pot Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 38;
                    break;
                case 475:
                    name = "Sunflower Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 39;
                    break;
                case 476:
                    name = "King Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 40;
                    break;
                case 477:
                    name = "Queen Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 41;
                    break;
                case 478:
                    name = "Pirahna Statue";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 105;
                    width = 20;
                    height = 20;
                    value = 300;
                    placeStyle = 42;
                    break;
                case 479:
                    name = "Planked Wall";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 7;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createWall = 27;
                    width = 12;
                    height = 12;
                    break;
                case 480:
                    name = "Wooden Beam";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 124;
                    width = 12;
                    height = 12;
                    break;
                case 481:
                    useStyle = 5;
                    autoReuse = true;
                    useAnimation = 20;
                    useTime = 20;
                    name = "Adamantite Repeater";
                    width = 50;
                    height = 18;
                    shoot = 1;
                    useAmmo = 1;
                    useSound = 5;
                    damage = 37;
                    shootSpeed = 10f;
                    noMelee = true;
                    value = 120000;
                    ranged = true;
                    rare = 4;
                    knockBack = 2.5f;
                    break;
                case 482:
                    name = "Adamantite Sword";
                    useStyle = 1;
                    useAnimation = 27;
                    useTime = 27;
                    knockBack = 6f;
                    width = 40;
                    height = 40;
                    damage = 44;
                    scale = 1.2f;
                    useSound = 1;
                    rare = 4;
                    value = 138000;
                    melee = true;
                    break;
                case 483:
                    useTurn = true;
                    autoReuse = true;
                    name = "Cobalt Sword";
                    useStyle = 1;
                    useAnimation = 23;
                    useTime = 23;
                    knockBack = 3.85f;
                    width = 40;
                    height = 40;
                    damage = 34;
                    scale = 1.1f;
                    useSound = 1;
                    rare = 4;
                    value = 69000;
                    melee = true;
                    break;
                case 484:
                    name = "Mythril Sword";
                    useStyle = 1;
                    useAnimation = 26;
                    useTime = 26;
                    knockBack = 6f;
                    width = 40;
                    height = 40;
                    damage = 39;
                    scale = 1.15f;
                    useSound = 1;
                    rare = 4;
                    value = 103500;
                    melee = true;
                    break;
                case 485:
                    rare = 4;
                    name = "Moon Charm";
                    width = 24;
                    height = 28;
                    accessory = true;
                    toolTip = "Turns the holder into a werewolf on full moons";
                    value = 150000;
                    break;
                case 486:
                    name = "Ruler";
                    width = 10;
                    height = 26;
                    accessory = true;
                    toolTip = "Creates a grid on screen for block placement";
                    value = 10000;
                    rare = 1;
                    break;
                case 487:
                    name = "Crystal Ball";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 125;
                    width = 22;
                    height = 22;
                    value = 100000;
                    rare = 3;
                    break;
                case 488:
                    name = "Disco Ball";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 126;
                    width = 22;
                    height = 26;
                    value = 10000;
                    break;
                case 489:
                    name = "Sorcerer Emblem";
                    width = 24;
                    height = 24;
                    accessory = true;
                    toolTip = "15% increased magic damage";
                    value = 100000;
                    rare = 4;
                    break;
                case 491:
                    name = "Ranger Emblem";
                    width = 24;
                    height = 24;
                    accessory = true;
                    toolTip = "15% increased ranged damage";
                    value = 100000;
                    break;
                case 490:
                    name = "Warrior Emblem";
                    width = 24;
                    height = 24;
                    accessory = true;
                    toolTip = "15% increased melee damage";
                    value = 100000;
                    rare = 4;
                    break;
                case 492:
                    name = "Demon Wings";
                    width = 24;
                    height = 8;
                    accessory = true;
                    toolTip = "Allows flight and slow fall";
                    value = 400000;
                    rare = 5;
                    break;
                case 493:
                    name = "Angel Wings";
                    width = 24;
                    height = 8;
                    accessory = true;
                    toolTip = "Allows flight and slow fall";
                    value = 400000;
                    rare = 5;
                    break;
                case 494:
                    rare = 5;
                    useStyle = 5;
                    useAnimation = 12;
                    useTime = 12;
                    name = "Magical Harp";
                    width = 12;
                    height = 28;
                    shoot = 76;
                    holdStyle = 3;
                    autoReuse = true;
                    damage = 30;
                    shootSpeed = 4.5f;
                    noMelee = true;
                    value = 200000;
                    mana = 4;
                    magic = true;
                    break;
                case 495:
                    rare = 5;
                    mana = 10;
                    channel = true;
                    damage = 53;
                    useStyle = 1;
                    name = "Rainbow Rod";
                    shootSpeed = 6f;
                    shoot = 79;
                    width = 26;
                    height = 28;
                    useSound = 28;
                    useAnimation = 15;
                    useTime = 15;
                    noMelee = true;
                    knockBack = 5f;
                    toolTip = "Casts a controllable rainbow";
                    value = 200000;
                    magic = true;
                    break;
                case 496:
                    rare = 4;
                    mana = 7;
                    damage = 26;
                    useStyle = 1;
                    name = "Ice Rod";
                    shootSpeed = 12f;
                    shoot = 80;
                    width = 26;
                    height = 28;
                    useSound = 28;
                    useAnimation = 17;
                    useTime = 17;
                    rare = 4;
                    autoReuse = true;
                    noMelee = true;
                    knockBack = 0f;
                    toolTip = "Summons a block of ice";
                    value = 1000000;
                    magic = true;
                    knockBack = 2f;
                    break;
                case 497:
                    name = "Neptune's Shell";
                    width = 24;
                    height = 28;
                    accessory = true;
                    toolTip = "Transforms the holder into merfolk when entering water";
                    value = 150000;
                    rare = 5;
                    break;
                case 498:
                    name = "Mannequin";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 128;
                    width = 12;
                    height = 12;
                    break;
                case 499:
                    name = "Greater Healing Potion";
                    useSound = 3;
                    healLife = 150;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 30;
                    consumable = true;
                    width = 14;
                    height = 24;
                    rare = 3;
                    potion = true;
                    value = 5000;
                    break;
                case 500:
                    name = "Greater Mana Potion";
                    useSound = 3;
                    healMana = 200;
                    useStyle = 2;
                    useTurn = true;
                    useAnimation = 17;
                    useTime = 17;
                    maxStack = 99;
                    consumable = true;
                    width = 14;
                    height = 24;
                    rare = 3;
                    value = 500;
                    break;
                case 501:
                    name = "Pixie Dust";
                    width = 16;
                    height = 14;
                    maxStack = 99;
                    value = 500;
                    rare = 1;
                    break;
                case 502:
                    name = "Crystal Shard";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 129;
                    width = 24;
                    height = 24;
                    value = 8000;
                    rare = 1;
                    break;
                case 503:
                    name = "Clown Hat";
                    width = 18;
                    height = 18;
                    headSlot = 40;
                    value = 20000;
                    vanity = true;
                    rare = 2;
                    break;
                case 504:
                    name = "Clown Shirt";
                    width = 18;
                    height = 18;
                    bodySlot = 23;
                    value = 10000;
                    vanity = true;
                    rare = 2;
                    break;
                case 505:
                    name = "Clown Pants";
                    width = 18;
                    height = 18;
                    legSlot = 22;
                    value = 10000;
                    vanity = true;
                    rare = 2;
                    break;
                case 506:
                    useStyle = 5;
                    autoReuse = true;
                    useAnimation = 30;
                    useTime = 6;
                    name = "Flamethrower";
                    width = 50;
                    height = 18;
                    shoot = 85;
                    useAmmo = 23;
                    useSound = 34;
                    damage = 27;
                    knockBack = 0.3f;
                    shootSpeed = 7f;
                    noMelee = true;
                    value = 500000;
                    rare = 5;
                    ranged = true;
                    toolTip = "Uses gel for ammo";
                    break;
                case 507:
                    rare = 3;
                    useStyle = 1;
                    useAnimation = 12;
                    useTime = 12;
                    name = "Bell";
                    width = 12;
                    height = 28;
                    autoReuse = true;
                    noMelee = true;
                    value = 10000;
                    break;
                case 508:
                    rare = 3;
                    useStyle = 5;
                    useAnimation = 12;
                    useTime = 12;
                    name = "Harp";
                    width = 12;
                    height = 28;
                    autoReuse = true;
                    noMelee = true;
                    value = 10000;
                    break;
                case 509:
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    name = "Wrench";
                    width = 24;
                    height = 28;
                    rare = 1;
                    toolTip = "Places wire";
                    value = 20000;
                    mech = true;
                    break;
                case 510:
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    name = "Wire Cutter";
                    width = 24;
                    height = 28;
                    rare = 1;
                    toolTip = "Removes wire";
                    value = 20000;
                    mech = true;
                    break;
                case 511:
                    name = "Active Stone Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 130;
                    width = 12;
                    height = 12;
                    value = 1000;
                    mech = true;
                    break;
                case 512:
                    name = "Inactive Stone Block";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 131;
                    width = 12;
                    height = 12;
                    value = 1000;
                    mech = true;
                    break;
                case 513:
                    name = "Lever";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 132;
                    width = 24;
                    height = 24;
                    value = 3000;
                    mech = true;
                    break;
                case 514:
                    autoReuse = true;
                    useStyle = 5;
                    useAnimation = 12;
                    useTime = 12;
                    name = "Laser Rifle";
                    width = 36;
                    height = 22;
                    shoot = 88;
                    mana = 8;
                    useSound = 12;
                    knockBack = 2.5f;
                    damage = 29;
                    shootSpeed = 17f;
                    noMelee = true;
                    rare = 4;
                    magic = true;
                    value = 500000;
                    break;
                case 515:
                    name = "Crystal Bullet";
                    shootSpeed = 5f;
                    shoot = 89;
                    damage = 9;
                    width = 8;
                    height = 8;
                    maxStack = 250;
                    consumable = true;
                    ammo = 14;
                    knockBack = 1f;
                    value = 30;
                    ranged = true;
                    rare = 3;
                    toolTip = "Creates several crystal shards on impact";
                    break;
                case 516:
                    name = "Holy Arrow";
                    shootSpeed = 3.5f;
                    shoot = 91;
                    damage = 6;
                    width = 10;
                    height = 28;
                    maxStack = 250;
                    consumable = true;
                    ammo = 1;
                    knockBack = 2f;
                    value = 80;
                    ranged = true;
                    rare = 3;
                    toolTip = "Summons falling stars on impact";
                    break;
                case 517:
                    useStyle = 1;
                    name = "Magic Dagger";
                    shootSpeed = 10f;
                    shoot = 93;
                    damage = 28;
                    width = 18;
                    height = 20;
                    mana = 7;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noUseGraphic = true;
                    noMelee = true;
                    value = 1000000;
                    knockBack = 2f;
                    magic = true;
                    rare = 4;
                    toolTip = "A magical returning dagger";
                    break;
                case 518:
                    autoReuse = true;
                    rare = 4;
                    mana = 5;
                    useSound = 9;
                    name = "Crystal Storm";
                    useStyle = 5;
                    damage = 26;
                    useAnimation = 7;
                    useTime = 7;
                    width = 24;
                    height = 28;
                    shoot = 94;
                    scale = 0.9f;
                    shootSpeed = 16f;
                    knockBack = 5f;
                    toolTip = "Summons rapid fire crystal shards";
                    magic = true;
                    value = 500000;
                    break;
                case 519:
                    autoReuse = true;
                    rare = 4;
                    mana = 14;
                    useSound = 20;
                    name = "Cursed Flames";
                    useStyle = 5;
                    damage = 35;
                    useAnimation = 20;
                    useTime = 20;
                    width = 24;
                    height = 28;
                    shoot = 95;
                    scale = 0.9f;
                    shootSpeed = 10f;
                    knockBack = 6.5f;
                    toolTip = "Summons unholy fire balls";
                    magic = true;
                    value = 500000;
                    break;
                case 520:
                    name = "Soul of Light";
                    width = 18;
                    height = 18;
                    maxStack = 250;
                    value = 1000;
                    rare = 3;
                    toolTip = "'The essence of light creatures'";
                    break;
                case 521:
                    name = "Soul of Night";
                    width = 18;
                    height = 18;
                    maxStack = 250;
                    value = 1000;
                    rare = 3;
                    toolTip = "'The essence of dark creatures'";
                    break;
                case 522:
                    name = "Cursed Flame";
                    width = 12;
                    height = 14;
                    maxStack = 99;
                    value = 4000;
                    rare = 3;
                    toolTip = "'Not even water can put the flame out'";
                    break;
                case 523:
                    name = "Cursed Torch";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    holdStyle = 1;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 4;
                    placeStyle = 8;
                    width = 10;
                    height = 12;
                    value = 300;
                    rare = 1;
                    toolTip = "Can be placed in water";
                    break;
                case 524:
                    name = "Adamantite Forge";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 133;
                    width = 44;
                    height = 30;
                    value = 50000;
                    toolTip = "Used to smelt adamantite ore";
                    rare = 3;
                    break;
                case 525:
                    name = "Mythril Anvil";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 134;
                    width = 28;
                    height = 14;
                    value = 25000;
                    toolTip = "Used to craft items from mythril and adamantite bars";
                    rare = 3;
                    break;
                case 526:
                    name = "Unicorn Horn";
                    width = 14;
                    height = 14;
                    maxStack = 99;
                    value = 15000;
                    rare = 1;
                    toolTip = "'Sharp and magical!'";
                    break;
                case 527:
                    name = "Dark Shard";
                    width = 14;
                    height = 14;
                    maxStack = 99;
                    value = 4500;
                    rare = 2;
                    toolTip = "'Sometimes carried by creatures in corrupt deserts'";
                    break;
                case 528:
                    name = "Light Shard";
                    width = 14;
                    height = 14;
                    maxStack = 99;
                    value = 4500;
                    rare = 2;
                    toolTip = "'Sometimes carried by creatures in light deserts'";
                    break;
                case 529:
                    name = "Red Pressure Plate";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 135;
                    width = 12;
                    height = 12;
                    placeStyle = 0;
                    mech = true;
                    value = 5000;
                    mech = true;
                    toolTip = "Activates when stepped on";
                    break;
                case 530:
                    name = "Wire";
                    width = 12;
                    height = 18;
                    maxStack = 250;
                    value = 500;
                    mech = true;
                    break;
                case 531:
                    name = "Spell Tome";
                    width = 12;
                    height = 18;
                    maxStack = 99;
                    value = 50000;
                    rare = 1;
                    toolTip = "Can be enchanted";
                    break;
                case 532:
                    name = "Star Cloak";
                    width = 20;
                    height = 24;
                    value = 100000;
                    toolTip = "Causes stars to fall when injured";
                    accessory = true;
                    rare = 4;
                    break;
                case 533:
                    useStyle = 5;
                    autoReuse = true;
                    useAnimation = 7;
                    useTime = 7;
                    name = "Megashark";
                    width = 50;
                    height = 18;
                    shoot = 10;
                    useAmmo = 14;
                    useSound = 11;
                    damage = 23;
                    shootSpeed = 10f;
                    noMelee = true;
                    value = 300000;
                    rare = 5;
                    toolTip = "50% chance to not consume ammo";
                    toolTip2 = "'Minishark's older brother'";
                    knockBack = 1f;
                    ranged = true;
                    break;
                case 534:
                    knockBack = 6.5f;
                    useStyle = 5;
                    useAnimation = 45;
                    useTime = 45;
                    name = "Shotgun";
                    width = 50;
                    height = 14;
                    shoot = 10;
                    useAmmo = 14;
                    useSound = 36;
                    damage = 18;
                    shootSpeed = 6f;
                    noMelee = true;
                    value = 700000;
                    rare = 4;
                    ranged = true;
                    toolTip = "Fires a spread of bullets";
                    break;
                case 535:
                    name = "Philosopher's Stone";
                    width = 12;
                    height = 18;
                    value = 100000;
                    toolTip = "Reduces the cooldown of healing potions";
                    accessory = true;
                    rare = 4;
                    break;
                case 536:
                    name = "Titan Glove";
                    width = 12;
                    height = 18;
                    value = 100000;
                    toolTip = "Increases melee knockback";
                    rare = 4;
                    accessory = true;
                    break;
                case 537:
                    name = "Cobalt Naginata";
                    useStyle = 5;
                    useAnimation = 28;
                    useTime = 28;
                    shootSpeed = 4.3f;
                    knockBack = 4f;
                    width = 40;
                    height = 40;
                    damage = 29;
                    scale = 1.1f;
                    useSound = 1;
                    shoot = 97;
                    rare = 4;
                    value = 45000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    break;
                case 538:
                    name = "Switch";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 136;
                    width = 12;
                    height = 12;
                    value = 2000;
                    mech = true;
                    break;
                case 539:
                    name = "Dart Trap";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 137;
                    width = 12;
                    height = 12;
                    value = 10000;
                    mech = true;
                    break;
                case 540:
                    name = "Boulder";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 138;
                    width = 12;
                    height = 12;
                    mech = true;
                    break;
                case 541:
                    name = "Green Pressure Plate";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 135;
                    width = 12;
                    height = 12;
                    placeStyle = 1;
                    mech = true;
                    value = 5000;
                    toolTip = "Activates when stepped on";
                    break;
                case 542:
                    name = "Gray Pressure Plate";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 135;
                    width = 12;
                    height = 12;
                    placeStyle = 2;
                    mech = true;
                    value = 5000;
                    toolTip = "Activates when stepped on";
                    break;
                case 543:
                    name = "Brown Pressure Plate";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 135;
                    width = 12;
                    height = 12;
                    placeStyle = 3;
                    mech = true;
                    value = 5000;
                    toolTip = "Activates when stepped on";
                    break;
                case 544:
                    useStyle = 4;
                    name = "Mechanical Eye";
                    width = 22;
                    height = 14;
                    consumable = true;
                    useAnimation = 45;
                    useTime = 45;
                    maxStack = 20;
                    toolTip = "Summons The Twins";
                    rare = 3;
                    break;
                case 545:
                    name = "Cursed Arrow";
                    shootSpeed = 4f;
                    shoot = 103;
                    damage = 14;
                    width = 10;
                    height = 28;
                    maxStack = 250;
                    consumable = true;
                    ammo = 1;
                    knockBack = 3f;
                    value = 80;
                    ranged = true;
                    rare = 3;
                    break;
                case 546:
                    name = "Cursed Bullet";
                    shootSpeed = 5f;
                    shoot = 104;
                    damage = 12;
                    width = 8;
                    height = 8;
                    maxStack = 250;
                    consumable = true;
                    ammo = 14;
                    knockBack = 4f;
                    value = 30;
                    rare = 1;
                    ranged = true;
                    rare = 3;
                    break;
                case 547:
                    name = "Soul of Fright";
                    width = 18;
                    height = 18;
                    maxStack = 250;
                    value = 100000;
                    rare = 5;
                    toolTip = "'The essence of pure terror'";
                    break;
                case 548:
                    name = "Soul of Might";
                    width = 18;
                    height = 18;
                    maxStack = 250;
                    value = 100000;
                    rare = 5;
                    toolTip = "'The essence of the destroyer'";
                    break;
                case 549:
                    name = "Soul of Sight";
                    width = 18;
                    height = 18;
                    maxStack = 250;
                    value = 100000;
                    rare = 5;
                    toolTip = "'The essence of omniscient watchers'";
                    break;
                case 550:
                    name = "Gungnir";
                    useStyle = 5;
                    useAnimation = 22;
                    useTime = 22;
                    shootSpeed = 5.6f;
                    knockBack = 6.4f;
                    width = 40;
                    height = 40;
                    damage = 42;
                    scale = 1.1f;
                    useSound = 1;
                    shoot = 105;
                    rare = 5;
                    value = 1500000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    break;
                case 551:
                    name = "Hallowed Plate Mail";
                    width = 18;
                    height = 18;
                    defense = 15;
                    bodySlot = 24;
                    rare = 5;
                    value = 200000;
                    toolTip = "7% increased critical strike chance";
                    break;
                case 552:
                    name = "Hallowed Greaves";
                    width = 18;
                    height = 18;
                    defense = 11;
                    legSlot = 23;
                    rare = 5;
                    value = 150000;
                    toolTip = "7% increased damage";
                    toolTip2 = "8% increased movement speed";
                    break;
                case 553:
                    name = "Hallowed Helmet";
                    width = 18;
                    height = 18;
                    defense = 9;
                    headSlot = 41;
                    rare = 5;
                    value = 250000;
                    toolTip = "15% increased ranged damage";
                    toolTip2 = "8% increased ranged critical strike chance";
                    break;
                case 558:
                    name = "Hallowed Headgear";
                    width = 18;
                    height = 18;
                    defense = 5;
                    headSlot = 42;
                    rare = 5;
                    value = 250000;
                    toolTip = "Increases maximum mana by 100";
                    toolTip2 = "12% increased magic damage and critical strike chance";
                    break;
                case 559:
                    name = "Hallowed Mask";
                    width = 18;
                    height = 18;
                    defense = 24;
                    headSlot = 43;
                    rare = 5;
                    value = 250000;
                    toolTip = "10% increased melee damage and critical strike chance";
                    toolTip2 = "10% increased melee haste";
                    break;
                case 554:
                    name = "Cross Necklace";
                    width = 20;
                    height = 24;
                    value = 1500;
                    toolTip = "Increases length of invincibility after taking damage";
                    accessory = true;
                    rare = 4;
                    break;
                case 555:
                    name = "Mana Flower";
                    width = 20;
                    height = 24;
                    value = 1500;
                    toolTip = "8% reduced mana usage";
                    toolTip2 = "Automatically use mana potions when needed";
                    accessory = true;
                    rare = 4;
                    break;
                case 556:
                    useStyle = 4;
                    name = "Mechanical Worm";
                    width = 22;
                    height = 14;
                    consumable = true;
                    useAnimation = 45;
                    useTime = 45;
                    maxStack = 20;
                    toolTip = "Summons Destroyer";
                    rare = 3;
                    break;
                case 557:
                    useStyle = 4;
                    name = "Mechanical Skull";
                    width = 22;
                    height = 14;
                    consumable = true;
                    useAnimation = 45;
                    useTime = 45;
                    maxStack = 20;
                    toolTip = "Summons Skeletron Prime";
                    rare = 3;
                    break;
                case 560:
                    useStyle = 4;
                    name = "Slime Crown";
                    width = 22;
                    height = 14;
                    consumable = true;
                    useAnimation = 45;
                    useTime = 45;
                    maxStack = 20;
                    toolTip = "Summons King Slime";
                    rare = 1;
                    break;
                case 561:
                    melee = true;
                    autoReuse = true;
                    noMelee = true;
                    useStyle = 1;
                    name = "Light Disc";
                    shootSpeed = 13f;
                    shoot = 106;
                    damage = 35;
                    knockBack = 8f;
                    width = 24;
                    height = 24;
                    useSound = 1;
                    useAnimation = 15;
                    useTime = 15;
                    noUseGraphic = true;
                    rare = 5;
                    maxStack = 5;
                    value = 500000;
                    toolTip = "Stacks up to 5";
                    break;
                case 562:
                    name = "Music Box (Overworld Day)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 0;
                    width = 24;
                    height = 24;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    break;
                case 563:
                    name = "Music Box (Eerie)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 1;
                    width = 24;
                    height = 24;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    break;
                case 564:
                    name = "Music Box (Night)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 2;
                    width = 24;
                    height = 24;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    break;
                case 565:
                    name = "Music Box (Title)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 3;
                    width = 24;
                    height = 24;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    break;
                case 566:
                    name = "Music Box (Underground)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 4;
                    width = 24;
                    height = 24;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    break;
                case 567:
                    name = "Music Box (Boss 1)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 5;
                    width = 24;
                    height = 24;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    break;
                case 568:
                    name = "Music Box (Jungle)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 6;
                    width = 24;
                    height = 24;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    break;
                case 569:
                    name = "Music Box (Corruption)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 7;
                    width = 24;
                    height = 24;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    break;
                case 570:
                    name = "Music Box (Underground Corruption)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 8;
                    width = 24;
                    height = 24;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    break;
                case 571:
                    name = "Music Box (The Hallow)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 9;
                    width = 24;
                    height = 24;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    break;
                case 572:
                    name = "Music Box (Boss 2)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 10;
                    width = 24;
                    height = 24;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    break;
                case 573:
                    name = "Music Box (Underground Hallow)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 11;
                    width = 24;
                    height = 24;
                    rare = 4;
                    value = 100000;
                    accessory = true;
                    break;
                case 574:
                    name = "Music Box (Boss 3)";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    consumable = true;
                    createTile = 139;
                    placeStyle = 12;
                    width = 24;
                    height = 24;
                    rare = 3;
                    value = 100000;
                    accessory = true;
                    break;
                case 575:
                    name = "Soul of Flight";
                    width = 18;
                    height = 18;
                    maxStack = 250;
                    value = 1000;
                    rare = 3;
                    toolTip = "'The essence of powerful flying creatures'";
                    break;
                case 576:
                    name = "Music Box";
                    width = 24;
                    height = 24;
                    rare = 3;
                    toolTip = "Has a chance to record songs";
                    value = 100000;
                    accessory = true;
                    break;
                case 577:
                    name = "Demonite Brick";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 140;
                    width = 12;
                    height = 12;
                    break;
                case 578:
                    useStyle = 5;
                    autoReuse = true;
                    useAnimation = 19;
                    useTime = 19;
                    name = "Hallowed Repeater";
                    width = 50;
                    height = 18;
                    shoot = 1;
                    useAmmo = 1;
                    useSound = 5;
                    damage = 39;
                    shootSpeed = 11f;
                    noMelee = true;
                    value = 200000;
                    ranged = true;
                    rare = 4;
                    knockBack = 2.5f;
                    break;
                case 579:
                    name = "Hamdrax";
                    useStyle = 5;
                    useAnimation = 25;
                    useTime = 7;
                    shootSpeed = 36f;
                    knockBack = 4.75f;
                    width = 20;
                    height = 12;
                    damage = 35;
                    pick = 200;
                    axe = 22;
                    hammer = 85;
                    useSound = 23;
                    shoot = 107;
                    rare = 4;
                    value = 220000;
                    noMelee = true;
                    noUseGraphic = true;
                    melee = true;
                    channel = true;
                    toolTip = "'Not to be confused with a hamsaw'";
                    break;
                case 580:
                    mech = true;
                    name = "Explosives";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 141;
                    width = 12;
                    height = 12;
                    toolTip = "Explodes when activated";
                    break;
                case 581:
                    mech = true;
                    name = "Inlet Pump";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 142;
                    width = 12;
                    height = 12;
                    toolTip = "Sends water to outlet pumps";
                    break;
                case 582:
                    mech = true;
                    name = "Outlet Pump";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 250;
                    consumable = true;
                    createTile = 143;
                    width = 12;
                    height = 12;
                    toolTip = "Receives water from inlet pumps";
                    break;
                case 583:
                    mech = true;
                    noWet = true;
                    name = "1 Second Timer";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 144;
                    placeStyle = 0;
                    width = 10;
                    height = 12;
                    value = 50;
                    toolTip = "Activates every second";
                    break;
                case 584:
                    mech = true;
                    noWet = true;
                    name = "3 Second Timer";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 144;
                    placeStyle = 1;
                    width = 10;
                    height = 12;
                    value = 50;
                    toolTip = "Activates every 3 seconds";
                    break;
                case 585:
                    mech = true;
                    noWet = true;
                    name = "5 Second Timer";
                    useStyle = 1;
                    useTurn = true;
                    useAnimation = 15;
                    useTime = 10;
                    autoReuse = true;
                    maxStack = 99;
                    consumable = true;
                    createTile = 144;
                    placeStyle = 2;
                    width = 10;
                    height = 12;
                    value = 50;
                    toolTip = "Activates every 5 seconds";
                    break;
            }
            if (!noMatCheck)
            {
                checkMat();
            }
            netID = type;
        }

        public void netDefaults(int Type)
        {
            RealnetDefaults(Type);
            ItemHooks.OnNetDefaults(ref Type, this);
        }

        public void SetDefaults(int Type, bool noMatCheck = false)
        {
            RealSetDefaults(Type, noMatCheck);
            ItemHooks.OnSetDefaultsInt(ref Type, this);
        }

        public void SetDefaults(string ItemName)
        {
            RealSetDefaults(ItemName);
            ItemHooks.OnSetDefaultsString(ref ItemName, this);
        }

        public static string VersionName(string oldName, int release)
        {
            string result = oldName;
            if (release <= 4)
            {
                switch (oldName)
                {
                    case "Cobalt Helmet":
                        result = "Jungle Hat";
                        break;
                    case "Cobalt Breastplate":
                        result = "Jungle Shirt";
                        break;
                    case "Cobalt Greaves":
                        result = "Jungle Pants";
                        break;
                }
            }
            if (release <= 13 && oldName == "Jungle Rose")
            {
                result = "Jungle Spores";
            }
            if (release <= 20)
            {
                switch (oldName)
                {
                    case "Gills potion":
                        result = "Gills Potion";
                        break;
                    case "Thorn Chakrum":
                        result = "Thorn Chakram";
                        break;
                    case "Ball 'O Hurt":
                        result = "Ball O' Hurt";
                        break;
                }
            }
            return result;
        }

        public Color GetAlpha(Color newColor)
        {
            if (type == 75)
            {
                return new Color(255, 255, 255, newColor.A - alpha);
            }
            if (type == 121 || type == 122 || type == 217 || type == 218 || type == 219 || type == 220 || type == 120 || type == 119)
            {
                return new Color(255, 255, 255, 255);
            }
            if (type == 501)
            {
                return new Color(200, 200, 200, 50);
            }
            if (type == 520 || type == 521 || type == 522 || type == 547 || type == 548 || type == 549 || type == 575)
            {
                return new Color(255, 255, 255, 50);
            }
            if (type == 58 || type == 184)
            {
                return new Color(200, 200, 200, 2000);
            }
            float num = (255 - alpha)/255f;
            var r = (int) (newColor.R*num);
            var g = (int) (newColor.G*num);
            var b = (int) (newColor.B*num);
            int num2 = newColor.A - alpha;
            if (num2 < 0)
            {
                num2 = 0;
            }
            if (num2 > 255)
            {
                num2 = 255;
            }
            if (type >= 198 && type <= 203)
            {
                return Color.White;
            }
            return new Color(r, g, b, num2);
        }

        public Color GetColor(Color newColor)
        {
            int num = (color.R - (255 - newColor.R));
            int num2 = (color.G - (255 - newColor.G));
            int num3 = (color.B - (255 - newColor.B));
            int num4 = (color.A - (255 - newColor.A));
            if (num < 0)
            {
                num = 0;
            }
            if (num > 255)
            {
                num = 255;
            }
            if (num2 < 0)
            {
                num2 = 0;
            }
            if (num2 > 255)
            {
                num2 = 255;
            }
            if (num3 < 0)
            {
                num3 = 0;
            }
            if (num3 > 255)
            {
                num3 = 255;
            }
            if (num4 < 0)
            {
                num4 = 0;
            }
            if (num4 > 255)
            {
                num4 = 255;
            }
            return new Color(num, num2, num3, num4);
        }

        public static bool MechSpawn(float x, float y, int type)
        {
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            for (int i = 0; i < 200; i++)
            {
                if (Main.item[i].active && Main.item[i].type == type)
                {
                    num++;
                    var vector = new Vector2(x, y);
                    float num4 = Main.item[i].position.X - vector.X;
                    float num5 = Main.item[i].position.Y - vector.Y;
                    var num6 = (float) Math.Sqrt((num4*num4 + num5*num5));
                    if (num6 < 300f)
                    {
                        num2++;
                    }
                    if (num6 < 800f)
                    {
                        num3++;
                    }
                }
            }
            return num2 < 3 && num3 < 6 && num < 10;
        }

        public void UpdateItem(int i)
        {
            if (active)
            {
                if (Main.netMode == 0)
                {
                    owner = Main.myPlayer;
                }
                float num = 0.1f;
                float num2 = 7f;
                int num3 = (int) (position.X + (width/2))/16;
                int num4 = (int) (position.Y + (height/2))/16;
                if (Main.tile[num3, num4] == null)
                {
                    num = 0f;
                    velocity.X = 0f;
                    velocity.Y = 0f;
                }
                if (wet)
                {
                    num2 = 5f;
                    num = 0.08f;
                }
                Vector2 value = velocity*0.5f;
                if (ownTime > 0)
                {
                    ownTime--;
                }
                else
                {
                    ownIgnore = -1;
                }
                if (keepTime > 0)
                {
                    keepTime--;
                }
                if (!beingGrabbed)
                {
                    if (type == 520 || type == 521 || type == 547 || type == 548 || type == 549 || type == 575)
                    {
                        velocity.X = velocity.X*0.95f;
                        if (velocity.X < 0.1 && velocity.X > -0.1)
                        {
                            velocity.X = 0f;
                        }
                        velocity.Y = velocity.Y*0.95f;
                        if (velocity.Y < 0.1 && velocity.Y > -0.1)
                        {
                            velocity.Y = 0f;
                        }
                    }
                    else
                    {
                        velocity.Y = velocity.Y + num;
                        if (velocity.Y > num2)
                        {
                            velocity.Y = num2;
                        }
                        velocity.X = velocity.X*0.95f;
                        if (velocity.X < 0.1 && velocity.X > -0.1)
                        {
                            velocity.X = 0f;
                        }
                    }
                    bool flag = Collision.LavaCollision(position, width, height);
                    if (flag)
                    {
                        lavaWet = true;
                    }
                    bool flag2 = Collision.WetCollision(position, width, height);
                    if (flag2)
                    {
                        if (!wet)
                        {
                            if (wetCount == 0)
                            {
                                wetCount = 20;
                                if (!flag)
                                {
                                    for (int j = 0; j < 10; j++)
                                    {
                                        int num5 = Dust.NewDust(new Vector2(position.X - 6f, position.Y + (height/2) - 8f), width + 12, 24, 33, 0f, 0f, 0, default(Color), 1f);
                                        Dust expr_35E_cp_0 = Main.dust[num5];
                                        expr_35E_cp_0.velocity.Y = expr_35E_cp_0.velocity.Y - 4f;
                                        Dust expr_37C_cp_0 = Main.dust[num5];
                                        expr_37C_cp_0.velocity.X = expr_37C_cp_0.velocity.X*2.5f;
                                        Main.dust[num5].scale = 1.3f;
                                        Main.dust[num5].alpha = 100;
                                        Main.dust[num5].noGravity = true;
                                    }
                                    Main.PlaySound(19, (int) position.X, (int) position.Y, 1);
                                }
                                else
                                {
                                    for (int k = 0; k < 5; k++)
                                    {
                                        int num6 = Dust.NewDust(new Vector2(position.X - 6f, position.Y + (height/2) - 8f), width + 12, 24, 35, 0f, 0f, 0, default(Color), 1f);
                                        Dust expr_464_cp_0 = Main.dust[num6];
                                        expr_464_cp_0.velocity.Y = expr_464_cp_0.velocity.Y - 1.5f;
                                        Dust expr_482_cp_0 = Main.dust[num6];
                                        expr_482_cp_0.velocity.X = expr_482_cp_0.velocity.X*2.5f;
                                        Main.dust[num6].scale = 1.3f;
                                        Main.dust[num6].alpha = 100;
                                        Main.dust[num6].noGravity = true;
                                    }
                                    Main.PlaySound(19, (int) position.X, (int) position.Y, 1);
                                }
                            }
                            wet = true;
                        }
                    }
                    else
                    {
                        if (wet)
                        {
                            wet = false;
                        }
                    }
                    if (!wet)
                    {
                        lavaWet = false;
                    }
                    if (wetCount > 0)
                    {
                        wetCount -= 1;
                    }
                    if (wet)
                    {
                        if (wet)
                        {
                            Vector2 vector = velocity;
                            velocity = Collision.TileCollision(position, velocity, width, height, false, false);
                            if (velocity.X != vector.X)
                            {
                                value.X = velocity.X;
                            }
                            if (velocity.Y != vector.Y)
                            {
                                value.Y = velocity.Y;
                            }
                        }
                    }
                    else
                    {
                        velocity = Collision.TileCollision(position, velocity, width, height, false, false);
                    }
                    if (lavaWet)
                    {
                        if (type == 267)
                        {
                            if (Main.netMode != 1)
                            {
                                active = false;
                                type = 0;
                                name = "";
                                stack = 0;
                                for (int l = 0; l < 200; l++)
                                {
                                    if (Main.npc[l].active && Main.npc[l].type == 22)
                                    {
                                        if (Main.netMode == 2)
                                        {
                                            NetMessage.SendData(28, -1, -1, "", l, 9999f, 10f, (-(float) Main.npc[l].direction), 0);
                                        }
                                        Main.npc[l].StrikeNPC(9999, 10f, -Main.npc[l].direction, false, false);
                                        NPC.SpawnWOF(position);
                                    }
                                }
                                NetMessage.SendData(21, -1, -1, "", i, 0f, 0f, 0f, 0);
                            }
                        }
                        else
                        {
                            if (owner == Main.myPlayer && type != 312 && type != 318 && type != 173 && type != 174 && type != 175 && rare == 0)
                            {
                                active = false;
                                type = 0;
                                name = "";
                                stack = 0;
                                if (Main.netMode != 0)
                                {
                                    NetMessage.SendData(21, -1, -1, "", i, 0f, 0f, 0f, 0);
                                }
                            }
                        }
                    }
                    if (type == 520)
                    {
                        float num7 = Main.rand.Next(90, 111)*0.01f;
                        num7 *= Main.essScale;
                        Lighting.addLight((int) ((position.X + (width/2))/16f), (int) ((position.Y + (height/2))/16f), 0.5f*num7, 0.1f*num7, 0.25f*num7);
                    }
                    else
                    {
                        if (type == 521)
                        {
                            float num8 = Main.rand.Next(90, 111)*0.01f;
                            num8 *= Main.essScale;
                            Lighting.addLight((int) ((position.X + (width/2))/16f), (int) ((position.Y + (height/2))/16f), 0.25f*num8, 0.1f*num8, 0.5f*num8);
                        }
                        else
                        {
                            if (type == 547)
                            {
                                float num9 = Main.rand.Next(90, 111)*0.01f;
                                num9 *= Main.essScale;
                                Lighting.addLight((int) ((position.X + (width/2))/16f), (int) ((position.Y + (height/2))/16f), 0.5f*num9, 0.3f*num9, 0.05f*num9);
                            }
                            else
                            {
                                if (type == 548)
                                {
                                    float num10 = Main.rand.Next(90, 111)*0.01f;
                                    num10 *= Main.essScale;
                                    Lighting.addLight((int) ((position.X + (width/2))/16f), (int) ((position.Y + (height/2))/16f), 0.1f*num10, 0.1f*num10, 0.6f*num10);
                                }
                                else
                                {
                                    if (type == 575)
                                    {
                                        float num11 = Main.rand.Next(90, 111)*0.01f;
                                        num11 *= Main.essScale;
                                        Lighting.addLight((int) ((position.X + (width/2))/16f), (int) ((position.Y + (height/2))/16f), 0.1f*num11, 0.3f*num11, 0.5f*num11);
                                    }
                                    else
                                    {
                                        if (type == 549)
                                        {
                                            float num12 = Main.rand.Next(90, 111)*0.01f;
                                            num12 *= Main.essScale;
                                            Lighting.addLight((int) ((position.X + (width/2))/16f), (int) ((position.Y + (height/2))/16f), 0.1f*num12, 0.5f*num12, 0.2f*num12);
                                        }
                                        else
                                        {
                                            if (type == 58)
                                            {
                                                float num13 = Main.rand.Next(90, 111)*0.01f;
                                                num13 *= Main.essScale*0.5f;
                                                Lighting.addLight((int) ((position.X + (width/2))/16f), (int) ((position.Y + (height/2))/16f), 0.5f*num13, 0.1f*num13, 0.1f*num13);
                                            }
                                            else
                                            {
                                                if (type == 184)
                                                {
                                                    float num14 = Main.rand.Next(90, 111)*0.01f;
                                                    num14 *= Main.essScale*0.5f;
                                                    Lighting.addLight((int) ((position.X + (width/2))/16f), (int) ((position.Y + (height/2))/16f), 0.1f*num14, 0.1f*num14, 0.5f*num14);
                                                }
                                                else
                                                {
                                                    if (type == 522)
                                                    {
                                                        float num15 = Main.rand.Next(90, 111)*0.01f;
                                                        num15 *= Main.essScale*0.2f;
                                                        Lighting.addLight((int) ((position.X + (width/2))/16f), (int) ((position.Y + (height/2))/16f), 0.5f*num15, 1f*num15, 0.1f*num15);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (type == 75 && Main.dayTime)
                    {
                        for (int m = 0; m < 10; m++)
                        {
                            Dust.NewDust(position, width, height, 15, velocity.X, velocity.Y, 150, default(Color), 1.2f);
                        }
                        for (int n = 0; n < 3; n++)
                        {
                            Gore.NewGore(position, new Vector2(velocity.X, velocity.Y), Main.rand.Next(16, 18), 1f);
                        }
                        active = false;
                        type = 0;
                        stack = 0;
                        if (Main.netMode == 2)
                        {
                            NetMessage.SendData(21, -1, -1, "", i, 0f, 0f, 0f, 0);
                        }
                    }
                }
                else
                {
                    beingGrabbed = false;
                }
                if (type == 501)
                {
                    if (Main.rand.Next(6) == 0)
                    {
                        int num16 = Dust.NewDust(position, width, height, 55, 0f, 0f, 200, color, 1f);
                        Dust expr_DC0 = Main.dust[num16];
                        expr_DC0.velocity *= 0.3f;
                        Main.dust[num16].scale *= 0.5f;
                    }
                }
                else
                {
                    if (type == 8 || type == 105)
                    {
                        if (!wet)
                        {
                            Lighting.addLight((int) ((position.X + (width/2))/16f), (int) ((position.Y + (height/2))/16f), 1f, 0.95f, 0.8f);
                        }
                    }
                    else
                    {
                        if (type == 523)
                        {
                            if (!wet)
                            {
                                Lighting.addLight((int) ((position.X + (width/2))/16f), (int) ((position.Y + (height/2))/16f), 0.85f, 1f, 0.7f);
                            }
                        }
                        else
                        {
                            if (type >= 427 && type <= 432)
                            {
                                if (!wet)
                                {
                                    float r = 0f;
                                    float g = 0f;
                                    float b = 0f;
                                    int num17 = type - 426;
                                    if (num17 == 1)
                                    {
                                        r = 0.1f;
                                        g = 0.2f;
                                        b = 1.1f;
                                    }
                                    if (num17 == 2)
                                    {
                                        r = 1f;
                                        g = 0.1f;
                                        b = 0.1f;
                                    }
                                    if (num17 == 3)
                                    {
                                        r = 0f;
                                        g = 1f;
                                        b = 0.1f;
                                    }
                                    if (num17 == 4)
                                    {
                                        r = 0.9f;
                                        g = 0f;
                                        b = 0.9f;
                                    }
                                    if (num17 == 5)
                                    {
                                        r = 1.3f;
                                        g = 1.3f;
                                        b = 1.3f;
                                    }
                                    if (num17 == 6)
                                    {
                                        r = 0.9f;
                                        g = 0.9f;
                                        b = 0f;
                                    }
                                    Lighting.addLight((int) ((position.X + (width/2))/16f), (int) ((position.Y + (height/2))/16f), r, g, b);
                                }
                            }
                            else
                            {
                                if (type == 41)
                                {
                                    if (!wet)
                                    {
                                        Lighting.addLight((int) ((position.X + width)/16f), (int) ((position.Y + (height/2))/16f), 1f, 0.75f, 0.55f);
                                    }
                                }
                                else
                                {
                                    if (type == 282)
                                    {
                                        Lighting.addLight((int) ((position.X + width)/16f), (int) ((position.Y + (height/2))/16f), 0.7f, 1f, 0.8f);
                                    }
                                    else
                                    {
                                        if (type == 286)
                                        {
                                            Lighting.addLight((int) ((position.X + width)/16f), (int) ((position.Y + (height/2))/16f), 0.7f, 0.8f, 1f);
                                        }
                                        else
                                        {
                                            if (type == 331)
                                            {
                                                Lighting.addLight((int) ((position.X + width)/16f), (int) ((position.Y + (height/2))/16f), 0.55f, 0.75f, 0.6f);
                                            }
                                            else
                                            {
                                                if (type == 183)
                                                {
                                                    Lighting.addLight((int) ((position.X + width)/16f), (int) ((position.Y + (height/2))/16f), 0.15f, 0.45f, 0.9f);
                                                }
                                                else
                                                {
                                                    if (type == 75)
                                                    {
                                                        Lighting.addLight((int) ((position.X + width)/16f), (int) ((position.Y + (height/2))/16f), 0.8f, 0.7f, 0.1f);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (type == 75)
                {
                    if (Main.rand.Next(25) == 0)
                    {
                        Dust.NewDust(position, width, height, 58, velocity.X*0.5f, velocity.Y*0.5f, 150, default(Color), 1.2f);
                    }
                    if (Main.rand.Next(50) == 0)
                    {
                        Gore.NewGore(position, new Vector2(velocity.X*0.2f, velocity.Y*0.2f), Main.rand.Next(16, 18), 1f);
                    }
                }
                if (spawnTime < 2147483646)
                {
                    spawnTime++;
                }
                if (Main.netMode == 2 && owner != Main.myPlayer)
                {
                    release++;
                    if (release >= 300)
                    {
                        release = 0;
                        NetMessage.SendData(39, owner, -1, "", i, 0f, 0f, 0f, 0);
                    }
                }
                if (wet)
                {
                    position += value;
                }
                else
                {
                    position += velocity;
                }
                if (noGrabDelay > 0)
                {
                    noGrabDelay--;
                }
            }
        }

        public static int NewItem(int X, int Y, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int pfix = 0)
        {
            if (Main.rand == null)
            {
                Main.rand = new Random();
            }
            if (WorldGen.gen)
            {
                return 0;
            }
            int num = 200;
            Main.item[200] = new Item();
            if (Main.netMode != 1)
            {
                for (int i = 0; i < 200; i++)
                {
                    if (!Main.item[i].active)
                    {
                        num = i;
                        break;
                    }
                }
            }
            if (num == 200 && Main.netMode != 1)
            {
                int num2 = 0;
                for (int j = 0; j < 200; j++)
                {
                    if (Main.item[j].spawnTime > num2)
                    {
                        num2 = Main.item[j].spawnTime;
                        num = j;
                    }
                }
            }
            Main.item[num] = new Item();
            Main.item[num].SetDefaults(Type, false);
            Main.item[num].Prefix(pfix);
            Main.item[num].position.X = (X + Width/2 - Main.item[num].width/2);
            Main.item[num].position.Y = (Y + Height/2 - Main.item[num].height/2);
            Main.item[num].wet = Collision.WetCollision(Main.item[num].position, Main.item[num].width, Main.item[num].height);
            Main.item[num].velocity.X = Main.rand.Next(-30, 31)*0.1f;
            Main.item[num].velocity.Y = Main.rand.Next(-40, -15)*0.1f;
            if (Type == 520 || Type == 521)
            {
                Main.item[num].velocity.X = Main.rand.Next(-30, 31)*0.1f;
                Main.item[num].velocity.Y = Main.rand.Next(-30, 31)*0.1f;
            }
            Main.item[num].active = true;
            Main.item[num].spawnTime = 0;
            Main.item[num].stack = Stack;
            if (Main.netMode == 2 && !noBroadcast)
            {
                NetMessage.SendData(21, -1, -1, "", num, 0f, 0f, 0f, 0);
                Main.item[num].FindOwner(num);
            }
            else
            {
                if (Main.netMode == 0)
                {
                    Main.item[num].owner = Main.myPlayer;
                }
            }
            return num;
        }

        public void FindOwner(int whoAmI)
        {
            if (keepTime > 0)
            {
                return;
            }
            int num = owner;
            owner = 255;
            float num2 = -1f;
            for (int i = 0; i < 255; i++)
            {
                if (ownIgnore != i && Main.player[i].active && Main.player[i].ItemSpace(Main.item[whoAmI]))
                {
                    float num3 = Math.Abs(Main.player[i].position.X + (Main.player[i].width/2) - position.X - (width/2)) + Math.Abs(Main.player[i].position.Y + (Main.player[i].height/2) - position.Y - height);
                    if (num3 < NPC.sWidth && (num2 == -1f || num3 < num2))
                    {
                        num2 = num3;
                        owner = i;
                    }
                }
            }
            if (owner != num && ((num == Main.myPlayer && Main.netMode == 1) || (num == 255 && Main.netMode == 2) || !Main.player[num].active))
            {
                NetMessage.SendData(21, -1, -1, "", whoAmI, 0f, 0f, 0f, 0);
                if (active)
                {
                    NetMessage.SendData(22, -1, -1, "", whoAmI, 0f, 0f, 0f, 0);
                }
            }
        }

        public object Clone()
        {
            return base.MemberwiseClone();
        }

        public bool IsTheSameAs(Item compareItem)
        {
            return name == compareItem.name;
        }

        public bool IsNotTheSameAs(Item compareItem)
        {
            return name != compareItem.name || stack != compareItem.stack || prefix != compareItem.prefix;
        }
    }
}