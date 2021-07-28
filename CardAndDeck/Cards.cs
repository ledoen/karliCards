using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CardAndDeck
{
    public class Cards : CollectionBase, ICloneable
    {
        public void Add(Card newCard)
        {
            List.Add(newCard);
        }

        public Card this[int cardIndex]
        {
            get { return (Card)List[cardIndex]; }
            set { List[cardIndex] = value; }
        }

        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        public bool Contains(Card card)
        {
            return InnerList.Contains(card);
        }

        public object Clone()
        {
            Cards newCards = new Cards();
            foreach (Card card in List)
            {
                newCards.Add((Card)card.Clone());
            }
            return newCards;
        }
    }
}
