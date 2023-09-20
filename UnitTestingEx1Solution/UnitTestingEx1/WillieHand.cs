namespace UnitTestingEx1
{
    public partial class WillieHand
    {
        /// <summary>
        /// Class to represent a Hand in the card game Willie
        /// </summary>
        private int _CardOne;
        private int _CardTwo;
        private int _Willie;

        /// <summary>
        /// Pass the integer values of the cards as you construct the hand
        /// </summary>
        /// <param name="CardOne">First card in the Willie hand</param>
        /// <param name="CardTwo">Second card in the Willie hand</param>
        /// 
        public WillieHand(int CardOne, int? CardTwo)
        {
            _CardOne = CardOne; _CardTwo = CardTwo.GetValueOrDefault();
        }

        /// <summary>
        /// Willie value of the hand
        /// </summary>
        public int Willie
        {
            get
            {
                if (_CardOne > 10)
                    _Willie = 10;
                else _Willie = _CardOne;
                if (_CardTwo > 10) _Willie += 10;
                else _Willie += _CardTwo; return _Willie;
            }
        }
        public int CardOne { get { return _CardOne; } }
        public int CardTwo { get { return _CardTwo; } }
    }
}