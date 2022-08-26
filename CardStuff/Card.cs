namespace CardStuff
{
    public class Card
    {
        private int face;
        private int suit;

        public string[] Faces = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        public string[] Suits = new string[] { "C", "S", "D", "H" };
        public int[] Values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
        
        public Card(int faceIndex, int suitIndex)
        {
            face = faceIndex;
            suit = suitIndex;
        }

        public override string ToString()
        {
            return $"{Faces[face]} of {(Suits[suit] == "C" ? "♣" : (Suits[suit] == "S" ? "♠" : (Suits[suit] == "D" ? "♦" : "♥")))}";
        }
        public int GetValue()
        {
            return Values[face];
        }

        public string GetFace()
        {
            return Faces[face];
        }

    }
}