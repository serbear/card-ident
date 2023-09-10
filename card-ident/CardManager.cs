using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;

namespace card_ident
{
    internal class CardManager
    {
        string cardClasses = "cdhsj";
        string[] cardTypes = "k,q,j,10,9,8,7,6,5,4,3,2,a".Split(',');

        private readonly Dictionary<char, string> _cardClassNames =
            new Dictionary<char, string>
            {
                { 'c', "Clubs" },
                { 'd', "Diamonds" },
                { 'h', "Hearts" },
                { 's', "Spades" },
                { 'j', "Joker" }
            };

        private readonly Dictionary<char, string> _cardTypeNames =
            new Dictionary<char, string>
            {
                { 'k', "King" },
                { 'q', "Queen" },
                { 'j', "Jack" },
                { 'a', "Ace" }
            };

        private ResourceManager _resourceManager;

        public CardManager(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        public List<Card> GetCardCollection()
        {
            var res = new List<string>();
            FillResourceNames(ref res);
            var cards = new List<Card>();

            res.ForEach(cardType =>
            {
                string cardName = GetCardName(cardType);
                cards.Add(new Card(cardName, ref cardType,
                    ref _resourceManager));
            });

            return cards;
        }

        private string GetCardName(string cardType)
        {
            string currentCardType = cardType.Substring(1, cardType.Length - 1);
            bool isNumeric = int.TryParse(currentCardType, out _);
            string cardName;

            if (cardType.StartsWith("j"))
            {
                return _cardClassNames[cardType[0]];
            }

            if (isNumeric)
            {
                cardName = currentCardType + " of " +
                           _cardClassNames[cardType[0]];
            }
            else
            {
                cardName = _cardTypeNames[cardType[1]] + " of " +
                           _cardClassNames[cardType[0]];
            }

            return cardName;
        }

        private void FillResourceNames(ref List<string> nameCollection)
        {
            for (int i = 0; i < 5; i++)
            {
                // Get random card.
                string cardType = GetRandomCardType();
                
                // Add a new card if there is no the same card in the
                // collection.
                if (!nameCollection.Contains(cardType))
                {
                    nameCollection.Add(cardType);
                }
                else
                {
                    i--;
                }
                
            }
        }

        private string GetRandomCardType()
        {
            Random rnd = new Random();
            int cardClassIndex = rnd.Next(0, cardClasses.Length);
            char nextCardClass = cardClasses[cardClassIndex];
            string cardType;

            if (nextCardClass.ToString().Equals("j"))
            {
                // Joker appears.
                cardType = "j";
            }
            else
            {
                int cardTypeIndex = rnd.Next(0, cardTypes.Length);
                cardType = nextCardClass + cardTypes[cardTypeIndex];
            }

            return cardType;
        }
    }

    internal class Card
    {
        public string name;
        string cardType;
        public Image image;
        ResourceManager resourceManager;

        public Card(string name, ref string cardType,
            ref ResourceManager resourceManager)
        {
            this.name = name;
            this.cardType = cardType;
            this.resourceManager = resourceManager;
            SetIMage(ref cardType);
        }

        private void SetIMage(ref string cardType)
        {
            object y = resourceManager.GetObject(cardType);

            if (y != null)
            {
                image = (Image)y;
            }
            else
            {
                string noCard = "_null";
                SetIMage(ref noCard);
            }
        }
    }
}