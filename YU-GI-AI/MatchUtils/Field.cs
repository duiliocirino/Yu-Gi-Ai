namespace ConsoleApplication1.MatchUtils
{
    public class Field
    {
        private Card _extraMonsterZoneL;
        private Card _extraMonsterZoneR;
        private FieldSide[] _fieldSides;

        public Field(Player player1, Player player2)
        {
            _fieldSides = new FieldSide[2];
            _fieldSides[0] = new FieldSide(player1);
            _fieldSides[1] = new FieldSide(player2);
        }

        public Card ExtraMonsterZoneL
        {
            get => _extraMonsterZoneL;
            set => _extraMonsterZoneL = value;
        }

        public Card ExtraMonsterZoneR
        {
            get => _extraMonsterZoneR;
            set => _extraMonsterZoneR = value;
        }

        public FieldSide[] FieldSides => _fieldSides;
    }
}