﻿using Drones.Helpers;
using Drones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Building
{
    private int PosX {  get; set; }
    private int PosY {  get; set; }
    private int Largeur {  get; set; }
    private int Profondeur {  get; set; }
    private string Color {  get; set; }

    private List<Building> Buildings;

    public Building(int x, int y, int largeur, int profondeur, string clr) 
    {
        PosX = x;
        PosY = y;
        Largeur = largeur;
        Profondeur = profondeur;
        Color = clr;
    }


}