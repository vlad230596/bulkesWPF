﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Bulkes
{
    class Settings
    {
        //------------------ScreenParameters--------------------
        public const int ScreenWidthDefault = 960;
        public const int ScreenHeightDefault = 540;
        //--------------------Game--------------------
        public const int TimerInterval = 25;
        public static int TimeDelayFirstNewFood = 10;
        public static float PriorityValue = 0.5f;
        public static Color GameFieldColor = Colors.Black;
        //--------------------User--------------------------------
        public static float UserStartSize = 100f;


        public static Color UserDefaultColor = Colors.Red;

        public static int UserDefaultColorIndex = 0;



        public static float BulkBaseSize = 100f;//for indicator and speed
        public static float UserMaxRadius = 200f;
        public static float UserSpeedCoefficient = 0.1f;
        public static float UserScale = 1f;
        public static float UserScaleStep = 0.005f;
        //------------------Food--------------------------------
        public static int MinFoodInSector = 0;
        public static int MaxFoodInSector = 6;
        public static int MinFoodSize = 20;
        public static int MaxFoodSize = 40;
        public static int BaseFoodSize = (MaxFoodSize - MinFoodSize) / 2;
        public static int FoodDefaultFeed = 1500;
        public static int FoodFeedForRadius = 20;
        //------------------Map----------------------------------
        public const int MapWidthP = Settings.MapSizeX * Settings.ScreenWidthDefault;
        public const int MapHeightP = Settings.MapSizeY * Settings.ScreenHeightDefault;
        public static int CountSectorX = 3;
        public static int CountSectorY = 3;
        public const int MapSizeX = 3;
        public const int MapSizeY = 3;
        public static float StepRadius = 0.01f;
        public static float UnitToTargetCoefficient = 1.5f;
        public static float MinFoodSpeed = 2f;
        public static int MaxTotalFeed = MaxFoodSize * FoodFeedForRadius * MaxFoodInSector * 2;
        public static Color BulkDefaultColor = Colors.Yellow;
        public static float BulkOffsetRadius = 2f;//min difference between bulkes for move
        //------------------Enemy--------------------------------
        public static int EnemyMaxStepToTarget = 10;
        public static int EnemyFindOffset = 500;
        public static float EnemyStepValue = 5f;
        public static Color EnemyDefaultColor = Colors.Magenta;
        //------------------Dialogs---------------------------------
        public static int DialogPauseID = 0;
        public static int DialogEndID = 1;
        public static int DialogGameOverID = 2;
        //------------------Colors----------------------------------
        public static Color[] ColorList = {
            Color.FromRgb(0xFF,0xA5,0x00),//#FFA500 orange
            Color.FromRgb(0x1F,0x57,0xB3),//#1f57b3 blue
            Color.FromRgb(0xFF,0x73,0x73),//#ff7373 pink
            Color.FromRgb(0xCC,0xFF,0x00),//#ccff00 light green
            Color.FromRgb(0x33,0x99,0xFF),//#3399ff light blue
            Color.FromRgb(0x64,0x95,0xED),//#6495ed light blue
            Color.FromRgb(0x8A,0x2B,0xE2),//#8a2be2 magenta
            Color.FromRgb(0x7B,0xC0,0x43),//#7bc043 green
            Color.FromRgb(0xFB,0xE5,0x66),//#fbe566 light yellow
            Color.FromRgb(0xFF,0xA7,0x00)//#ffa700 gold
        };
        public static int getCountColors()
        {
            return ColorList.Length;
        }
        public static Color[] UsersBulkColors = {
            Color.FromRgb(239,48,56),//red
            Color.FromRgb(240,108,0),//orange
            Color.FromRgb(255,255,0),//yellow
            Color.FromRgb(191,255,0),//light green
            Color.FromRgb(0,255,255),//cyan
            Color.FromRgb(29,172,214),//blue Krayola
            Color.FromRgb(147,112,216),//purpur
            Color.FromRgb(184,143,255)//violet
        };
    }
}
