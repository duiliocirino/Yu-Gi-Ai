using System.Collections.Generic;
using ConsoleApplication1.Effects;
using ConsoleApplication1.Enums;

namespace ConsoleApplication1
{
    public class Card
    {
        private int _id;
        private Player _originalOwner;
        private Player _owner;
        private string _name;
        private CardType _type;
        private CardTyping _typing;
        private List<IEffect> _effects;
        private bool _negated;
        private Attribute _attribute;
        private string _details;
        private int _levelRank;
        private int _originalAtk;
        private int _originalDef;
        private int _link;
        private int _scale;
        private string _archetype;

        //IN-GAME STATE
        private int _atk;
        private int _def;
        private bool _attackPosition;
        private bool _isNegated;
        

        public Card(int id, Player owner, string name, CardType type, CardTyping typing, List<IEffect> effects, 
            Attribute attribute, string details, int levelRank, int originalAtk, int originalDef, int atk, int def, 
            int link, int scale, string archetype)
        {
            _id = id;
            _originalOwner = owner;
            _owner = owner;
            _name = name;
            _type = type;
            _typing = typing;
            _effects = effects;
            _negated = false;
            _attribute = attribute;
            _details = details;
            _levelRank = levelRank;
            _originalAtk = originalAtk;
            _originalDef = originalDef;
            _atk = atk;
            _def = def;
            _link = link;
            _scale = scale;
            _archetype = archetype;
        }

        public string Name => _name;
        
        
    }
}