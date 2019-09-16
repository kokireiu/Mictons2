namespace Microns.Player
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class player : IPlayer
    {
        private string Name;
        private int HP;
        private int MP;
        private int ATK;
        private int DEF;
        private int SPD;
        
        string IPlayer.Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }

        int IPlayer.HP
        {
            get
            {
                return this.HP;
            }
            set
            {
                this.HP = value;
            }
        }

        int IPlayer.MP
        {
            get
            {
                return this.MP;
            }
            set
            {
                this.MP = value;
            }
        }

        int IPlayer.ATK
        {
            get
            {
                return this.ATK;
            }
            set
            {
                this.ATK = value;
            }
        }

        int IPlayer.DEF
        {
            get
            {
                return this.DEF;
            }
            set
            {
                this.DEF = value;
            }
        }

        int IPlayer.SPD
        {
            get
            {
                return this.SPD;
            }
            set
            {
                this.DEF = value;
            }
        }
    }
}

