namespace Microns.Player
{
    using UnityEngine;

    public interface IPlayer
    {
        string Name{ get; set;}

        int HP{ get; set;}

        int MP{ get; set;}

        int ATK{ get; set;}

        int DEF{ get; set;}

        int SPD{ get; set;}
    } 
}
