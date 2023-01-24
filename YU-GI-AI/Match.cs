using System;
using System.Collections.Generic;
using ConsoleApplication1.Actions;
using ConsoleApplication1.Effects;
using ConsoleApplication1.MatchUtils;
using ConsoleApplication1.MatchUtils.Phases;
using Action = ConsoleApplication1.Actions.Action;

namespace ConsoleApplication1
{
    public class Match
    {
        private int _id = 0;
        private static Player _player1;
        private static Player _player2;
        private static Field _field;
        private int _turn = 1;
        private static Player _turnPlayer;
        private static IPhase _currentPhase;
        private static Chain _currentChain;

        public static Chain CurrentChain => _currentChain;

        private List<IEffect> _lingeringEffects;

        public Match(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
            if (player1.NumInGame == 0) _turnPlayer = player1;
            else _turnPlayer = player2;
            _currentPhase = new DrawPhase();
            _field = new Field(player1, player2);
        }

        public static void EndGame(Player player, string reason, bool draw)
        {
            _currentPhase = new FinalState(player, reason, draw);
        }

        public static Player TurnPlayer => _turnPlayer;

        public static Player GetNonTurnPlayer()
        {
            return _turnPlayer == _player1 ? _player2 : _player1;
        }

        public static FieldSide GetSideFromPlayer(Player player)
        {
            if(player == _player1) return _field.FieldSides[0];
            return _field.FieldSides[1];
        }

        public static void StartBattle(Battle battle)
        {
            //TODO: implement
        }

        public static void StartChain(IEffect firstEffect)
        {
            _currentChain = new Chain(firstEffect);
            _currentChain.BuildChain();
        }

        public static Player GetOtherPlayer(Player player)
        {
            if (player == _player1) return _player2;
            return _player1;
        }

        public static void NormalSummon(NormalSummon normalSummon)
        {
            FieldSide fieldSide = GetSideFromPlayer(normalSummon.Player);
            normalSummon.Player.RemoveCardFromHand(normalSummon.Monster);
            fieldSide.MonsterZone[normalSummon.Position] = normalSummon.Monster;
            normalSummon.Player.ConsumeNormalSummon();
        }
    }
}