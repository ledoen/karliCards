using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardAndDeck
{
    public class Deck : ICloneable
    {
        #region 字段
        private Cards cards = new Cards();
        #endregion

        #region 构造函数
        private Deck(Cards newCards)
        {
            cards = newCards;
        }
        /// <summary>
        /// 初始化字段cards，产生一副有序的含有52张扑克的牌
        /// </summary>
        public Deck()
        {
            for (int i = 0; i <= (int)Suit.Spade; i++)
            {
                for (int j = 1; j <= (int)Rank.King; j++)
                {
                    cards.Add(new Card((Suit)i,(Rank)j));
                }
            }
        }

        public Deck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        public Deck(bool useTrumps, Suit trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public Deck(bool isAceHigh, bool useTrumps, Suit trump) : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }
        #endregion 

        /// <summary>
        /// 按照序号从cards中发一张牌
        /// </summary>
        /// <param name="cardNum"></param>
        /// <returns></returns>
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum < 52)
            {
                return cards[cardNum];
            }
            else
                throw
                    (new System.ArgumentOutOfRangeException("cardNum",cardNum,"Value must between 0 and 51"));
        }

        /// <summary>
        /// 将cards中的牌的顺序打乱，实现洗牌的效果
        /// </summary>
        public void Shuffle()
        {
            Cards newCards = new Cards();
            bool[] cardFlag = new bool[52];
            Random random = new Random();

            for (int i = 0; i < 52; i++)
            {
                int n = 0;
                do
                {
                    n = random.Next(52);
                } while (cardFlag[n] == true);
                newCards.Add(cards[n]);
                cardFlag[n] = true;
            }
            newCards.CopyTo(cards);
        }

        public object Clone()
        {
            Deck newDeck = new Deck(cards.Clone() as Cards);
            return newDeck;
        }
    }
}