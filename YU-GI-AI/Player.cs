using System;
using System.Collections.Generic;
using ConsoleApplication1.Actions;
using ConsoleApplication1.Utils;
using Action = ConsoleApplication1.Actions.Action;

namespace ConsoleApplication1
{
    public class Player
    {
        private static int _lastId;
        private int _id;
        private int _numInGame;
        private List<Card> _hand;
        private int _lifePoints;
        private List<Card> _deck;
        private List<Card> _extraDeck;
        private List<Action> _possibleActions;

        private int _normalSummonNum;

        public int NormalSummonNum
        {
            get => _normalSummonNum;
            set => _normalSummonNum = value;
        }

        public Player(int id, int numInGame, List<Card> hand, int lifePoints, List<Card> deck, List<Card> extraDeck)
        {
            _id = _lastId;
            _lastId++;
            _numInGame = numInGame;
            _hand = hand;
            _lifePoints = lifePoints;
            _normalSummonNum = 1;
            _deck = deck;
            _extraDeck = extraDeck;
            _possibleActions = new List<Action>();
        }

        public int NumInGame => _numInGame;

        public List<Action> GetActions()
        {
            ComputePossibleActions();
            return _possibleActions;
        }

        private void ComputePossibleActions()
        {
            _possibleActions.Clear();
            _possibleActions.Add(new DoNothing());
            //TODO: implement the rest
        }

        private Action ChooseAction()
        {
            Console.WriteLine(_possibleActions.ToString());
            var input = Console.ReadLine();
            //TODO: control good input
            var actionNum = Int32.Parse(input);
            return _possibleActions[actionNum];
        }

        public void DrawCard()
        {
            if (_deck.Count < 0) Match.EndGame(
                Match.GetNonTurnPlayer(), 
                ToString() + " decked out!\n", 
                false
                );
            else
            {
                Card drawnCard = _deck.RemoveAndReturnFirst();
                _hand.Add(drawnCard);
            }
        }

        public void RemoveCardFromHand(Card card)
        {
            _hand.Remove(card);
        }

        public void ConsumeNormalSummon()
        {
            _normalSummonNum--;
        }
    }
}