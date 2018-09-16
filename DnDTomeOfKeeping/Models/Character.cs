//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DnDTomeOfKeeping.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Character
    {
        public int CharID { get; set; }
        public string CharName { get; set; }
        public int Class { get; set; }
        public int HitPoints { get; set; }
        public string Alignment { get; set; }
        public int CharLevel { get; set; }
        public string Feats { get; set; }
        public string Equipment { get; set; }
        public string Features { get; set; }
        public Nullable<int> Campaign { get; set; }
        public string UserID { get; set; }
        public int Race { get; set; }
        public string SpellsKnown { get; set; }
        public string Proficiencies { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public Nullable<int> SpellSlot1 { get; set; }
        public Nullable<int> SpellSlot2 { get; set; }
        public Nullable<int> SpellSlot3 { get; set; }
        public Nullable<int> SpellSlot4 { get; set; }
        public Nullable<int> SpellSlot5 { get; set; }
        public Nullable<int> SpellSlot6 { get; set; }
        public Nullable<int> SpellSlot7 { get; set; }
        public Nullable<int> SpellSlot8 { get; set; }
        public Nullable<int> SpellSlot9 { get; set; }
        public Nullable<int> Cantrips { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Campaign Campaign1 { get; set; }
    }
}
