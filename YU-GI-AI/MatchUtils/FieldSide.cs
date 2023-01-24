using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1.MatchUtils
{
    public class FieldSide
    {
        private Player _player;
        private Card[] _monsterZone;
        private Card[] _spellTrapZone;
        private Card _pendScaleL;
        private Card _pendScaleR;
        private Card _fieldSpellZone;
        private List<Card> _graveyard;
        private List<Card> _banishPile;

        public FieldSide(Player player)
        {
            this._player = player;
            _monsterZone = new Card[5];
            _spellTrapZone = new Card[5];
            _graveyard = new List<Card>();
            _banishPile = new List<Card>();
        }

        public Player Player => _player;

        public Card[] MonsterZone => _monsterZone;

        public Card[] SpellTrapZone => _spellTrapZone;

        public Card PendScaleL => _pendScaleL;

        public Card PendScaleR => _pendScaleR;

        public Card FieldSpellZone => _fieldSpellZone;

        public List<Card> Graveyard => _graveyard;

        public List<Card> BanishPile => _banishPile;
    }
}