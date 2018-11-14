using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infimum.Model
{
    class Deck
    {
        private static readonly Random rand = new Random();
        private List<Card> _cards;

        public Deck()
        {
            _cards = new List<Card>();
        }

        public void Draw()
        {
            
        }

        public void Draw(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Draw();
            }
        }
        public void Shuffle()
        {
            Card holder = new Card();
            int random;

            for (int i = 0; i < _cards.Count; i++)
            {
                random = rand.Next(0, _cards.Count);
                holder = _cards[i];
                _cards[i] = _cards[random];
                _cards[random] = holder;
            }
        }
    }
}
