using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AircraftCarrier
{
    class Aircraft
    {
        protected int MaxAmmo { get; set; }
        protected int CurrentAmmo { get; set; }
        protected int BaseDamage { get; set; }
        protected string Type { get; set; }
     
        protected bool IsPriority { get; set; }

        public void AirCraft(string type, int maxAmmo, int dmg, bool isPrior, int currAmmo)
        {
            Type = type;
            MaxAmmo = maxAmmo;
            BaseDamage = dmg;
            CurrentAmmo = currAmmo;
            IsPriority = isPrior;
        }
        public void AircraftOne()
        {
            Type = "F16";
            MaxAmmo = 8;
            BaseDamage = 30;
            CurrentAmmo = 0;
            IsPriority = false;
        }
        public void AircraftTwo ()
        {
            Type = "F35";
            MaxAmmo = 12;
            BaseDamage = 50;
            CurrentAmmo = 0;
            IsPriority = true;
        }

        public int Fight()
        {
            MaxAmmo = 0;
            return BaseDamage * MaxAmmo;
        }

        public int Refill(int refill)
        {
            refill = 20;
            if(refill > MaxAmmo)
            {
                return refill - MaxAmmo;
            }
            else
            {
                return CurrentAmmo += refill;
            }
        }
        public string GetType()
        {
            return $"Type of a module = {Type}";
        }
        public string GetStatus()
        {
            return $"Type {Type}, Ammo: {CurrentAmmo}, Base Damage: {BaseDamage}, All Damage: {CurrentAmmo * BaseDamage}";
        }
    }
}
