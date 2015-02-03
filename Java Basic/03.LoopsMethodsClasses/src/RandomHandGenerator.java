import java.util.*;


public class RandomHandGenerator {
    private static void buildDeck (ArrayList<String> cards) {
        char[] suits = {'\u2663', '\u2666', '\u2665', '\u2660'};
        for (int i = 2; i <= 14; i++) {
            for (int j = 0; j < suits.length; j++) {
                if (i < 10) cards.add("" + i + suits[j]);
                else {
                    switch (i) {
                        case 10:
                            cards.add("10" + suits[j]);
                        case 11:
                            cards.add("J" + suits[j]);
                            break;
                        case 12:
                            cards.add("Q" + suits[j]);
                            break;
                        case 13:
                            cards.add("K" + suits[j]);
                            break;
                        case 14:
                            cards.add("A" + suits[j]);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }

    private static HashSet<Integer> generateHand(Random rnd, ArrayList<String> deck) {
        // making sure the cards indexes are all unique
        HashSet<Integer> cards = new HashSet<>();

        while(cards.size() < 5) {
            cards.add(rnd.nextInt(deck.size()));
        }
        return cards;
    }

    private static void printHand(HashSet<Integer> hand, ArrayList<String> deck) {
        for (Integer i : hand)
            System.out.print(deck.get(i));
        System.out.println();
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        ArrayList<String> deck = new ArrayList<>();
        Random rnd = new Random();
        int n = in.nextInt();

        buildDeck(deck);

        for(int i = 0; i < n; i++) {
            HashSet<Integer> hand = generateHand(rnd, deck);
            printHand(hand, deck);
        }
    }
}
